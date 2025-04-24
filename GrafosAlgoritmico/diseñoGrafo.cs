using GrafosAlgoritmico.Classes;

namespace GrafosAlgoritmico
{
    public partial class diseñoGrafo : Form
    {
        MatrizGrafo matriz;
        bool permisoCrearMatriz = false;
        int[] indexAuxMovimiento; //fila, columna. Esto sirve para ubicarse dentro de la matriz de nodos
                                  //fila, columna. Esto es para tener fijo los indices del nodo que sera el punto de partida
        BindingSource bindingSource = new BindingSource();
        List<EstructuraControl> datos = new List<EstructuraControl>();

        public diseñoGrafo()
        {
            InitializeComponent();
            CenterToScreen();

        }
        private void InicializarValor()
        {
            matriz = new MatrizGrafo();
            indexAuxMovimiento = [0, 0]; //fila, columna. Esto sirve para ubicarse dentro de la matriz de nodos
            groupPanelControl.Enabled = true;
            permisoCrearMatriz = true;
            comboNodoOrigen.Text = "Aun no definido";
            matriz.PuntosPartida = [0, 0];
            GroupComandos.Enabled = false;
            btnDefinirNOrignen.Enabled = false;
            btnStrNodOrig.Enabled = true;
            ComboDireccion.SelectedIndex = -1;
            EstructuraControl.IniciarStack();
            IniciarDgdvAlgoritmo();
            ActualizarDataGridView();
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
                comboNodoOrigen.Text = $"fila {matriz.PuntosPartida[0]}, columna {matriz.PuntosPartida[1]}";
                btnStrNodOrig.Enabled = false;
                btnDefinirNOrignen.Enabled = true;
                GroupComandos.Enabled = true;
                indexAuxMovimiento = [0, 0]; //nunca en tu ideas borres esto tan indispensable para que no luches de nuevo con el problema
                txtBoxValorNodo.Text = "";
                ComboDireccion.SelectedIndex = -1;
            }
            else
            { //TODO
                if (!(txtBoxValorNodo.Text == "" || ComboDireccion.SelectedIndex == -1))
                {
                    int[] IndexNodoA = { matriz.PuntosNodoA[0], matriz.PuntosNodoA[1] };
                    int[] IndexNodoB = { matriz.PuntosNodoB[0], matriz.PuntosNodoB[1] };
                    string direccionActual = ComboDireccion.Text;

                    matriz.ReiniciarPuntosNodoB();
                    btnStrNodOrig.Enabled = false;
                    EstructuraControl nuevoRegistro = new EstructuraControl(0,
                        IndexNodoA[0], IndexNodoA[1], direccionActual, IndexNodoB[0], IndexNodoB[1],
                        valorNodoDestino: matriz.Nodos[IndexNodoB[0], IndexNodoB[1]].Valor, valorNodoorigen: matriz.Nodos[IndexNodoA[0], IndexNodoA[1]].Valor);
                    EstructuraControl.AgregarRegistro(nuevoRegistro);
                    ActualizarDataGridView();
                }
                else
                {
                    MessageBox.Show("Aun falta darle un valor nodo destino o especificar la dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }


        private void pictureUpL_Click(object sender, EventArgs e)
        {
            FijarMovimientoPunto(0, -1, -1);
        }

        private void pictureUp_Click(object sender, EventArgs e)
        {
            FijarMovimientoPunto(1, -1, 0);
        }

        private void pictureUpR_Click(object sender, EventArgs e)
        {
            FijarMovimientoPunto(2, -1, 1);
        }

        private void pictureLeft_Click(object sender, EventArgs e)
        {
            FijarMovimientoPunto(3, 0, -1);
        }

        private void pictureRight_Click(object sender, EventArgs e)
        {
            FijarMovimientoPunto(4, 0, 1);
        }

        private void pictureDownL_Click(object sender, EventArgs e)
        {
            FijarMovimientoPunto(5, 1, -1);
        }

        private void pictureDown_Click(object sender, EventArgs e)
        {
            FijarMovimientoPunto(6, 1, 0);
        }

        private void pictureDownR_Click(object sender, EventArgs e)
        {
            FijarMovimientoPunto(7, 1, 1);
        }

        private void FijarMovimientoPunto(int indexComboDireccion, int moveF, int moveC)
        {
            ComboDireccion.SelectedIndex = indexComboDireccion;
            indexAuxMovimiento[0] = moveF;
            indexAuxMovimiento[1] = moveC;
            GenerarMovimientoPunto();
        }



        private void GenerarMovimientoPunto()
        {
            try
            {
                if (comboNodoOrigen.Text == "Aun no definido")
                {
                    matriz.SeleccionarPuntoPartida(colorMatriz.Color, colorNodo.Color, indexAuxMovimiento[0], indexAuxMovimiento[1]);
                    panelGrafos.Invalidate();
                }
                else
                {
                    matriz.SeleccionarSiguientNodo(colorMatriz.Color, colorNodo.Color, indexAuxMovimiento[0], indexAuxMovimiento[1], txtBoxValorNodo.Text);
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
        private void ActualizarDataGridView()
        {
            datos.Clear(); // Limpia la lista
            datos.AddRange(EstructuraControl.pilaDeNodos); // Llena la lista con los datos de la pila
            bindingSource.ResetBindings(false); // Refresca el enlace con los datos
            //dgdvAlgoritmo.DataSource = datos;
            dgdvAlgoritmo.Refresh();

        }


        private void IniciarDgdvAlgoritmo()
        {
            bindingSource.DataSource = datos;
            dgdvAlgoritmo.DataSource = bindingSource;
            dgdvAlgoritmo.Refresh();
        }

        private void diseñoGrafo_Load(object sender, EventArgs e)
        {

        }
    }
}
