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
                    using (Document doc = new Document(PageSize.A4.Rotate())) // Ajusta la página horizontalmente
                    {
                        PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                        doc.Open();

                        PdfPTable table = new PdfPTable(dgv.Columns.Count)
                        {
                            WidthPercentage = 100 // Ajusta el ancho total de la tabla en el PDF
                        };

                        // **Definir anchos dinámicos de columna**
                        float[] anchosColumnas = new float[dgv.Columns.Count];
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            anchosColumnas[i] = dgv.Columns[i].Width; // Usa el mismo ancho del DataGridView
                        }
                        table.SetWidths(anchosColumnas);

                        // **Fuente personalizada**
                        iTextSharp.text.Font fuenteEncabezado = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                        iTextSharp.text.Font fuenteDatos = FontFactory.GetFont(FontFactory.HELVETICA, 10);

                        // **Agregar encabezados**
                        foreach (DataGridViewColumn col in dgv.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, fuenteEncabezado))
                            {
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                BackgroundColor = new BaseColor(200, 200, 200) // Color gris claro
                            };
                            table.AddCell(cell);
                        }

                        // **Agregar filas**
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "", fuenteDatos))
                                {
                                    HorizontalAlignment = Element.ALIGN_CENTER,
                                    Padding = 5 // Espaciado interno en la celda
                                };
                                table.AddCell(pdfCell);
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
    }
}
