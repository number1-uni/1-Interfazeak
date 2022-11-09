using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErronkaForm
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Salmentakbtn_Click(object sender, EventArgs e)//Abrimos el formulario Salmentak
        {
            this.Hide();
            Form formSalmentak = new Salmentak();
            formSalmentak.Show();
        }

        private void Erosketakbtn_Click(object sender, EventArgs e)//Abrimos el formulario Erosketak 
        {
            this.Hide();
            Form formErosketak = new Erosketak();
            formErosketak.Show();
        }

        private void Laburpenabtn_Click(object sender, EventArgs e)//Abrimos el formulario Laburpena
        {
            this.Hide();
            Form formLaburpena = new Laburpena();
            formLaburpena.Show();
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAcceso = new Acceso();
            formAcceso.Show();
        }
    }
}
