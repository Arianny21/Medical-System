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
    public partial class ConsultasForm : Form
    {


        
        public ConsultasForm()
        {
            InitializeComponent();
        }



        private void FormConsulta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Guardado.");

           
        }

        private void ConsultasForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Guardado.");
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Guardado.");
        }

        private void Regresar_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            PaginaPrincipal principal = new PaginaPrincipal();
            principal.Show();
            this.Hide();
        }

    }
    }
