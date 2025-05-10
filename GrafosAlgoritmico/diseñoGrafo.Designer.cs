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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diseñoGrafo));
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
            txtValorNodo = new Label();
            txtBoxValorNodo = new TextBox();
            txtColorMtriz = new Label();
            btnGenerarMatriz = new Button();
            txtColorNodo = new Label();
            txtcolorArista = new Label();
            groupPanelControl = new GroupBox();
            txtNumGrozorArista = new Label();
            label1 = new Label();
            trackBGrozorArista = new TrackBar();
            btnUnirPuntos = new Button();
            btnColrArista = new Button();
            btnColrNodo = new Button();
            btnDesahacerConexion = new Button();
            btnStrNodOrig = new Button();
            btnDefinirNOrignen = new Button();
            colorArista = new ColorDialog();
            btnColrMatriz = new Button();
            dgdvAlgoritmo = new DataGridView();
            NumeroPaso = new DataGridViewTextBoxColumn();
            indexFilaOrigenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            indexColumOrigenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ValorNodoorigen = new DataGridViewTextBoxColumn();
            direccionDestinoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            indexFilaDestinoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            indexColumDestinoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorNodoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estructuraControlBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            grafoTlSpMenuItemExportGrafo = new ToolStripMenuItem();
            algoritmoToolStripMenuItem = new ToolStripMenuItem();
            pDFToolStripMenuItem = new ToolStripMenuItem();
            tlStripAcerca = new ToolStripButton();
            cerrarToolStripButton1 = new ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)trackBGrozorArista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgdvAlgoritmo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estructuraControlBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelGrafos
            // 
            panelGrafos.BorderStyle = BorderStyle.FixedSingle;
            panelGrafos.Location = new Point(12, 27);
            panelGrafos.Name = "panelGrafos";
            panelGrafos.Size = new Size(433, 378);
            panelGrafos.TabIndex = 0;
            panelGrafos.Paint += panelGrafos_Paint;
            // 
            // combo2DMatriz
            // 
            combo2DMatriz.FormattingEnabled = true;
            combo2DMatriz.Items.AddRange(new object[] { "3x3", "4x4", "5x5", "6x6" });
            combo2DMatriz.Location = new Point(605, 34);
            combo2DMatriz.Name = "combo2DMatriz";
            combo2DMatriz.Size = new Size(97, 23);
            combo2DMatriz.TabIndex = 2;
            // 
            // txtMatriz
            // 
            txtMatriz.AutoSize = true;
            txtMatriz.Location = new Point(456, 36);
            txtMatriz.Name = "txtMatriz";
            txtMatriz.Size = new Size(130, 15);
            txtMatriz.TabIndex = 3;
            txtMatriz.Text = "Dimensiones de nodos:";
            // 
            // txtNodoOrigen
            // 
            txtNodoOrigen.AutoSize = true;
            txtNodoOrigen.Location = new Point(6, 34);
            txtNodoOrigen.Name = "txtNodoOrigen";
            txtNodoOrigen.Size = new Size(131, 15);
            txtNodoOrigen.TabIndex = 4;
            txtNodoOrigen.Text = "Estado de nodo Origen:";
            // 
            // comboNodoOrigen
            // 
            comboNodoOrigen.Enabled = false;
            comboNodoOrigen.Location = new Point(153, 31);
            comboNodoOrigen.Name = "comboNodoOrigen";
            comboNodoOrigen.Size = new Size(100, 23);
            comboNodoOrigen.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.AutoSize = true;
            txtDireccion.Location = new Point(264, 177);
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
            ComboDireccion.Location = new Point(391, 174);
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
            GroupComandos.Location = new Point(6, 120);
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
            // txtValorNodo
            // 
            txtValorNodo.AutoSize = true;
            txtValorNodo.Location = new Point(6, 80);
            txtValorNodo.Name = "txtValorNodo";
            txtValorNodo.Size = new Size(109, 15);
            txtValorNodo.TabIndex = 4;
            txtValorNodo.Text = "Valor nodo destino:";
            // 
            // txtBoxValorNodo
            // 
            txtBoxValorNodo.Location = new Point(131, 76);
            txtBoxValorNodo.Name = "txtBoxValorNodo";
            txtBoxValorNodo.Size = new Size(100, 23);
            txtBoxValorNodo.TabIndex = 5;
            // 
            // txtColorMtriz
            // 
            txtColorMtriz.AutoSize = true;
            txtColorMtriz.Location = new Point(710, 36);
            txtColorMtriz.Name = "txtColorMtriz";
            txtColorMtriz.Size = new Size(91, 15);
            txtColorMtriz.TabIndex = 4;
            txtColorMtriz.Text = "Color de nodos:";
            // 
            // btnGenerarMatriz
            // 
            btnGenerarMatriz.Location = new Point(898, 24);
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
            txtColorNodo.Location = new Point(258, 34);
            txtColorNodo.Name = "txtColorNodo";
            txtColorNodo.Size = new Size(89, 15);
            txtColorNodo.TabIndex = 4;
            txtColorNodo.Text = "Color del nodo:";
            // 
            // txtcolorArista
            // 
            txtcolorArista.AutoSize = true;
            txtcolorArista.Location = new Point(260, 76);
            txtcolorArista.Name = "txtcolorArista";
            txtcolorArista.Size = new Size(89, 15);
            txtcolorArista.TabIndex = 4;
            txtcolorArista.Text = "Color del arista:";
            // 
            // groupPanelControl
            // 
            groupPanelControl.Controls.Add(txtNumGrozorArista);
            groupPanelControl.Controls.Add(label1);
            groupPanelControl.Controls.Add(trackBGrozorArista);
            groupPanelControl.Controls.Add(btnUnirPuntos);
            groupPanelControl.Controls.Add(btnColrArista);
            groupPanelControl.Controls.Add(btnColrNodo);
            groupPanelControl.Controls.Add(comboNodoOrigen);
            groupPanelControl.Controls.Add(txtNodoOrigen);
            groupPanelControl.Controls.Add(btnDesahacerConexion);
            groupPanelControl.Controls.Add(txtValorNodo);
            groupPanelControl.Controls.Add(txtColorNodo);
            groupPanelControl.Controls.Add(btnStrNodOrig);
            groupPanelControl.Controls.Add(GroupComandos);
            groupPanelControl.Controls.Add(btnDefinirNOrignen);
            groupPanelControl.Controls.Add(ComboDireccion);
            groupPanelControl.Controls.Add(txtcolorArista);
            groupPanelControl.Controls.Add(txtDireccion);
            groupPanelControl.Controls.Add(txtBoxValorNodo);
            groupPanelControl.Enabled = false;
            groupPanelControl.Location = new Point(451, 76);
            groupPanelControl.Name = "groupPanelControl";
            groupPanelControl.Size = new Size(556, 338);
            groupPanelControl.TabIndex = 12;
            groupPanelControl.TabStop = false;
            // 
            // txtNumGrozorArista
            // 
            txtNumGrozorArista.AutoSize = true;
            txtNumGrozorArista.Location = new Point(510, 130);
            txtNumGrozorArista.Name = "txtNumGrozorArista";
            txtNumGrozorArista.Size = new Size(13, 15);
            txtNumGrozorArista.TabIndex = 17;
            txtNumGrozorArista.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 130);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 16;
            label1.Text = "Grosor de la arista:";
            // 
            // trackBGrozorArista
            // 
            trackBGrozorArista.Location = new Point(374, 120);
            trackBGrozorArista.Name = "trackBGrozorArista";
            trackBGrozorArista.Size = new Size(130, 45);
            trackBGrozorArista.TabIndex = 15;
            trackBGrozorArista.TickStyle = TickStyle.Both;
            trackBGrozorArista.Scroll += trackBGrozorArista_Scroll;
            // 
            // btnUnirPuntos
            // 
            btnUnirPuntos.Location = new Point(360, 276);
            btnUnirPuntos.Name = "btnUnirPuntos";
            btnUnirPuntos.Size = new Size(100, 43);
            btnUnirPuntos.TabIndex = 14;
            btnUnirPuntos.Text = "Unir nodos (Inicial - Final)";
            btnUnirPuntos.UseVisualStyleBackColor = true;
            btnUnirPuntos.Click += btnUnirPuntos_Click;
            // 
            // btnColrArista
            // 
            btnColrArista.BackColor = SystemColors.MenuText;
            btnColrArista.Location = new Point(362, 75);
            btnColrArista.Margin = new Padding(3, 2, 3, 2);
            btnColrArista.Name = "btnColrArista";
            btnColrArista.Size = new Size(64, 19);
            btnColrArista.TabIndex = 13;
            btnColrArista.UseVisualStyleBackColor = false;
            btnColrArista.Click += btnColrArista_Click;
            // 
            // btnColrNodo
            // 
            btnColrNodo.BackColor = SystemColors.MenuText;
            btnColrNodo.Location = new Point(360, 33);
            btnColrNodo.Margin = new Padding(3, 2, 3, 2);
            btnColrNodo.Name = "btnColrNodo";
            btnColrNodo.Size = new Size(64, 19);
            btnColrNodo.TabIndex = 13;
            btnColrNodo.UseVisualStyleBackColor = false;
            btnColrNodo.Click += btnColrNodo_Click;
            // 
            // btnDesahacerConexion
            // 
            btnDesahacerConexion.Location = new Point(425, 216);
            btnDesahacerConexion.Name = "btnDesahacerConexion";
            btnDesahacerConexion.Size = new Size(100, 43);
            btnDesahacerConexion.TabIndex = 9;
            btnDesahacerConexion.Text = "Desahacer\r\nultimo nodo\r\n";
            btnDesahacerConexion.UseVisualStyleBackColor = true;
            btnDesahacerConexion.Click += btnDesahacerConexion_Click;
            // 
            // btnStrNodOrig
            // 
            btnStrNodOrig.Location = new Point(446, 48);
            btnStrNodOrig.Name = "btnStrNodOrig";
            btnStrNodOrig.Size = new Size(88, 43);
            btnStrNodOrig.TabIndex = 11;
            btnStrNodOrig.Text = "Iniciar nodo 1°";
            btnStrNodOrig.UseVisualStyleBackColor = true;
            btnStrNodOrig.Click += btnStrNodOrig_Click;
            // 
            // btnDefinirNOrignen
            // 
            btnDefinirNOrignen.Location = new Point(292, 216);
            btnDefinirNOrignen.Name = "btnDefinirNOrignen";
            btnDefinirNOrignen.Size = new Size(100, 43);
            btnDefinirNOrignen.TabIndex = 11;
            btnDefinirNOrignen.Text = "Definir nodo ";
            btnDefinirNOrignen.UseVisualStyleBackColor = true;
            btnDefinirNOrignen.Click += btnDefinirNOrignen_Click;
            // 
            // btnColrMatriz
            // 
            btnColrMatriz.BackColor = SystemColors.MenuText;
            btnColrMatriz.Location = new Point(816, 35);
            btnColrMatriz.Margin = new Padding(3, 2, 3, 2);
            btnColrMatriz.Name = "btnColrMatriz";
            btnColrMatriz.Size = new Size(64, 19);
            btnColrMatriz.TabIndex = 13;
            btnColrMatriz.UseVisualStyleBackColor = false;
            btnColrMatriz.Click += btnColrMatriz_Click;
            // 
            // dgdvAlgoritmo
            // 
            dgdvAlgoritmo.AllowUserToOrderColumns = true;
            dgdvAlgoritmo.AutoGenerateColumns = false;
            dgdvAlgoritmo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdvAlgoritmo.Columns.AddRange(new DataGridViewColumn[] { NumeroPaso, indexFilaOrigenDataGridViewTextBoxColumn, indexColumOrigenDataGridViewTextBoxColumn, ValorNodoorigen, direccionDestinoDataGridViewTextBoxColumn, indexFilaDestinoDataGridViewTextBoxColumn, indexColumDestinoDataGridViewTextBoxColumn, valorNodoDataGridViewTextBoxColumn });
            dgdvAlgoritmo.DataSource = estructuraControlBindingSource;
            dgdvAlgoritmo.Location = new Point(12, 411);
            dgdvAlgoritmo.Name = "dgdvAlgoritmo";
            dgdvAlgoritmo.RowHeadersWidth = 51;
            dgdvAlgoritmo.Size = new Size(633, 176);
            dgdvAlgoritmo.TabIndex = 1;
            // 
            // NumeroPaso
            // 
            NumeroPaso.DataPropertyName = "NumeroPaso";
            NumeroPaso.HeaderText = "No. Paso";
            NumeroPaso.MinimumWidth = 6;
            NumeroPaso.Name = "NumeroPaso";
            NumeroPaso.ReadOnly = true;
            NumeroPaso.Width = 40;
            // 
            // indexFilaOrigenDataGridViewTextBoxColumn
            // 
            indexFilaOrigenDataGridViewTextBoxColumn.DataPropertyName = "IndexFilaOrigen";
            indexFilaOrigenDataGridViewTextBoxColumn.HeaderText = "Fila nodo origen";
            indexFilaOrigenDataGridViewTextBoxColumn.MinimumWidth = 6;
            indexFilaOrigenDataGridViewTextBoxColumn.Name = "indexFilaOrigenDataGridViewTextBoxColumn";
            indexFilaOrigenDataGridViewTextBoxColumn.ReadOnly = true;
            indexFilaOrigenDataGridViewTextBoxColumn.Width = 60;
            // 
            // indexColumOrigenDataGridViewTextBoxColumn
            // 
            indexColumOrigenDataGridViewTextBoxColumn.DataPropertyName = "IndexColumOrigen";
            indexColumOrigenDataGridViewTextBoxColumn.HeaderText = "Columna nodo origen";
            indexColumOrigenDataGridViewTextBoxColumn.MinimumWidth = 6;
            indexColumOrigenDataGridViewTextBoxColumn.Name = "indexColumOrigenDataGridViewTextBoxColumn";
            indexColumOrigenDataGridViewTextBoxColumn.ReadOnly = true;
            indexColumOrigenDataGridViewTextBoxColumn.Width = 70;
            // 
            // ValorNodoorigen
            // 
            ValorNodoorigen.DataPropertyName = "ValorNodoorigen";
            ValorNodoorigen.HeaderText = "Texto del nodo origen";
            ValorNodoorigen.MinimumWidth = 6;
            ValorNodoorigen.Name = "ValorNodoorigen";
            ValorNodoorigen.ReadOnly = true;
            ValorNodoorigen.Width = 125;
            // 
            // direccionDestinoDataGridViewTextBoxColumn
            // 
            direccionDestinoDataGridViewTextBoxColumn.DataPropertyName = "DireccionDestino";
            direccionDestinoDataGridViewTextBoxColumn.HeaderText = "Direccion de destino";
            direccionDestinoDataGridViewTextBoxColumn.MinimumWidth = 6;
            direccionDestinoDataGridViewTextBoxColumn.Name = "direccionDestinoDataGridViewTextBoxColumn";
            direccionDestinoDataGridViewTextBoxColumn.ReadOnly = true;
            direccionDestinoDataGridViewTextBoxColumn.Width = 140;
            // 
            // indexFilaDestinoDataGridViewTextBoxColumn
            // 
            indexFilaDestinoDataGridViewTextBoxColumn.DataPropertyName = "IndexFilaDestino";
            indexFilaDestinoDataGridViewTextBoxColumn.HeaderText = "Fila nodo destino";
            indexFilaDestinoDataGridViewTextBoxColumn.MinimumWidth = 6;
            indexFilaDestinoDataGridViewTextBoxColumn.Name = "indexFilaDestinoDataGridViewTextBoxColumn";
            indexFilaDestinoDataGridViewTextBoxColumn.ReadOnly = true;
            indexFilaDestinoDataGridViewTextBoxColumn.Width = 60;
            // 
            // indexColumDestinoDataGridViewTextBoxColumn
            // 
            indexColumDestinoDataGridViewTextBoxColumn.DataPropertyName = "IndexColumDestino";
            indexColumDestinoDataGridViewTextBoxColumn.HeaderText = "Columna nodo destino";
            indexColumDestinoDataGridViewTextBoxColumn.MinimumWidth = 6;
            indexColumDestinoDataGridViewTextBoxColumn.Name = "indexColumDestinoDataGridViewTextBoxColumn";
            indexColumDestinoDataGridViewTextBoxColumn.ReadOnly = true;
            indexColumDestinoDataGridViewTextBoxColumn.Width = 70;
            // 
            // valorNodoDataGridViewTextBoxColumn
            // 
            valorNodoDataGridViewTextBoxColumn.DataPropertyName = "ValorNodo";
            valorNodoDataGridViewTextBoxColumn.HeaderText = "Texto del nodo destino";
            valorNodoDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorNodoDataGridViewTextBoxColumn.Name = "valorNodoDataGridViewTextBoxColumn";
            valorNodoDataGridViewTextBoxColumn.ReadOnly = true;
            valorNodoDataGridViewTextBoxColumn.Width = 125;
            // 
            // estructuraControlBindingSource
            // 
            estructuraControlBindingSource.DataSource = typeof(Classes.EstructuraControl);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, tlStripAcerca, cerrarToolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1016, 25);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { grafoTlSpMenuItemExportGrafo, algoritmoToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(67, 22);
            toolStripSplitButton1.Text = "Exportar";
            // 
            // grafoTlSpMenuItemExportGrafo
            // 
            grafoTlSpMenuItemExportGrafo.Name = "grafoTlSpMenuItemExportGrafo";
            grafoTlSpMenuItemExportGrafo.Size = new Size(128, 22);
            grafoTlSpMenuItemExportGrafo.Text = "Grafo";
            grafoTlSpMenuItemExportGrafo.Click += grafoTlSpMenuItemExportGrafo_Click;
            // 
            // algoritmoToolStripMenuItem
            // 
            algoritmoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pDFToolStripMenuItem });
            algoritmoToolStripMenuItem.Name = "algoritmoToolStripMenuItem";
            algoritmoToolStripMenuItem.Size = new Size(128, 22);
            algoritmoToolStripMenuItem.Text = "Algoritmo";
            // 
            // pDFToolStripMenuItem
            // 
            pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            pDFToolStripMenuItem.Size = new Size(95, 22);
            pDFToolStripMenuItem.Text = "PDF";
            pDFToolStripMenuItem.Click += pDFToolStripMenuItem_Click;
            // 
            // tlStripAcerca
            // 
            tlStripAcerca.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tlStripAcerca.Image = (Image)resources.GetObject("tlStripAcerca.Image");
            tlStripAcerca.ImageTransparentColor = Color.Magenta;
            tlStripAcerca.Name = "tlStripAcerca";
            tlStripAcerca.Size = new Size(63, 22);
            tlStripAcerca.Text = "Acerca de";
            tlStripAcerca.Click += toolStripButton1_Click;
            // 
            // cerrarToolStripButton1
            // 
            cerrarToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            cerrarToolStripButton1.Image = (Image)resources.GetObject("cerrarToolStripButton1.Image");
            cerrarToolStripButton1.ImageTransparentColor = Color.Magenta;
            cerrarToolStripButton1.Name = "cerrarToolStripButton1";
            cerrarToolStripButton1.Size = new Size(43, 22);
            cerrarToolStripButton1.Text = "Cerrar";
            cerrarToolStripButton1.Click += cerrarToolStripButton1_Click;
            // 
            // diseñoGrafo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 526);
            Controls.Add(toolStrip1);
            Controls.Add(btnColrMatriz);
            Controls.Add(groupPanelControl);
            Controls.Add(btnGenerarMatriz);
            Controls.Add(txtColorMtriz);
            Controls.Add(txtMatriz);
            Controls.Add(combo2DMatriz);
            Controls.Add(dgdvAlgoritmo);
            Controls.Add(panelGrafos);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            ((System.ComponentModel.ISupportInitialize)trackBGrozorArista).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgdvAlgoritmo).EndInit();
            ((System.ComponentModel.ISupportInitialize)estructuraControlBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private Label txtValorNodo;
        private TextBox txtBoxValorNodo;
        private Label txtColorMtriz;
        private Button btnGenerarMatriz;
        private Label txtColorNodo;
        private Label txtcolorArista;
        private GroupBox groupPanelControl;
        private ColorDialog colorArista;
        private Button btnDefinirNOrignen;
        private Button btnColrArista;
        private Button btnColrNodo;
        private Button btnStrNodOrig;
        private Button btnColrMatriz;
        private DataGridView dgdvAlgoritmo;
        private BindingSource estructuraControlBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripButton tlStripAcerca;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem grafoTlSpMenuItemExportGrafo;
        private ToolStripMenuItem algoritmoToolStripMenuItem;
        private ToolStripMenuItem pDFToolStripMenuItem;
        private Button btnDesahacerConexion;
        private Button btnUnirPuntos;
        private ToolStripButton cerrarToolStripButton1;
        private Label label1;
        private TrackBar trackBGrozorArista;
        private Label txtNumGrozorArista;
        private DataGridViewTextBoxColumn NumeroPaso;
        private DataGridViewTextBoxColumn indexFilaOrigenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn indexColumOrigenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ValorNodoorigen;
        private DataGridViewTextBoxColumn direccionDestinoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn indexFilaDestinoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn indexColumDestinoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorNodoDataGridViewTextBoxColumn;
    }
}
