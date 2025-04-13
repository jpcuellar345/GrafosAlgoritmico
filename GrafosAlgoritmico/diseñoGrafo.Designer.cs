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
            txtNodoOrigen = new Label();
            textBox1 = new TextBox();
            txtVectores = new Label();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgdvAlgoritmo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            comboBox1.Location = new Point(588, 9);
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
            txtMatriz.Size = new Size(81, 15);
            txtMatriz.TabIndex = 3;
            txtMatriz.Text = "Definir Matriz:";
            // 
            // txtNodoOrigen
            // 
            txtNodoOrigen.AutoSize = true;
            txtNodoOrigen.Location = new Point(496, 68);
            txtNodoOrigen.Name = "txtNodoOrigen";
            txtNodoOrigen.Size = new Size(79, 15);
            txtNodoOrigen.TabIndex = 4;
            txtNodoOrigen.Text = "Nodo Origen:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(588, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // txtVectores
            // 
            txtVectores.AutoSize = true;
            txtVectores.Location = new Point(496, 128);
            txtVectores.Name = "txtVectores";
            txtVectores.Size = new Size(110, 15);
            txtVectores.TabIndex = 6;
            txtVectores.Text = "Dirección escogida:";
            // 
            // comboBox2
            // 
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Arriba", "Abajo", "Izquierda", "Derecha", "Arriba y a la izquierda", "Arriba y a la derecha", "Abajo y a la izquierda", "Abajo y a la derecha" });
            comboBox2.Location = new Point(609, 125);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(260, 23);
            comboBox2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(632, 245);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // diseñoGrafo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 576);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox2);
            Controls.Add(txtVectores);
            Controls.Add(textBox1);
            Controls.Add(txtNodoOrigen);
            Controls.Add(txtMatriz);
            Controls.Add(comboBox1);
            Controls.Add(dgdvAlgoritmo);
            Controls.Add(panelGrafos);
            Name = "diseñoGrafo";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgdvAlgoritmo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label txtNodoOrigen;
        private TextBox textBox1;
        private Label txtVectores;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
    }
}
