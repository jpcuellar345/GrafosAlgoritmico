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
            btnColrArista = new Button();
            btnColrNodo = new Button();
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
            ((System.ComponentModel.ISupportInitialize)estructuraControlBindingSource).BeginInit();
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
            // combo2DMatriz
            // 
            combo2DMatriz.FormattingEnabled = true;
            combo2DMatriz.Items.AddRange(new object[] { "3x3", "4x4", "5x5" });
            combo2DMatriz.Location = new Point(691, 25);
            combo2DMatriz.Margin = new Padding(3, 4, 3, 4);
            combo2DMatriz.Name = "combo2DMatriz";
            combo2DMatriz.Size = new Size(110, 28);
            combo2DMatriz.TabIndex = 2;
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
            txtNodoOrigen.Location = new Point(8, 93);
            txtNodoOrigen.Name = "txtNodoOrigen";
            txtNodoOrigen.Size = new Size(166, 20);
            txtNodoOrigen.TabIndex = 4;
            txtNodoOrigen.Text = "Estado de nodo Origen:";
            // 
            // comboNodoOrigen
            // 
            comboNodoOrigen.Enabled = false;
            comboNodoOrigen.Location = new Point(176, 89);
            comboNodoOrigen.Margin = new Padding(3, 4, 3, 4);
            comboNodoOrigen.Name = "comboNodoOrigen";
            comboNodoOrigen.Size = new Size(114, 27);
            comboNodoOrigen.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.AutoSize = true;
            txtDireccion.Location = new Point(302, 224);
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
            ComboDireccion.Location = new Point(447, 220);
            ComboDireccion.Margin = new Padding(3, 4, 3, 4);
            ComboDireccion.Name = "ComboDireccion";
            ComboDireccion.Size = new Size(181, 28);
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
            GroupComandos.Location = new Point(8, 208);
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
            // btnDesahacerConexion
            // 
            btnDesahacerConexion.Location = new Point(478, 304);
            btnDesahacerConexion.Margin = new Padding(3, 4, 3, 4);
            btnDesahacerConexion.Name = "btnDesahacerConexion";
            btnDesahacerConexion.Size = new Size(122, 57);
            btnDesahacerConexion.TabIndex = 9;
            btnDesahacerConexion.Text = "Desahacer\r\nconexion";
            btnDesahacerConexion.UseVisualStyleBackColor = true;
            btnDesahacerConexion.Click += btnDesahacerConexion_Click;
            // 
            // btnExportGrafo
            // 
            btnExportGrafo.Location = new Point(904, 588);
            btnExportGrafo.Margin = new Padding(3, 4, 3, 4);
            btnExportGrafo.Name = "btnExportGrafo";
            btnExportGrafo.Size = new Size(83, 71);
            btnExportGrafo.TabIndex = 9;
            btnExportGrafo.Text = "Exportar\r\nGrafo";
            btnExportGrafo.UseVisualStyleBackColor = true;
            // 
            // btnExportAlgoritmo
            // 
            btnExportAlgoritmo.Location = new Point(1021, 588);
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
            txtValorNodo.Location = new Point(8, 155);
            txtValorNodo.Name = "txtValorNodo";
            txtValorNodo.Size = new Size(138, 20);
            txtValorNodo.TabIndex = 4;
            txtValorNodo.Text = "Valor nodo destino:";
            // 
            // txtBoxValorNodo
            // 
            txtBoxValorNodo.Location = new Point(151, 149);
            txtBoxValorNodo.Margin = new Padding(3, 4, 3, 4);
            txtBoxValorNodo.Name = "txtBoxValorNodo";
            txtBoxValorNodo.Size = new Size(114, 27);
            txtBoxValorNodo.TabIndex = 5;
            // 
            // txtColorMtriz
            // 
            txtColorMtriz.AutoSize = true;
            txtColorMtriz.Location = new Point(811, 28);
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
            txtColorNodo.Location = new Point(296, 93);
            txtColorNodo.Name = "txtColorNodo";
            txtColorNodo.Size = new Size(112, 20);
            txtColorNodo.TabIndex = 4;
            txtColorNodo.Text = "Color del nodo:";
            // 
            // txtcolorArista
            // 
            txtcolorArista.AutoSize = true;
            txtcolorArista.Location = new Point(298, 149);
            txtcolorArista.Name = "txtcolorArista";
            txtcolorArista.Size = new Size(113, 20);
            txtcolorArista.TabIndex = 4;
            txtcolorArista.Text = "Color del arista:";
            // 
            // groupPanelControl
            // 
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
            groupPanelControl.Location = new Point(515, 81);
            groupPanelControl.Margin = new Padding(3, 4, 3, 4);
            groupPanelControl.Name = "groupPanelControl";
            groupPanelControl.Padding = new Padding(3, 4, 3, 4);
            groupPanelControl.Size = new Size(635, 451);
            groupPanelControl.TabIndex = 12;
            groupPanelControl.TabStop = false;
            // 
            // btnColrArista
            // 
            btnColrArista.BackColor = SystemColors.MenuText;
            btnColrArista.Location = new Point(415, 148);
            btnColrArista.Name = "btnColrArista";
            btnColrArista.Size = new Size(73, 25);
            btnColrArista.TabIndex = 13;
            btnColrArista.UseVisualStyleBackColor = false;
            btnColrArista.Click += btnColrArista_Click;
            // 
            // btnColrNodo
            // 
            btnColrNodo.BackColor = SystemColors.MenuText;
            btnColrNodo.Location = new Point(413, 92);
            btnColrNodo.Name = "btnColrNodo";
            btnColrNodo.Size = new Size(73, 25);
            btnColrNodo.TabIndex = 13;
            btnColrNodo.UseVisualStyleBackColor = false;
            btnColrNodo.Click += btnColrNodo_Click;
            // 
            // btnStrNodOrig
            // 
            btnStrNodOrig.Location = new Point(18, 29);
            btnStrNodOrig.Margin = new Padding(3, 4, 3, 4);
            btnStrNodOrig.Name = "btnStrNodOrig";
            btnStrNodOrig.Size = new Size(101, 57);
            btnStrNodOrig.TabIndex = 11;
            btnStrNodOrig.Text = "Iniciar nodo";
            btnStrNodOrig.UseVisualStyleBackColor = true;
            btnStrNodOrig.Click += btnStrNodOrig_Click;
            // 
            // btnDefinirNOrignen
            // 
            btnDefinirNOrignen.Location = new Point(328, 304);
            btnDefinirNOrignen.Margin = new Padding(3, 4, 3, 4);
            btnDefinirNOrignen.Name = "btnDefinirNOrignen";
            btnDefinirNOrignen.Size = new Size(120, 57);
            btnDefinirNOrignen.TabIndex = 11;
            btnDefinirNOrignen.Text = "Definir\r\nnodo origen";
            btnDefinirNOrignen.UseVisualStyleBackColor = true;
            btnDefinirNOrignen.Click += btnDefinirNOrignen_Click;
            // 
            // btnColrMatriz
            // 
            btnColrMatriz.BackColor = SystemColors.MenuText;
            btnColrMatriz.Location = new Point(933, 27);
            btnColrMatriz.Name = "btnColrMatriz";
            btnColrMatriz.Size = new Size(73, 25);
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
            dgdvAlgoritmo.Location = new Point(14, 560);
            dgdvAlgoritmo.Margin = new Padding(3, 4, 3, 4);
            dgdvAlgoritmo.Name = "dgdvAlgoritmo";
            dgdvAlgoritmo.RowHeadersWidth = 51;
            dgdvAlgoritmo.Size = new Size(769, 210);
            dgdvAlgoritmo.TabIndex = 1;
            // 
            // NumeroPaso
            // 
            NumeroPaso.DataPropertyName = "NumeroPaso";
            NumeroPaso.HeaderText = "No. Paso";
            NumeroPaso.MinimumWidth = 6;
            NumeroPaso.Name = "NumeroPaso";
            NumeroPaso.ReadOnly = true;
            NumeroPaso.Width = 60;
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
            indexColumOrigenDataGridViewTextBoxColumn.Width = 60;
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
            direccionDestinoDataGridViewTextBoxColumn.Width = 120;
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
            indexColumDestinoDataGridViewTextBoxColumn.Width = 60;
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
            // diseñoGrafo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 795);
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
            Margin = new Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)estructuraControlBindingSource).EndInit();
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
        private ColorDialog colorArista;
        private Button btnDefinirNOrignen;
        private Button btnColrArista;
        private Button btnColrNodo;
        private Button btnStrNodOrig;
        private Button btnColrMatriz;
        private DataGridView dgdvAlgoritmo;
        private BindingSource estructuraControlBindingSource;
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
