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
    public partial class Form1 : Form
    {
        private String _jugarA = "";
        private String _jugarB = "";
        private int _numeroJuegos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            _jugarA = txtNickNameA.Text;
            _jugarB = txtNickNameB.Text;
            _numeroJuegos = Convert.ToInt32(nudJuegos.Value);
            TableroJuego tableroJuego = new TableroJuego(_jugarA, _jugarB, _numeroJuegos);
            tableroJuego.Show();
            this.Hide();
        }
    }
}