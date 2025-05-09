using GrafosAlgoritmico.Classes;
using System.Reflection.PortableExecutable;

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
            txtBoxValorNodo.Enabled = false;
            btnDesahacerConexion.Enabled = false;
            btnUnirPuntos.Enabled = false;
        }

        private void panelGrafos_Paint(object sender, PaintEventArgs e)
        {
            if (permisoCrearMatriz && matriz != null)
            {
                // **Primero dibujar las conexiones**
                Graphics g = e.Graphics;
                using (Pen pen = new Pen(colorArista.Color, 5))
                {
                    foreach (EstructuraControl conexion in EstructuraControl.pilaDeNodos)
                    {
                        Nodo nodoOrigen = matriz.Nodos[conexion.IndexFilaOrigen, conexion.IndexColumOrigen];
                        Nodo nodoDestino = matriz.Nodos[conexion.IndexFilaDestino, conexion.IndexColumDestino];

                        int centroXOrigen = nodoOrigen.coordenaEjeX + 25;
                        int centroYOrigen = nodoOrigen.coordenaEjeY + 25;
                        int centroXDestino = nodoDestino.coordenaEjeX + 25;
                        int centroYDestino = nodoDestino.coordenaEjeY + 25;

                        g.DrawLine(pen, centroXOrigen, centroYOrigen, centroXDestino, centroYDestino);
                    }
                }

                // **Luego dibujar los nodos**
                matriz.DibujarNodos(e, 50, 30, colorMatriz.Color);
            }
        }

        private void btnColrMatriz_Click(object sender, EventArgs e) //Para cambiar el color de la matriz
        {
            colorMatriz.ShowDialog();
            btnColrMatriz.BackColor = colorMatriz.Color;
        }

        private void btnColrArista_Click(object sender, EventArgs e)
        {
            colorArista.ShowDialog();
            btnColrArista.BackColor = colorArista.Color;
        }

        private void btnGenerarMatriz_Click(object sender, EventArgs e) //Para generar la matriz
        {
            GenerarMatriz();
        }

        private void GenerarMatriz()
        {
            if (combo2DMatriz.SelectedIndex != -1)
            {
                InicializarValor();
                int dimension = combo2DMatriz.SelectedIndex + 3; //para obtener las longitudes de la matriz
                matriz.CrearMatriz(dimension, dimension, 40, 60, colorMatriz.Color);
                panelGrafos.Refresh();
                MessageBox.Show("Da click en el boton \"Iniciar nodo 1°\" y despues usa las flechas para selecionar el nodo de partida." +
                    "\nDespues de seleccíonarlo dar click en el boton \"Definir nodo\".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtBoxValorNodo.Enabled = true;
                txtBoxValorNodo.Focus();
                btnDesahacerConexion.Enabled = true;
                btnUnirPuntos.Enabled = true;
                MessageBox.Show("Para el siguiente nodo, escribe un valor en el cuadro de texto \"Valor nodo destino\" y despues darle una dirección con las flechas." +
                    "\nDespues de esto darle click en el boton \"Definir nodo\".\n" +
                    "Nota: Hacer esto con los demas nodos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    if (!(txtBoxValorNodo.Text == "" || ComboDireccion.SelectedIndex == -1))
                    {
                        CrearNuevoRegistro();
                        btnStrNodOrig.Enabled = false;
                        ActualizarDataGridView();
                        txtBoxValorNodo.Text = "";
                        ComboDireccion.SelectedIndex = -1;
                        txtBoxValorNodo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Aun falta darle un valor nodo destino o especificar la dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) { MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            panelGrafos.Refresh();

        }
        private void CrearNuevoRegistro()
        {
            int[] IndexNodoA = { matriz.PuntosNodoA[0], matriz.PuntosNodoA[1] };
            int[] IndexNodoB = { matriz.PuntosNodoB[0], matriz.PuntosNodoB[1] };
            string direccionActual = ComboDireccion.Text;
            if (matriz.Nodos[IndexNodoB[0], IndexNodoB[1]].Valor == "")
            {
                throw new ArgumentException("En el grafo aun no aparece el valor del nodo destino. \nIntenta ejecutar de nuevo el comando.");
            }
            matriz.ReiniciarPuntosNodoB();
            EstructuraControl nuevoRegistro = new EstructuraControl(0,
                IndexNodoA[0], IndexNodoA[1], direccionActual, IndexNodoB[0], IndexNodoB[1],
                valorNodoDestino: matriz.Nodos[IndexNodoB[0], IndexNodoB[1]].Valor, valorNodoorigen: matriz.Nodos[IndexNodoA[0], IndexNodoA[1]].Valor);
            EstructuraControl.AgregarRegistro(nuevoRegistro);
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
                panelGrafos.Refresh();
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

        private void btnDesahacerConexion_Click(object sender, EventArgs e)
        {
            if (txtBoxValorNodo.Text == "" || ComboDireccion.SelectedIndex == -1)
            {
                DialogResult resultado = MessageBox.Show("Se eliminará el último registro. \n¿Desea continuar?",
                                        "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar si el usuario hizo clic en "Yes"
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        if (EstructuraControl.pilaDeNodos.Count == 0) //para eliminar el nodo punto partida
                        {
                            comboNodoOrigen.Text = "Aun no definido";
                            MessageBox.Show("Actualmente se puede cambiar el punto de partida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            matriz.DesahacerNodoB(colorMatriz.Color);
                            txtBoxValorNodo.Enabled = false;
                            panelGrafos.Invalidate();
                            GenerarMatriz();
                        }
                        else
                        {
                            matriz.DesahacerNodoB(colorMatriz.Color);
                            panelGrafos.Invalidate();
                            EstructuraControl.EliminarRegistro();
                            ActualizarDataGridView();
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Acción no disponible, primero debe estar vacia la dirección escogina y valor nodo destino.\nEsto debido a que se esta ejecutando la acción de definir un nuevo nodo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Acerca acercaMe = new Acerca();
            acercaMe.Show();
        }

        private void grafoTlSpMenuItemExportGrafo_Click(object sender, EventArgs e)
        {
            Exportar.ImagenPanel(panelGrafos);
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exportar.DtGdVwAPDF(dgdvAlgoritmo);
        }

        private void btnUnirPuntos_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstructuraControl.pilaDeNodos.Count > 1)
                {
                    matriz.BuscarCoincidenciaNodo("1°");
                    int[] IndexNodoFirst = { matriz.PuntosPartida[0], matriz.PuntosPartida[1] };
                    int[] IndexNodoLast = { matriz.PuntosNodoA[0], matriz.PuntosNodoA[1] };
                    string direccionActual = "No definido";
                    EstructuraControl nuevoRegistro = new EstructuraControl(0,
                        IndexNodoFirst[0], IndexNodoFirst[1], direccionActual, IndexNodoLast[0], IndexNodoLast[1],
                        valorNodoDestino: matriz.Nodos[IndexNodoFirst[0], IndexNodoFirst[1]].Valor, valorNodoorigen: matriz.Nodos[IndexNodoLast[0], IndexNodoLast[1]].Valor);
                    EstructuraControl.AgregarRegistro(nuevoRegistro);
                    ActualizarDataGridView();
                    panelGrafos.Refresh();
                    groupPanelControl.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Acción no disponible, primero debe existir al menos dos registro en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cerrarToolStripButton1_Click(object sender, EventArgs e)
        {
            Close(); // dejar de ejecutar la aplicacion
        }
    }
}
