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
    public partial class PaginaPrincipal : Form
    {

        
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void uc_hm1_Load(object sender, EventArgs e)
        {

        }

        private  void OpenForms(object FormsDif)
        {

            if (PrincipalPanel.Controls.Count > 0)
                this.PrincipalPanel.Controls.RemoveAt(0);
            Form fp = FormsDif as Form;
            fp.TopLevel = false;
            fp.Dock = DockStyle.Fill;
            this.PrincipalPanel.Controls.Add(fp);
            this.PrincipalPanel.Tag = fp;
            fp.Show();


        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            OpenForms(new ConsultasForm());
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            OpenForms(new EmergenciasForm());
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            OpenForms(new Form9());
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
