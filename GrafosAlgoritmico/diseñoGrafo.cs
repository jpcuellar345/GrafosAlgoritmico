using GrafosAlgoritmico.Classes;

namespace GrafosAlgoritmico
{
    public partial class diseñoGrafo : Form
    {
        MatrizGrafo matriz = new MatrizGrafo();
        bool permisoCrearMatriz = false;
        public diseñoGrafo()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void panelGrafos_Paint(object sender, PaintEventArgs e)
        {
            if (permisoCrearMatriz && matriz != null)
            {
                matriz.DibujarNodos(sender, e, 50, 30);
            }
        }

        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            if (combo2DMatriz.SelectedIndex != -1)
            {
                int dimension = combo2DMatriz.SelectedIndex + 3;
                matriz.CrearMatriz(dimension, dimension, 40, 60, colorNodos.Color);
                panelGrafos.Invalidate();
                groupPanelControl.Enabled = true;
                permisoCrearMatriz = true;
            }
            else
            {
                MessageBox.Show("No se ha definido las dimensiones de la matriz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combo2DMatriz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo2DMatriz.SelectedIndex != -1)
            {
                MessageBox.Show("Da aceptar para escoger un color a la matriz.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                colorNodos.ShowDialog();
                comboColorMatriz.BackColor = colorNodos.Color;
            }
        }

        private void pictureUpL_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 0;
        }

        private void pictureUp_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 1;
        }

        private void pictureUpR_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 2;
        }

        private void pictureLeft_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 3;
        }

        private void pictureRight_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 4;
        }

        private void pictureDownL_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 5;
        }

        private void pictureDown_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 6;
        }

        private void pictureDownR_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 7;
        }
        private void pictureCenter_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = -1;
        }

        private void comboNodoOrigen_TextChanged(object sender, EventArgs e)
        {
            //TODO

        }

        private void btnCamColrNodo_Click(object sender, EventArgs e)
        {
            if (colorNodo.ShowDialog() == DialogResult.OK)
            {
                comboColorNodo.BackColor = colorNodo.Color;
                //matriz.Nodos[1, 1].color = colorDialog2.Color; // Cambiar el color del nodo
                //panelGrafos.Invalidate(); // Redibujar el panel
            }
        }

        
    }
}
