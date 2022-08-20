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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Exitosa");
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            Form5 regresar = new Form5();
            regresar.Show();
            this.Hide();
        }
    }
}
