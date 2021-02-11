using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class TableroJuego : Form
    {
        private String _jugadorA;
        private String _jugadorB;
        private int _partidas;
        private int _contadorPartida = 1;
        private bool _turnoA = true;
        private bool _ganador = false;
        

        public TableroJuego()
        {
            InitializeComponent();
        }

        public TableroJuego(string jugadorA, string jugadorB, int partidas)
        {
            InitializeComponent();
            _jugadorA = jugadorA;
            _jugadorB = jugadorB;
            _partidas = partidas;
            lbJugadorA.Text = JugadorA;
            lbJugadorB.Text = JugadorB;
            lbPartidas.Text = String.Format("{0} de {1}", ContadorPartida, Partidas);
            lbTurnoA.Text = String.Format("Es turno del jugador {0}", JugadorA);
            estableceCampo();
        }

        public string JugadorB { get => _jugadorB; set => _jugadorB = value; }

        public string JugadorA { get => _jugadorA; set => _jugadorA = value; }

        public int Partidas { get => _partidas; set => _partidas = value; }

        public int ContadorPartida { get => _contadorPartida; set => _contadorPartida = value; }

        public bool TurnoA { get => _turnoA; set => _turnoA = value; }

        public void estableceCampo() {
            dgvTablero.ColumnCount = 3;
            dgvTablero.RowCount = 3;
            dgvTablero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTablero.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvTablero.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvTablero.MultiSelect = false;
            dgvTablero.Rows.OfType<DataGridViewRow>().ToList().ForEach(x => x.Height = 132);
            dgvTablero.ColumnHeadersVisible = false;
            dgvTablero.RowHeadersVisible = false;

            dgvTablero.AllowUserToAddRows = false;
            dgvTablero.AllowUserToDeleteRows = false;
            dgvTablero.AllowUserToResizeColumns = false;
            dgvTablero.AllowUserToOrderColumns = false;

            dgvTablero.AllowUserToAddRows = false;
            dgvTablero.AllowUserToDeleteRows = false;
            dgvTablero.AllowUserToResizeRows = false;
            
            dgvTablero.TabStop = false;
        }

        private void TableroJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text.Equals("Inciar"))
            {

            }
            else if (btnIniciar.Text.Equals("Nuevo"))
            {
                limpiarControles();
                estableceCampo();
                jugar();
            }
        }

        #region Configuraciones
        private void limpiarControles() { }

        #endregion

        private void jugar()
        {
            while (_ganador == false) {

            }
        }

        private bool validaGanador(String simbolo) {
            bool _bandera = false;
            if (dgvTablero[0, 0].Equals(simbolo) && dgvTablero[1, 1].Equals(simbolo) && dgvTablero[2, 2].Equals(simbolo))
            {
                _bandera = true;
            }
            else if (dgvTablero[0, 2].Equals(simbolo) && dgvTablero[1, 1].Equals(simbolo) && dgvTablero[2, 0].Equals(simbolo))
            {
                _bandera = true;
            }
            else if (dgvTablero[0, 0].Equals(simbolo) && dgvTablero[1, 0].Equals(simbolo) && dgvTablero[2, 0].Equals(simbolo))
            {
                _bandera = true;
            }
            else if (dgvTablero[0, 1].Equals(simbolo) && dgvTablero[1, 1].Equals(simbolo) && dgvTablero[2, 1].Equals(simbolo))
            {
                _bandera = true;
            }
            else if (dgvTablero[0, 2].Equals(simbolo) && dgvTablero[1, 2].Equals(simbolo) && dgvTablero[2, 2].Equals(simbolo))
            {
                _bandera = true;
            }
            else if (dgvTablero[0, 0].Equals(simbolo) && dgvTablero[0, 1].Equals(simbolo) && dgvTablero[0, 2].Equals(simbolo))
            {
                _bandera = true;
            }
            else if (dgvTablero[1, 0].Equals(simbolo) && dgvTablero[1, 1].Equals(simbolo) && dgvTablero[1, 2].Equals(simbolo))
            {
                _bandera = true;
            }
            else if (dgvTablero[2, 0].Equals(simbolo) && dgvTablero[2, 1].Equals(simbolo) && dgvTablero[2, 2].Equals(simbolo))
            {
                _bandera = true;
            }

            return _bandera;
        }

    }
}
