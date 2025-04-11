using GrafosAlgoritmico.Classes;

namespace GrafosAlgoritmico
{
    public partial class diseñoGrafo : Form
    {
        public diseñoGrafo()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void panelGrafos_Paint(object sender, PaintEventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                MessageBox.Show("Se le solicitara dos color para crear la matriz de nodos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if ((colorDialog1.ShowDialog() == DialogResult.OK) && (colorDialog2.ShowDialog() == DialogResult.OK))
                {
                    int dimension = comboBox1.SelectedIndex + 3;
                    MatrizGrafo matriz = new MatrizGrafo(dimension, dimension, 40, 60, colorDialog1.Color, colorDialog2.Color);
                    matriz.DibujarNodos(sender, e, 50, 30);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelGrafos.Invalidate();

        }
    }
}
