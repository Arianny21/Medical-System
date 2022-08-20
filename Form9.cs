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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            String usuario, contra;
            usuario = textNombre.Text;
            contra = textContraseña.Text;

            if (usuario == "Admin" && contra == "admin")
            {
                Form5 administracion = new Form5();
                administracion.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ingrese datos válidos");
            }
            
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            PaginaPrincipal regresar = new PaginaPrincipal();
            regresar.Show();
            this.Hide();
        }
    }
}
