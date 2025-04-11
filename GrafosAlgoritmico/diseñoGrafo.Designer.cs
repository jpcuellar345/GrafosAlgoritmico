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
            panelGraphs = new Panel();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelGraphs
            // 
            panelGraphs.BorderStyle = BorderStyle.FixedSingle;
            panelGraphs.Location = new Point(12, 12);
            panelGraphs.Name = "panelGraphs";
            panelGraphs.Size = new Size(563, 374);
            panelGraphs.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 405);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(676, 113);
            dataGridView1.TabIndex = 1;
            // 
            // diseñoGrafo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 541);
            Controls.Add(dataGridView1);
            Controls.Add(panelGraphs);
            Name = "diseñoGrafo";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGraphs;
        private DataGridView dataGridView1;
    }
}
