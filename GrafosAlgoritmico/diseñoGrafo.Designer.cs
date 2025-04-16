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
            combo2DMatriz = new ComboBox();
            txtMatriz = new Label();
            colorMatriz = new ColorDialog();
            colorNodo = new ColorDialog();
            txtNodoOrigen = new Label();
            comboNodoOrigen = new TextBox();
            txtDireccion = new Label();
            ComboDireccion = new ComboBox();
            GroupComandos = new GroupBox();
            pictureDownR = new PictureBox();
            pictureUpR = new PictureBox();
            pictureRight = new PictureBox();
            pictureLeft = new PictureBox();
            pictureDownL = new PictureBox();
            pictureDown = new PictureBox();
            pictureUpL = new PictureBox();
            pictureUp = new PictureBox();
            btnCrearConexion = new Button();
            btnDesahacerConexion = new Button();
            btnExportGrafo = new Button();
            btnExportAlgoritmo = new Button();
            txtValorNodo = new Label();
            txtBoxValorNodo = new TextBox();
            txtColorMtriz = new Label();
            btnGenerarMatriz = new Button();
            txtColorNodo = new Label();
            txtcolorArista = new Label();
            groupPanelControl = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            btnColrNodo = new Button();
            txtColrLetra = new Label();
            btnStrNodOrig = new Button();
            btnDefinirNOrignen = new Button();
            colorLetra = new ColorDialog();
            colorArista = new ColorDialog();
            dgdvAlgoritmo = new DataGridView();
            btnColrMatriz = new Button();
            GroupComandos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureDownR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUpR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureDownL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUpL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUp).BeginInit();
            groupPanelControl.SuspendLayout();
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
            // combo2DMatriz
            // 
            combo2DMatriz.FormattingEnabled = true;
            combo2DMatriz.Items.AddRange(new object[] { "3x3", "4x4", "5x5" });
            combo2DMatriz.Location = new Point(605, 19);
            combo2DMatriz.Name = "combo2DMatriz";
            combo2DMatriz.Size = new Size(97, 23);
            combo2DMatriz.TabIndex = 2;
            // 
            // txtMatriz
            // 
            txtMatriz.AutoSize = true;
            txtMatriz.Location = new Point(456, 21);
            txtMatriz.Name = "txtMatriz";
            txtMatriz.Size = new Size(130, 15);
            txtMatriz.TabIndex = 3;
            txtMatriz.Text = "Dimensiones de nodos:";
            // 
            // txtNodoOrigen
            // 
            txtNodoOrigen.AutoSize = true;
            txtNodoOrigen.Location = new Point(7, 70);
            txtNodoOrigen.Name = "txtNodoOrigen";
            txtNodoOrigen.Size = new Size(131, 15);
            txtNodoOrigen.TabIndex = 4;
            txtNodoOrigen.Text = "Estado de nodo Origen:";
            // 
            // comboNodoOrigen
            // 
            comboNodoOrigen.Enabled = false;
            comboNodoOrigen.Location = new Point(154, 67);
            comboNodoOrigen.Name = "comboNodoOrigen";
            comboNodoOrigen.Size = new Size(100, 23);
            comboNodoOrigen.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.AutoSize = true;
            txtDireccion.Location = new Point(262, 222);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(110, 15);
            txtDireccion.TabIndex = 6;
            txtDireccion.Text = "Dirección escogida:";
            // 
            // ComboDireccion
            // 
            ComboDireccion.Enabled = false;
            ComboDireccion.FormattingEnabled = true;
            ComboDireccion.Items.AddRange(new object[] { "Arriba y a la izquierda", "Arriba", "Arriba y a la derecha", "Izquierda", "Derecha", "Abajo y a la izquierda", "Abajo", "Abajo y a la derecha" });
            ComboDireccion.Location = new Point(389, 219);
            ComboDireccion.Name = "ComboDireccion";
            ComboDireccion.Size = new Size(159, 23);
            ComboDireccion.TabIndex = 7;
            ComboDireccion.SelectedIndexChanged += ComboDireccion_SelectedIndexChanged;
            // 
            // GroupComandos
            // 
            GroupComandos.Controls.Add(pictureDownR);
            GroupComandos.Controls.Add(pictureUpR);
            GroupComandos.Controls.Add(pictureRight);
            GroupComandos.Controls.Add(pictureLeft);
            GroupComandos.Controls.Add(pictureDownL);
            GroupComandos.Controls.Add(pictureDown);
            GroupComandos.Controls.Add(pictureUpL);
            GroupComandos.Controls.Add(pictureUp);
            GroupComandos.Location = new Point(7, 156);
            GroupComandos.Name = "GroupComandos";
            GroupComandos.Size = new Size(253, 178);
            GroupComandos.TabIndex = 8;
            GroupComandos.TabStop = false;
            GroupComandos.Text = "Comandos";
            // 
            // pictureDownR
            // 
            pictureDownR.Image = Properties.Resources.down___right_;
            pictureDownR.Location = new Point(168, 124);
            pictureDownR.Name = "pictureDownR";
            pictureDownR.Size = new Size(59, 43);
            pictureDownR.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureDownR.TabIndex = 0;
            pictureDownR.TabStop = false;
            pictureDownR.Click += pictureDownR_Click;
            // 
            // pictureUpR
            // 
            pictureUpR.Image = Properties.Resources.up_right;
            pictureUpR.Location = new Point(168, 23);
            pictureUpR.Name = "pictureUpR";
            pictureUpR.Size = new Size(59, 43);
            pictureUpR.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureUpR.TabIndex = 0;
            pictureUpR.TabStop = false;
            pictureUpR.Click += pictureUpR_Click;
            // 
            // pictureRight
            // 
            pictureRight.Image = Properties.Resources.rigth;
            pictureRight.Location = new Point(168, 72);
            pictureRight.Name = "pictureRight";
            pictureRight.Size = new Size(59, 43);
            pictureRight.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureRight.TabIndex = 0;
            pictureRight.TabStop = false;
            pictureRight.Click += pictureRight_Click;
            // 
            // pictureLeft
            // 
            pictureLeft.Image = Properties.Resources.left;
            pictureLeft.Location = new Point(38, 72);
            pictureLeft.Name = "pictureLeft";
            pictureLeft.Size = new Size(59, 43);
            pictureLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLeft.TabIndex = 0;
            pictureLeft.TabStop = false;
            pictureLeft.Click += pictureLeft_Click;
            // 
            // pictureDownL
            // 
            pictureDownL.Image = Properties.Resources.down_left;
            pictureDownL.Location = new Point(38, 124);
            pictureDownL.Name = "pictureDownL";
            pictureDownL.Size = new Size(59, 43);
            pictureDownL.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureDownL.TabIndex = 0;
            pictureDownL.TabStop = false;
            pictureDownL.Click += pictureDownL_Click;
            // 
            // pictureDown
            // 
            pictureDown.Image = Properties.Resources.down;
            pictureDown.Location = new Point(103, 124);
            pictureDown.Name = "pictureDown";
            pictureDown.Size = new Size(59, 43);
            pictureDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureDown.TabIndex = 0;
            pictureDown.TabStop = false;
            pictureDown.Click += pictureDown_Click;
            // 
            // pictureUpL
            // 
            pictureUpL.Image = Properties.Resources.up_left;
            pictureUpL.Location = new Point(38, 23);
            pictureUpL.Name = "pictureUpL";
            pictureUpL.Size = new Size(59, 43);
            pictureUpL.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureUpL.TabIndex = 0;
            pictureUpL.TabStop = false;
            pictureUpL.Click += pictureUpL_Click;
            // 
            // pictureUp
            // 
            pictureUp.Image = Properties.Resources.up;
            pictureUp.Location = new Point(103, 23);
            pictureUp.Name = "pictureUp";
            pictureUp.Size = new Size(59, 43);
            pictureUp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureUp.TabIndex = 0;
            pictureUp.TabStop = false;
            pictureUp.Click += pictureUp_Click;
            // 
            // btnCrearConexion
            // 
            btnCrearConexion.Location = new Point(266, 279);
            btnCrearConexion.Name = "btnCrearConexion";
            btnCrearConexion.Size = new Size(73, 53);
            btnCrearConexion.TabIndex = 9;
            btnCrearConexion.Text = "Crear\r\nconexion";
            btnCrearConexion.UseVisualStyleBackColor = true;
            // 
            // btnDesahacerConexion
            // 
            btnDesahacerConexion.Location = new Point(357, 279);
            btnDesahacerConexion.Name = "btnDesahacerConexion";
            btnDesahacerConexion.Size = new Size(83, 53);
            btnDesahacerConexion.TabIndex = 9;
            btnDesahacerConexion.Text = "Desahacer\r\nconexion";
            btnDesahacerConexion.UseVisualStyleBackColor = true;
            // 
            // btnExportGrafo
            // 
            btnExportGrafo.Location = new Point(728, 441);
            btnExportGrafo.Name = "btnExportGrafo";
            btnExportGrafo.Size = new Size(73, 53);
            btnExportGrafo.TabIndex = 9;
            btnExportGrafo.Text = "Exportar\r\nGrafo";
            btnExportGrafo.UseVisualStyleBackColor = true;
            // 
            // btnExportAlgoritmo
            // 
            btnExportAlgoritmo.Location = new Point(830, 441);
            btnExportAlgoritmo.Name = "btnExportAlgoritmo";
            btnExportAlgoritmo.Size = new Size(73, 53);
            btnExportAlgoritmo.TabIndex = 9;
            btnExportAlgoritmo.Text = "Exportar\r\nAlgoritmo";
            btnExportAlgoritmo.UseVisualStyleBackColor = true;
            // 
            // txtValorNodo
            // 
            txtValorNodo.AutoSize = true;
            txtValorNodo.Location = new Point(7, 116);
            txtValorNodo.Name = "txtValorNodo";
            txtValorNodo.Size = new Size(109, 15);
            txtValorNodo.TabIndex = 4;
            txtValorNodo.Text = "Valor nodo destino:";
            // 
            // txtBoxValorNodo
            // 
            txtBoxValorNodo.Location = new Point(132, 112);
            txtBoxValorNodo.Name = "txtBoxValorNodo";
            txtBoxValorNodo.Size = new Size(100, 23);
            txtBoxValorNodo.TabIndex = 5;
            // 
            // txtColorMtriz
            // 
            txtColorMtriz.AutoSize = true;
            txtColorMtriz.Location = new Point(710, 21);
            txtColorMtriz.Name = "txtColorMtriz";
            txtColorMtriz.Size = new Size(91, 15);
            txtColorMtriz.TabIndex = 4;
            txtColorMtriz.Text = "Color de nodos:";
            // 
            // btnGenerarMatriz
            // 
            btnGenerarMatriz.Location = new Point(898, 9);
            btnGenerarMatriz.Name = "btnGenerarMatriz";
            btnGenerarMatriz.Size = new Size(78, 46);
            btnGenerarMatriz.TabIndex = 11;
            btnGenerarMatriz.Text = "Generar\r\nmatriz";
            btnGenerarMatriz.UseVisualStyleBackColor = true;
            btnGenerarMatriz.Click += btnGenerarMatriz_Click;
            // 
            // txtColorNodo
            // 
            txtColorNodo.AutoSize = true;
            txtColorNodo.Location = new Point(259, 70);
            txtColorNodo.Name = "txtColorNodo";
            txtColorNodo.Size = new Size(89, 15);
            txtColorNodo.TabIndex = 4;
            txtColorNodo.Text = "Color del nodo:";
            // 
            // txtcolorArista
            // 
            txtcolorArista.AutoSize = true;
            txtcolorArista.Location = new Point(267, 179);
            txtcolorArista.Name = "txtcolorArista";
            txtcolorArista.Size = new Size(89, 15);
            txtcolorArista.TabIndex = 4;
            txtcolorArista.Text = "Color del arista:";
            // 
            // groupPanelControl
            // 
            groupPanelControl.Controls.Add(button3);
            groupPanelControl.Controls.Add(button2);
            groupPanelControl.Controls.Add(btnColrNodo);
            groupPanelControl.Controls.Add(comboNodoOrigen);
            groupPanelControl.Controls.Add(txtNodoOrigen);
            groupPanelControl.Controls.Add(btnDesahacerConexion);
            groupPanelControl.Controls.Add(txtValorNodo);
            groupPanelControl.Controls.Add(btnCrearConexion);
            groupPanelControl.Controls.Add(txtColrLetra);
            groupPanelControl.Controls.Add(txtColorNodo);
            groupPanelControl.Controls.Add(btnStrNodOrig);
            groupPanelControl.Controls.Add(GroupComandos);
            groupPanelControl.Controls.Add(btnDefinirNOrignen);
            groupPanelControl.Controls.Add(ComboDireccion);
            groupPanelControl.Controls.Add(txtcolorArista);
            groupPanelControl.Controls.Add(txtDireccion);
            groupPanelControl.Controls.Add(txtBoxValorNodo);
            groupPanelControl.Enabled = false;
            groupPanelControl.Location = new Point(451, 61);
            groupPanelControl.Name = "groupPanelControl";
            groupPanelControl.Size = new Size(556, 338);
            groupPanelControl.TabIndex = 12;
            groupPanelControl.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuText;
            button3.Location = new Point(369, 178);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(64, 19);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuText;
            button2.Location = new Point(333, 114);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(64, 19);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnColrNodo
            // 
            btnColrNodo.BackColor = SystemColors.MenuText;
            btnColrNodo.Location = new Point(361, 69);
            btnColrNodo.Margin = new Padding(3, 2, 3, 2);
            btnColrNodo.Name = "btnColrNodo";
            btnColrNodo.Size = new Size(64, 19);
            btnColrNodo.TabIndex = 13;
            btnColrNodo.UseVisualStyleBackColor = false;
            btnColrNodo.Click += btnColrNodo_Click;
            // 
            // txtColrLetra
            // 
            txtColrLetra.AutoSize = true;
            txtColrLetra.Location = new Point(237, 116);
            txtColrLetra.Name = "txtColrLetra";
            txtColrLetra.Size = new Size(81, 15);
            txtColrLetra.TabIndex = 4;
            txtColrLetra.Text = "Color de letra:";
            // 
            // btnStrNodOrig
            // 
            btnStrNodOrig.Location = new Point(7, 22);
            btnStrNodOrig.Name = "btnStrNodOrig";
            btnStrNodOrig.Size = new Size(88, 43);
            btnStrNodOrig.TabIndex = 11;
            btnStrNodOrig.Text = "Iniciar nodo";
            btnStrNodOrig.UseVisualStyleBackColor = true;
            btnStrNodOrig.Click += btnStrNodOrig_Click;
            // 
            // btnDefinirNOrignen
            // 
            btnDefinirNOrignen.Location = new Point(443, 88);
            btnDefinirNOrignen.Name = "btnDefinirNOrignen";
            btnDefinirNOrignen.Size = new Size(105, 43);
            btnDefinirNOrignen.TabIndex = 11;
            btnDefinirNOrignen.Text = "Definir\r\nnodo origen";
            btnDefinirNOrignen.UseVisualStyleBackColor = true;
            btnDefinirNOrignen.Click += btnDefinirNOrignen_Click;
            // 
            // dgdvAlgoritmo
            // 
            dgdvAlgoritmo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdvAlgoritmo.Enabled = false;
            dgdvAlgoritmo.Location = new Point(12, 420);
            dgdvAlgoritmo.Name = "dgdvAlgoritmo";
            dgdvAlgoritmo.RowHeadersWidth = 51;
            dgdvAlgoritmo.Size = new Size(671, 94);
            dgdvAlgoritmo.TabIndex = 1;
            // 
            // btnColrMatriz
            // 
            btnColrMatriz.BackColor = SystemColors.MenuText;
            btnColrMatriz.Location = new Point(816, 20);
            btnColrMatriz.Margin = new Padding(3, 2, 3, 2);
            btnColrMatriz.Name = "btnColrMatriz";
            btnColrMatriz.Size = new Size(64, 19);
            btnColrMatriz.TabIndex = 13;
            btnColrMatriz.UseVisualStyleBackColor = false;
            btnColrMatriz.Click += btnColrMatriz_Click;
            // 
            // diseñoGrafo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 526);
            Controls.Add(btnColrMatriz);
            Controls.Add(groupPanelControl);
            Controls.Add(btnGenerarMatriz);
            Controls.Add(btnExportAlgoritmo);
            Controls.Add(btnExportGrafo);
            Controls.Add(txtColorMtriz);
            Controls.Add(txtMatriz);
            Controls.Add(combo2DMatriz);
            Controls.Add(dgdvAlgoritmo);
            Controls.Add(panelGrafos);
            Name = "diseñoGrafo";
            Text = "Grafos";
            GroupComandos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureDownR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUpR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureDownL).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUpL).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUp).EndInit();
            groupPanelControl.ResumeLayout(false);
            groupPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgdvAlgoritmo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGrafos;
        private ComboBox combo2DMatriz;
        private Label txtMatriz;
        private ColorDialog colorMatriz;
        private ColorDialog colorNodo;
        private Label txtNodoOrigen;
        private TextBox comboNodoOrigen;
        private Label txtDireccion;
        private ComboBox ComboDireccion;
        private GroupBox GroupComandos;
        private PictureBox pictureUpR;
        private PictureBox pictureUpL;
        private PictureBox pictureUp;
        private PictureBox pictureDownR;
        private PictureBox pictureDownL;
        private PictureBox pictureDown;
        private PictureBox pictureLeft;
        private PictureBox pictureRight;
        private Button btnCrearConexion;
        private Button btnDesahacerConexion;
        private Button btnExportGrafo;
        private Button btnExportAlgoritmo;
        private Label txtValorNodo;
        private TextBox txtBoxValorNodo;
        private Label txtColorMtriz;
        private Button btnGenerarMatriz;
        private Label txtColorNodo;
        private Label txtcolorArista;
        private GroupBox groupPanelControl;
        private Label txtColrLetra;
        private ColorDialog colorLetra;
        private ColorDialog colorArista;
        private Button btnDefinirNOrignen;
        private Button button3;
        private Button button2;
        private Button btnColrNodo;
        private Button btnStrNodOrig;
        private DataGridView dgdvAlgoritmo;
        private Button btnColrMatriz;
    }
}
