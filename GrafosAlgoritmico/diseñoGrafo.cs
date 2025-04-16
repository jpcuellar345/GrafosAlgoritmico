using GrafosAlgoritmico.Classes;
using System.Drawing.Text;

namespace GrafosAlgoritmico
{
    public partial class diseñoGrafo : Form
    {
        MatrizGrafo matriz;
        bool permisoCrearMatriz = false;
        int[] indexAux; //fila, columna. Esto sirve para ubicarse dentro de la matriz de nodos
        int[] indexPuntoPartida; //fila, columna. Esto es para tener fijo los indices del nodo que sera el punto de partida

        public diseñoGrafo()
        {
            InitializeComponent();
            CenterToScreen();

        }
        private void InicializarValor()
        {
            matriz = new MatrizGrafo();
            indexAux = [0, 0]; //fila, columna. Esto sirve para ubicarse dentro de la matriz de nodos
            indexPuntoPartida = new int[2];
            groupPanelControl.Enabled = true;
            permisoCrearMatriz = true;
            comboNodoOrigen.Text = "Aun no definido";
            matriz.PuntosPartida = [0, 0];
            indexAux = [0, 0];
            GroupComandos.Enabled = false;
            btnDefinirNOrignen.Enabled = false;
            btnStrNodOrig.Enabled = true;
            ComboDireccion.SelectedIndex = -1;
        }

        private void panelGrafos_Paint(object sender, PaintEventArgs e)
        {
            if (permisoCrearMatriz && matriz != null)
            {
                matriz.DibujarNodos(e, 50, 30);
            }
        }

        private void btnColrMatriz_Click(object sender, EventArgs e) //Para cambiar el color de la matriz
        {
            colorMatriz.ShowDialog();
            btnColrMatriz.BackColor = colorMatriz.Color;
        }
        private void btnGenerarMatriz_Click(object sender, EventArgs e) //Para generar la matriz
        {
            if (combo2DMatriz.SelectedIndex != -1)
            {
                InicializarValor();
                int dimension = combo2DMatriz.SelectedIndex + 3; //para obtener las longitudes de la matriz
                matriz.CrearMatriz(dimension, dimension, 40, 60, colorMatriz.Color);
                panelGrafos.Invalidate();
            }
            else
            {
                MessageBox.Show("No se ha definido las dimensiones de la matriz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnStrNodOrig_Click(object sender, EventArgs e)
        {
            if (btnColrNodo.BackColor == btnColrMatriz.BackColor)
            {
                MessageBox.Show("La matriz y el nodo de partida no pueden ser del mismo color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ComboDireccion.SelectedIndex = -1;
                GroupComandos.Enabled = true;
                GenerarMovimientoPunto();
            }
        }
        private void btnColrNodo_Click(object sender, EventArgs e)
        {
            colorNodo.ShowDialog();
            btnColrNodo.BackColor = colorNodo.Color;
        }
        private void btnDefinirNOrignen_Click(object sender, EventArgs e) // para dejar fijo el nodo de partida
        {
            if (comboNodoOrigen.Text == "Aun no definido")
            {
                indexPuntoPartida = matriz.PuntosPartida;
                comboNodoOrigen.Text = $"fila {indexPuntoPartida[0] + 1}, columna {indexPuntoPartida[1] + 1}";
                GroupComandos.Enabled = false;
                btnDefinirNOrignen.Enabled = false;
                indexAux = [0, 0];
            }
            else
            {
                //TODO
            }
            btnStrNodOrig.Enabled = true;
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





        private void GenerarMovimientoPunto()
        {
            try
            {
                if (comboNodoOrigen.Text == "Aun no definido")
                {
                    matriz.SeleccionarPuntoPartida(colorMatriz.Color, colorNodo.Color, indexAux[0], indexAux[1]);
                    panelGrafos.Invalidate();
                }
                else
                {
                    matriz.SeleccionarSiguientNodo(colorMatriz.Color, colorNodo.Color, indexAux[0], indexAux[1], txtBoxValorNodo.Text);
                    panelGrafos.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboDireccion.SelectedIndex != -1)
            {
                btnDefinirNOrignen.Enabled = true;
                btnStrNodOrig.Enabled = false;
            }
        }
    }
}
