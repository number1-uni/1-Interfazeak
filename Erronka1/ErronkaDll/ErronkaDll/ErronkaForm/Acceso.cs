using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ErronkaForm
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            
            NpgsqlConnection cn = new NpgsqlConnection("Server=192.168.65.13;User Id=IG;Password=admin;Database=PhoneTic");
            cn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("SELECT erabiltzaileak.user, password FROM public.erabiltzaileak WHERE erabiltzaileak.user='" 
                + user.Text + "' AND erabiltzaileak.password = '" + password.Text + "'",cn);
            NpgsqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                Form formHome = new HomeForm();
                formHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erabiltzailea edo pasahitza okerrak, saiatu berriro.");
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ezkutatu_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '\0')
            {
                erakutsi.BringToFront();
                password.PasswordChar = '*';
            }
        }

        private void erakutsi_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '*')
            {
                ezkutatu.BringToFront();
                password.PasswordChar = '\0';
            }
        }

    }
}
