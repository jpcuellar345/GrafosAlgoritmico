using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GrafosAlgoritmico.Classes
{
    public class Exportar
    {
        public static void ImagenPanel(Panel panel)
        {
            if (panel == null)
            {
                MessageBox.Show("El panel no está disponible para exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                saveFileDialog.Title = "Guardar imagen como";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (Bitmap bitmap = new Bitmap(panel.Width, panel.Height))
                    {
                        panel.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, panel.Width, panel.Height));

                        System.Drawing.Imaging.ImageFormat formato = System.Drawing.Imaging.ImageFormat.Png;
                        if (saveFileDialog.FileName.EndsWith(".jpg")) formato = System.Drawing.Imaging.ImageFormat.Jpeg;
                        else if (saveFileDialog.FileName.EndsWith(".bmp")) formato = System.Drawing.Imaging.ImageFormat.Bmp;

                        bitmap.Save(saveFileDialog.FileName, formato);
                        MessageBox.Show("Imagen guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void DtGdVwAPDF(DataGridView dgv)
        {
            if (dgv == null || dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PDF Files|*.pdf";
                saveDialog.Title = "Guardar archivo PDF";

                if (saveDialog.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (Document doc = new Document())
                    {
                        PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                        doc.Open();
                        PdfPTable table = new PdfPTable(dgv.Columns.Count);

                        iTextSharp.text.Font fuente = FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD);

                        foreach (DataGridViewColumn col in dgv.Columns)
                        {
                            table.AddCell(new PdfPCell(new Phrase(col.HeaderText, fuente)));
                        }

                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
                            }
                        }

                        doc.Add(table);
                        doc.Close();

                        MessageBox.Show("Archivo PDF guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar el archivo PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void DtGdVwAExcel(DataGridView dgv)
        {
            if (dgv == null || dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel Files|*.xlsx";
                saveDialog.Title = "Guardar archivo Excel";

                if (saveDialog.ShowDialog() != DialogResult.OK) return;

                try
                {
                    FileInfo archivo = new FileInfo(saveDialog.FileName);

                    using (ExcelPackage pck = new ExcelPackage())
                    {
                        ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Datos");

                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            ws.Cells[1, i + 1].Value = dgv.Columns[i].HeaderText;
                        }

                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgv.Columns.Count; j++)
                            {
                                ws.Cells[i + 2, j + 1].Value = dgv.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        pck.SaveAs(archivo);
                        MessageBox.Show("Archivo Excel guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar el archivo Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
