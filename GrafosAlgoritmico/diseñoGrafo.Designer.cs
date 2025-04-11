namespace GrafosAlgoritmico
{
    partial class diseñoGrafo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelGrafos = new Panel();
            dgdvAlgoritmo = new DataGridView();
            comboBox1 = new ComboBox();
            txtMatriz = new Label();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)dgdvAlgoritmo).BeginInit();
            SuspendLayout();
            // 
            // panelGrafos
            // 
            panelGrafos.BorderStyle = BorderStyle.FixedSingle;
            panelGrafos.Location = new Point(12, 12);
            panelGrafos.Name = "panelGrafos";
            panelGrafos.Size = new Size(425, 402);
            panelGrafos.TabIndex = 0;
            panelGrafos.Paint += panelGrafos_Paint;
            // 
            // dgdvAlgoritmo
            // 
            dgdvAlgoritmo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdvAlgoritmo.Location = new Point(12, 441);
            dgdvAlgoritmo.Name = "dgdvAlgoritmo";
            dgdvAlgoritmo.Size = new Size(676, 107);
            dgdvAlgoritmo.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "3x3", "4x4", "5x5" });
            comboBox1.Location = new Point(580, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(97, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtMatriz
            // 
            txtMatriz.AutoSize = true;
            txtMatriz.Location = new Point(496, 12);
            txtMatriz.Name = "txtMatriz";
            txtMatriz.Size = new Size(78, 15);
            txtMatriz.TabIndex = 3;
            txtMatriz.Text = "Definir Matriz";
            // 
            // diseñoGrafo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 576);
            Controls.Add(txtMatriz);
            Controls.Add(comboBox1);
            Controls.Add(dgdvAlgoritmo);
            Controls.Add(panelGrafos);
            Name = "diseñoGrafo";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgdvAlgoritmo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGrafos;
        private DataGridView dgdvAlgoritmo;
        private ComboBox comboBox1;
        private Label txtMatriz;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
    }
}
