using GrafosAlgoritmico.Classes;
using System.Drawing.Text;

namespace GrafosAlgoritmico
{
    public partial class diseñoGrafo : Form
    {
        MatrizGrafo matriz = new MatrizGrafo();
        bool permisoCrearMatriz = false;
        int[] indexAux = [0, 0]; //fila, columna. Esto sirve para ubicarse dentro de la matriz de nodos
        int[] indexPuntoPartida = new int[2]; //fila, columna. Esto es para tener fijo los indices del nodo que sera el punto de partida
        public diseñoGrafo()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void panelGrafos_Paint(object sender, PaintEventArgs e)
        {
            if (permisoCrearMatriz && matriz != null)
            {
                matriz.DibujarNodos(e, 50, 30);
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
                comboNodoOrigen.Text = "Aun no definido";
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
            indexAux[0] = -1;
            indexAux[1] = -1;
            GenerarMovimientoPunto();
        }

        private void pictureUp_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 1;
            indexAux[0] = -1;
            indexAux[1] = 0;
            GenerarMovimientoPunto();
        }

        private void pictureUpR_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 2;
            indexAux[0] = -1;
            indexAux[1] = 1;
            GenerarMovimientoPunto();
        }

        private void pictureLeft_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 3;
            indexAux[0] = 0;
            indexAux[1] = -1;
            GenerarMovimientoPunto();
        }

        private void pictureRight_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 4;
            indexAux[0] = 0;
            indexAux[1] = 1;
            GenerarMovimientoPunto();
        }

        private void pictureDownL_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 5;
            indexAux[0] = 1;
            indexAux[1] = -1;
            GenerarMovimientoPunto();
        }

        private void pictureDown_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 6;
            indexAux[0] = 1;
            indexAux[1] = 0;
            GenerarMovimientoPunto();
        }

        private void pictureDownR_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = 7;
            indexAux[0] = 1;
            indexAux[1] = 1;
            GenerarMovimientoPunto();
        }
        private void pictureCenter_Click(object sender, EventArgs e)
        {
            ComboDireccion.SelectedIndex = -1;
        }


        private void btnCamColrNodo_Click(object sender, EventArgs e)
        {
            if (colorNodo.ShowDialog() == DialogResult.OK)
            {
                comboColorNodo.BackColor = colorNodo.Color;
                //matriz.Nodos[1, 1].color = colorDialog2.Color; // Cambiar el color del nodo
                //panelGrafos.Invalidate(); // Redibujar el panel
            }
            GenerarMovimientoPunto();
        }

        private void GenerarMovimientoPunto()
        {
            try
            {
                if (comboNodoOrigen.Text == "Aun no definido")
                {
                    matriz.CambiarPuntoPartida(colorNodos.Color, colorNodo.Color, indexAux[0], indexAux[1]);
                    panelGrafos.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDefinirNOrignen_Click(object sender, EventArgs e) // para dejar fijo el nodo de partida
        {
            indexPuntoPartida = matriz.PuntosPartida;
            comboNodoOrigen.Text = $"fila {indexPuntoPartida[0] + 1}, columna {indexPuntoPartida[1] + 1}\"";
        }
    }
}
