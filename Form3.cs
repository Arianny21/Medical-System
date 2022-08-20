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
    public partial class EmergenciasForm : Form
    {
        public EmergenciasForm()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            PaginaPrincipal principal = new PaginaPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
