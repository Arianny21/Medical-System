using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emergency_Hospital
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form6 Consultas = new Form6();
            Consultas.Show();
            this.Hide();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            PaginaPrincipal regresar = new PaginaPrincipal();
            regresar.Show();
            this.Hide();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form7 doctores = new Form7();
            doctores.Show();
            this.Hide();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Form8 citas = new Form8();
            citas.Show();
            this.Hide();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            Form9 salir = new Form9();
            salir.Show();
            this.Hide();
        }
    }
}
