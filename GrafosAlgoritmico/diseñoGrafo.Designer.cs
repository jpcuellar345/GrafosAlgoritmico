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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diseñoGrafo));
            panelGrafos = new Panel();
            dgdvAlgoritmo = new DataGridView();
            combo2DMatriz = new ComboBox();
            txtMatriz = new Label();
            colorNodos = new ColorDialog();
            colorNodo = new ColorDialog();
            txtNodoOrigen = new Label();
            comboNodoOrigen = new TextBox();
            txtDireccion = new Label();
            ComboDireccion = new ComboBox();
            GroupComandos = new GroupBox();
            pictureDownR = new PictureBox();
            pictureUpR = new PictureBox();
            pictureCenter = new PictureBox();
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
            comboColorMatriz = new TextBox();
            txtColorMtriz = new Label();
            btnGenerarMatriz = new Button();
            txtColorNodo = new Label();
            comboColorNodo = new TextBox();
            btnCamColrNodo = new Button();
            txtcolorArista = new Label();
            btnCambiarColrArista = new Button();
            txtBoxColrArista = new TextBox();
            groupPanelControl = new GroupBox();
            txtBoxColrLetra = new TextBox();
            btnCambiarColrLetra = new Button();
            txtColrLetra = new Label();
            btnDefinirNOrignen = new Button();
            colorLetra = new ColorDialog();
            colorArista = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)dgdvAlgoritmo).BeginInit();
            GroupComandos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureDownR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUpR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCenter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureDownL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUpL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUp).BeginInit();
            groupPanelControl.SuspendLayout();
            SuspendLayout();
            // 
            // panelGrafos
            // 
            panelGrafos.BorderStyle = BorderStyle.FixedSingle;
            panelGrafos.Location = new Point(14, 16);
            panelGrafos.Margin = new Padding(3, 4, 3, 4);
            panelGrafos.Name = "panelGrafos";
            panelGrafos.Size = new Size(485, 535);
            panelGrafos.TabIndex = 0;
            panelGrafos.Paint += panelGrafos_Paint;
            // 
            // dgdvAlgoritmo
            // 
            dgdvAlgoritmo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdvAlgoritmo.Location = new Point(14, 588);
            dgdvAlgoritmo.Margin = new Padding(3, 4, 3, 4);
            dgdvAlgoritmo.Name = "dgdvAlgoritmo";
            dgdvAlgoritmo.RowHeadersWidth = 51;
            dgdvAlgoritmo.Size = new Size(773, 143);
            dgdvAlgoritmo.TabIndex = 1;
            // 
            // combo2DMatriz
            // 
            combo2DMatriz.FormattingEnabled = true;
            combo2DMatriz.Items.AddRange(new object[] { "3x3", "4x4", "5x5" });
            combo2DMatriz.Location = new Point(691, 25);
            combo2DMatriz.Margin = new Padding(3, 4, 3, 4);
            combo2DMatriz.Name = "combo2DMatriz";
            combo2DMatriz.Size = new Size(110, 28);
            combo2DMatriz.TabIndex = 2;
            combo2DMatriz.SelectedIndexChanged += combo2DMatriz_SelectedIndexChanged;
            // 
            // txtMatriz
            // 
            txtMatriz.AutoSize = true;
            txtMatriz.Location = new Point(521, 28);
            txtMatriz.Name = "txtMatriz";
            txtMatriz.Size = new Size(163, 20);
            txtMatriz.TabIndex = 3;
            txtMatriz.Text = "Dimensiones de nodos:";
            // 
            // txtNodoOrigen
            // 
            txtNodoOrigen.AutoSize = true;
            txtNodoOrigen.Location = new Point(7, 43);
            txtNodoOrigen.Name = "txtNodoOrigen";
            txtNodoOrigen.Size = new Size(166, 20);
            txtNodoOrigen.TabIndex = 4;
            txtNodoOrigen.Text = "Estado de nodo Origen:";
            // 
            // comboNodoOrigen
            // 
            comboNodoOrigen.Enabled = false;
            comboNodoOrigen.Location = new Point(175, 39);
            comboNodoOrigen.Margin = new Padding(3, 4, 3, 4);
            comboNodoOrigen.Name = "comboNodoOrigen";
            comboNodoOrigen.Size = new Size(114, 27);
            comboNodoOrigen.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.AutoSize = true;
            txtDireccion.Location = new Point(304, 248);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(139, 20);
            txtDireccion.TabIndex = 6;
            txtDireccion.Text = "Dirección escogida:";
            // 
            // ComboDireccion
            // 
            ComboDireccion.Enabled = false;
            ComboDireccion.FormattingEnabled = true;
            ComboDireccion.Items.AddRange(new object[] { "Arriba y a la izquierda", "Arriba", "Arriba y a la derecha", "Izquierda", "Derecha", "Abajo y a la izquierda", "Abajo", "Abajo y a la derecha" });
            ComboDireccion.Location = new Point(438, 244);
            ComboDireccion.Margin = new Padding(3, 4, 3, 4);
            ComboDireccion.Name = "ComboDireccion";
            ComboDireccion.Size = new Size(181, 28);
            ComboDireccion.TabIndex = 7;
            // 
            // GroupComandos
            // 
            GroupComandos.Controls.Add(pictureDownR);
            GroupComandos.Controls.Add(pictureUpR);
            GroupComandos.Controls.Add(pictureCenter);
            GroupComandos.Controls.Add(pictureRight);
            GroupComandos.Controls.Add(pictureLeft);
            GroupComandos.Controls.Add(pictureDownL);
            GroupComandos.Controls.Add(pictureDown);
            GroupComandos.Controls.Add(pictureUpL);
            GroupComandos.Controls.Add(pictureUp);
            GroupComandos.Location = new Point(8, 225);
            GroupComandos.Margin = new Padding(3, 4, 3, 4);
            GroupComandos.Name = "GroupComandos";
            GroupComandos.Padding = new Padding(3, 4, 3, 4);
            GroupComandos.Size = new Size(289, 237);
            GroupComandos.TabIndex = 8;
            GroupComandos.TabStop = false;
            GroupComandos.Text = "Comandos";
            // 
            // pictureDownR
            // 
            pictureDownR.Image = Properties.Resources.down___right_;
            pictureDownR.Location = new Point(192, 165);
            pictureDownR.Margin = new Padding(3, 4, 3, 4);
            pictureDownR.Name = "pictureDownR";
            pictureDownR.Size = new Size(67, 57);
            pictureDownR.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureDownR.TabIndex = 0;
            pictureDownR.TabStop = false;
            pictureDownR.Click += pictureDownR_Click;
            // 
            // pictureUpR
            // 
            pictureUpR.Image = Properties.Resources.up_right;
            pictureUpR.Location = new Point(192, 31);
            pictureUpR.Margin = new Padding(3, 4, 3, 4);
            pictureUpR.Name = "pictureUpR";
            pictureUpR.Size = new Size(67, 57);
            pictureUpR.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureUpR.TabIndex = 0;
            pictureUpR.TabStop = false;
            pictureUpR.Click += pictureUpR_Click;
            // 
            // pictureCenter
            // 
            pictureCenter.Image = (Image)resources.GetObject("pictureCenter.Image");
            pictureCenter.Location = new Point(118, 96);
            pictureCenter.Margin = new Padding(3, 4, 3, 4);
            pictureCenter.Name = "pictureCenter";
            pictureCenter.Size = new Size(67, 57);
            pictureCenter.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCenter.TabIndex = 0;
            pictureCenter.TabStop = false;
            pictureCenter.Click += pictureCenter_Click;
            // 
            // pictureRight
            // 
            pictureRight.Image = Properties.Resources.rigth;
            pictureRight.Location = new Point(192, 96);
            pictureRight.Margin = new Padding(3, 4, 3, 4);
            pictureRight.Name = "pictureRight";
            pictureRight.Size = new Size(67, 57);
            pictureRight.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureRight.TabIndex = 0;
            pictureRight.TabStop = false;
            pictureRight.Click += pictureRight_Click;
            // 
            // pictureLeft
            // 
            pictureLeft.Image = Properties.Resources.left;
            pictureLeft.Location = new Point(43, 96);
            pictureLeft.Margin = new Padding(3, 4, 3, 4);
            pictureLeft.Name = "pictureLeft";
            pictureLeft.Size = new Size(67, 57);
            pictureLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLeft.TabIndex = 0;
            pictureLeft.TabStop = false;
            pictureLeft.Click += pictureLeft_Click;
            // 
            // pictureDownL
            // 
            pictureDownL.Image = Properties.Resources.down_left;
            pictureDownL.Location = new Point(43, 165);
            pictureDownL.Margin = new Padding(3, 4, 3, 4);
            pictureDownL.Name = "pictureDownL";
            pictureDownL.Size = new Size(67, 57);
            pictureDownL.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureDownL.TabIndex = 0;
            pictureDownL.TabStop = false;
            pictureDownL.Click += pictureDownL_Click;
            // 
            // pictureDown
            // 
            pictureDown.Image = Properties.Resources.down;
            pictureDown.Location = new Point(118, 165);
            pictureDown.Margin = new Padding(3, 4, 3, 4);
            pictureDown.Name = "pictureDown";
            pictureDown.Size = new Size(67, 57);
            pictureDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureDown.TabIndex = 0;
            pictureDown.TabStop = false;
            pictureDown.Click += pictureDown_Click;
            // 
            // pictureUpL
            // 
            pictureUpL.Image = Properties.Resources.up_left;
            pictureUpL.Location = new Point(43, 31);
            pictureUpL.Margin = new Padding(3, 4, 3, 4);
            pictureUpL.Name = "pictureUpL";
            pictureUpL.Size = new Size(67, 57);
            pictureUpL.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureUpL.TabIndex = 0;
            pictureUpL.TabStop = false;
            pictureUpL.Click += pictureUpL_Click;
            // 
            // pictureUp
            // 
            pictureUp.Image = Properties.Resources.up;
            pictureUp.Location = new Point(118, 31);
            pictureUp.Margin = new Padding(3, 4, 3, 4);
            pictureUp.Name = "pictureUp";
            pictureUp.Size = new Size(67, 57);
            pictureUp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureUp.TabIndex = 0;
            pictureUp.TabStop = false;
            pictureUp.Click += pictureUp_Click;
            // 
            // btnCrearConexion
            // 
            btnCrearConexion.Location = new Point(405, 391);
            btnCrearConexion.Margin = new Padding(3, 4, 3, 4);
            btnCrearConexion.Name = "btnCrearConexion";
            btnCrearConexion.Size = new Size(83, 71);
            btnCrearConexion.TabIndex = 9;
            btnCrearConexion.Text = "Crear\r\nconexion";
            btnCrearConexion.UseVisualStyleBackColor = true;
            // 
            // btnDesahacerConexion
            // 
            btnDesahacerConexion.Location = new Point(509, 391);
            btnDesahacerConexion.Margin = new Padding(3, 4, 3, 4);
            btnDesahacerConexion.Name = "btnDesahacerConexion";
            btnDesahacerConexion.Size = new Size(95, 71);
            btnDesahacerConexion.TabIndex = 9;
            btnDesahacerConexion.Text = "Desahacer\r\nconexion";
            btnDesahacerConexion.UseVisualStyleBackColor = true;
            // 
            // btnExportGrafo
            // 
            btnExportGrafo.Location = new Point(839, 660);
            btnExportGrafo.Margin = new Padding(3, 4, 3, 4);
            btnExportGrafo.Name = "btnExportGrafo";
            btnExportGrafo.Size = new Size(83, 71);
            btnExportGrafo.TabIndex = 9;
            btnExportGrafo.Text = "Exportar\r\nGrafo";
            btnExportGrafo.UseVisualStyleBackColor = true;
            // 
            // btnExportAlgoritmo
            // 
            btnExportAlgoritmo.Location = new Point(951, 660);
            btnExportAlgoritmo.Margin = new Padding(3, 4, 3, 4);
            btnExportAlgoritmo.Name = "btnExportAlgoritmo";
            btnExportAlgoritmo.Size = new Size(83, 71);
            btnExportAlgoritmo.TabIndex = 9;
            btnExportAlgoritmo.Text = "Exportar\r\nAlgoritmo";
            btnExportAlgoritmo.UseVisualStyleBackColor = true;
            // 
            // txtValorNodo
            // 
            txtValorNodo.AutoSize = true;
            txtValorNodo.Location = new Point(8, 167);
            txtValorNodo.Name = "txtValorNodo";
            txtValorNodo.Size = new Size(138, 20);
            txtValorNodo.TabIndex = 4;
            txtValorNodo.Text = "Valor nodo destino:";
            // 
            // txtBoxValorNodo
            // 
            txtBoxValorNodo.Location = new Point(151, 163);
            txtBoxValorNodo.Margin = new Padding(3, 4, 3, 4);
            txtBoxValorNodo.Name = "txtBoxValorNodo";
            txtBoxValorNodo.Size = new Size(114, 27);
            txtBoxValorNodo.TabIndex = 5;
            // 
            // comboColorMatriz
            // 
            comboColorMatriz.Enabled = false;
            comboColorMatriz.Location = new Point(929, 25);
            comboColorMatriz.Margin = new Padding(3, 4, 3, 4);
            comboColorMatriz.Name = "comboColorMatriz";
            comboColorMatriz.Size = new Size(79, 27);
            comboColorMatriz.TabIndex = 10;
            // 
            // txtColorMtriz
            // 
            txtColorMtriz.AutoSize = true;
            txtColorMtriz.Location = new Point(808, 28);
            txtColorMtriz.Name = "txtColorMtriz";
            txtColorMtriz.Size = new Size(114, 20);
            txtColorMtriz.TabIndex = 4;
            txtColorMtriz.Text = "Color de nodos:";
            // 
            // btnGenerarMatriz
            // 
            btnGenerarMatriz.Location = new Point(1026, 12);
            btnGenerarMatriz.Margin = new Padding(3, 4, 3, 4);
            btnGenerarMatriz.Name = "btnGenerarMatriz";
            btnGenerarMatriz.Size = new Size(89, 61);
            btnGenerarMatriz.TabIndex = 11;
            btnGenerarMatriz.Text = "Generar\r\nmatriz";
            btnGenerarMatriz.UseVisualStyleBackColor = true;
            btnGenerarMatriz.Click += btnGenerarMatriz_Click;
            // 
            // txtColorNodo
            // 
            txtColorNodo.AutoSize = true;
            txtColorNodo.Location = new Point(302, 43);
            txtColorNodo.Name = "txtColorNodo";
            txtColorNodo.Size = new Size(112, 20);
            txtColorNodo.TabIndex = 4;
            txtColorNodo.Text = "Color del nodo:";
            // 
            // comboColorNodo
            // 
            comboColorNodo.BackColor = SystemColors.MenuText;
            comboColorNodo.Enabled = false;
            comboColorNodo.Location = new Point(411, 39);
            comboColorNodo.Margin = new Padding(3, 4, 3, 4);
            comboColorNodo.Name = "comboColorNodo";
            comboColorNodo.Size = new Size(79, 27);
            comboColorNodo.TabIndex = 10;
            // 
            // btnCamColrNodo
            // 
            btnCamColrNodo.Location = new Point(498, 21);
            btnCamColrNodo.Margin = new Padding(3, 4, 3, 4);
            btnCamColrNodo.Name = "btnCamColrNodo";
            btnCamColrNodo.Size = new Size(120, 57);
            btnCamColrNodo.TabIndex = 11;
            btnCamColrNodo.Text = "Cambiar\r\ncolor del nodo";
            btnCamColrNodo.UseVisualStyleBackColor = true;
            btnCamColrNodo.Click += btnCamColrNodo_Click;
            // 
            // txtcolorArista
            // 
            txtcolorArista.AutoSize = true;
            txtcolorArista.Location = new Point(298, 311);
            txtcolorArista.Name = "txtcolorArista";
            txtcolorArista.Size = new Size(113, 20);
            txtcolorArista.TabIndex = 4;
            txtcolorArista.Text = "Color del arista:";
            // 
            // btnCambiarColrArista
            // 
            btnCambiarColrArista.Location = new Point(509, 297);
            btnCambiarColrArista.Margin = new Padding(3, 4, 3, 4);
            btnCambiarColrArista.Name = "btnCambiarColrArista";
            btnCambiarColrArista.Size = new Size(106, 71);
            btnCambiarColrArista.TabIndex = 11;
            btnCambiarColrArista.Text = "Cambiar\r\ncolor de la arista";
            btnCambiarColrArista.UseVisualStyleBackColor = true;
            // 
            // txtBoxColrArista
            // 
            txtBoxColrArista.BackColor = SystemColors.MenuText;
            txtBoxColrArista.Enabled = false;
            txtBoxColrArista.Location = new Point(414, 307);
            txtBoxColrArista.Margin = new Padding(3, 4, 3, 4);
            txtBoxColrArista.Name = "txtBoxColrArista";
            txtBoxColrArista.Size = new Size(79, 27);
            txtBoxColrArista.TabIndex = 10;
            // 
            // groupPanelControl
            // 
            groupPanelControl.Controls.Add(comboNodoOrigen);
            groupPanelControl.Controls.Add(txtBoxColrLetra);
            groupPanelControl.Controls.Add(txtBoxColrArista);
            groupPanelControl.Controls.Add(txtNodoOrigen);
            groupPanelControl.Controls.Add(btnDesahacerConexion);
            groupPanelControl.Controls.Add(comboColorNodo);
            groupPanelControl.Controls.Add(txtValorNodo);
            groupPanelControl.Controls.Add(btnCambiarColrLetra);
            groupPanelControl.Controls.Add(btnCambiarColrArista);
            groupPanelControl.Controls.Add(btnCrearConexion);
            groupPanelControl.Controls.Add(txtColrLetra);
            groupPanelControl.Controls.Add(txtColorNodo);
            groupPanelControl.Controls.Add(GroupComandos);
            groupPanelControl.Controls.Add(btnDefinirNOrignen);
            groupPanelControl.Controls.Add(btnCamColrNodo);
            groupPanelControl.Controls.Add(ComboDireccion);
            groupPanelControl.Controls.Add(txtcolorArista);
            groupPanelControl.Controls.Add(txtDireccion);
            groupPanelControl.Controls.Add(txtBoxValorNodo);
            groupPanelControl.Enabled = false;
            groupPanelControl.Location = new Point(521, 81);
            groupPanelControl.Margin = new Padding(3, 4, 3, 4);
            groupPanelControl.Name = "groupPanelControl";
            groupPanelControl.Padding = new Padding(3, 4, 3, 4);
            groupPanelControl.Size = new Size(626, 471);
            groupPanelControl.TabIndex = 12;
            groupPanelControl.TabStop = false;
            groupPanelControl.Text = "Panel control";
            // 
            // txtBoxColrLetra
            // 
            txtBoxColrLetra.BackColor = SystemColors.MenuText;
            txtBoxColrLetra.Enabled = false;
            txtBoxColrLetra.Location = new Point(377, 163);
            txtBoxColrLetra.Margin = new Padding(3, 4, 3, 4);
            txtBoxColrLetra.Name = "txtBoxColrLetra";
            txtBoxColrLetra.Size = new Size(79, 27);
            txtBoxColrLetra.TabIndex = 10;
            // 
            // btnCambiarColrLetra
            // 
            btnCambiarColrLetra.Location = new Point(474, 148);
            btnCambiarColrLetra.Margin = new Padding(3, 4, 3, 4);
            btnCambiarColrLetra.Name = "btnCambiarColrLetra";
            btnCambiarColrLetra.Size = new Size(110, 56);
            btnCambiarColrLetra.TabIndex = 11;
            btnCambiarColrLetra.Text = "Cambiar\r\ncolor de letra";
            btnCambiarColrLetra.UseVisualStyleBackColor = true;
            // 
            // txtColrLetra
            // 
            txtColrLetra.AutoSize = true;
            txtColrLetra.Location = new Point(271, 167);
            txtColrLetra.Name = "txtColrLetra";
            txtColrLetra.Size = new Size(103, 20);
            txtColrLetra.TabIndex = 4;
            txtColrLetra.Text = "Color de letra:";
            // 
            // btnDefinirNOrignen
            // 
            btnDefinirNOrignen.Location = new Point(24, 91);
            btnDefinirNOrignen.Margin = new Padding(3, 4, 3, 4);
            btnDefinirNOrignen.Name = "btnDefinirNOrignen";
            btnDefinirNOrignen.Size = new Size(120, 57);
            btnDefinirNOrignen.TabIndex = 11;
            btnDefinirNOrignen.Text = "Definir\r\nnodo origen";
            btnDefinirNOrignen.UseVisualStyleBackColor = true;
            btnDefinirNOrignen.Click += btnDefinirNOrignen_Click;
            // 
            // diseñoGrafo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 768);
            Controls.Add(groupPanelControl);
            Controls.Add(btnGenerarMatriz);
            Controls.Add(comboColorMatriz);
            Controls.Add(btnExportAlgoritmo);
            Controls.Add(btnExportGrafo);
            Controls.Add(txtColorMtriz);
            Controls.Add(txtMatriz);
            Controls.Add(combo2DMatriz);
            Controls.Add(dgdvAlgoritmo);
            Controls.Add(panelGrafos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "diseñoGrafo";
            Text = "Grafos";
            ((System.ComponentModel.ISupportInitialize)dgdvAlgoritmo).EndInit();
            GroupComandos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureDownR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUpR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureCenter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureDownL).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUpL).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUp).EndInit();
            groupPanelControl.ResumeLayout(false);
            groupPanelControl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGrafos;
        private DataGridView dgdvAlgoritmo;
        private ComboBox combo2DMatriz;
        private Label txtMatriz;
        private ColorDialog colorNodos;
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
        private TextBox comboColorMatriz;
        private Label txtColorMtriz;
        private Button btnGenerarMatriz;
        private Label txtColorNodo;
        private TextBox comboColorNodo;
        private Button btnCamColrNodo;
        private Label txtcolorArista;
        private Button btnCambiarColrArista;
        private TextBox txtBoxColrArista;
        private GroupBox groupPanelControl;
        private Button btnCambiarColrLetra;
        private Label txtColrLetra;
        private TextBox txtBoxColrLetra;
        private ColorDialog colorLetra;
        private ColorDialog colorArista;
        private PictureBox pictureCenter;
        private Button btnDefinirNOrignen;
    }
}
