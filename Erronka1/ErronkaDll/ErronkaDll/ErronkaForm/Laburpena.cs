using ErronkaForm.Models;
using Npgsql;
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
    public partial class Laburpena : Form
    {
        public Laburpena()
        {
            InitializeComponent();
        }

        private void Laburpena_Load(object sender, EventArgs e)
        {
            FillDGV();
            UrteaZnblbl.Text = cmbUrteaLaburpena.Text.ToString() + "ko";
            using (var db = new PhoneTicContext())
            {
                int urtea = int.Parse(cmbUrteaLaburpena.Text.ToString());
                int hilabetea = int.Parse(cmbHilabeteaLaburpena.Text.ToString());

                var resultadoSold = db.sale_order_line
                .Where(x => x.write_date.Year.Equals(urtea) && x.write_date.Month.Equals(hilabetea))
                .GroupBy(x => x.write_date.Month)
                .ToDictionary(g => g.Key, g => new { TotalSoldProducts = g.Sum(b => b.product_uom_qty) });
                SalmentakNumlbl.Text = resultadoSold[hilabetea].TotalSoldProducts.ToString() + " Produktu";

                var resultadoIrabaziak = db.sale_order_line
                .Where(x => x.write_date.Year.Equals(urtea) && x.write_date.Month.Equals(hilabetea))
                .GroupBy(x => x.write_date.Month)
                .ToDictionary(g => g.Key, g => new { TotalSoldProducts = g.Sum(b => b.price_total) });
                IrabaziakNumlbl.Text = resultadoIrabaziak[hilabetea].TotalSoldProducts.ToString() + "€";
                double Irabaziak = Double.Parse(resultadoIrabaziak[hilabetea].TotalSoldProducts.ToString());


                var resultadoGastuak = db.purchase_order_line
                .Where(x => x.write_date.Year.Equals(urtea) && x.write_date.Month.Equals(hilabetea))
                .GroupBy(x => x.write_date.Month)
                .ToDictionary(g => g.Key, g => new { TotalBoughtProducts = g.Sum(b => b.price_total) });
                GastuakNumlbl.Text = resultadoGastuak[hilabetea].TotalBoughtProducts.ToString() + "€";
                double Gastuak = Double.Parse(resultadoGastuak[hilabetea].TotalBoughtProducts.ToString());

                Double erantzuna = Irabaziak - Gastuak;

                GuztiraNumlbl.Text = erantzuna.ToString() + "€";

                var saleorder1 = db.sale_order_line

                .Include("res_partner")
                .Where(x => x.write_date.Year.Equals(urtea) && x.write_date.Month.Equals(hilabetea))
                .GroupBy(x => x.name)
                .Take(5)
                .ToDictionary(g => g.Key, g => g.Sum(b => b.product_uom_qty));


                if (saleorder1 != null)
                {
                    if (saleorder1.Count > 0)
                    {
                        var grafikoa = userControl11.Controls 
                        .OfType<System.Windows.Forms.DataVisualization.Charting.Chart>();
                        foreach (var grafiko in grafikoa)
                        {

                            grafiko.DataSource = saleorder1;
                            grafiko.Series[0].YValueMembers = "Value";
                            grafiko.Series[0].XValueMember = "Key";
                            grafiko.DataBind();
                        }
                    }
                }
            }
        }

        private void cmbUrteaLaburpena_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrteaZnblbl.Text = cmbUrteaLaburpena.Text.ToString() + "ko";
            using (var db = new PhoneTicContext())
            {   
                int urtea = int.Parse(cmbUrteaLaburpena.Text.ToString());
                int hilabetea = int.Parse(cmbHilabeteaLaburpena.Text.ToString());

                var resultadoSold = db.sale_order_line
                .Where(x => x.write_date.Year.Equals(urtea) && x.write_date.Month.Equals(hilabetea))
                .GroupBy(x => x.write_date.Month)
                .ToDictionary(g => g.Key, g => new { TotalSoldProducts = g.Sum(b => b.product_uom_qty) });
                SalmentakNumlbl.Text = resultadoSold[hilabetea].TotalSoldProducts.ToString() + " Produktu";

                var resultadoIrabaziak = db.sale_order_line
                .Where(x => x.write_date.Year.Equals(urtea) && x.write_date.Month.Equals(hilabetea))
                .GroupBy(x => x.write_date.Month)
                .ToDictionary(g => g.Key, g => new { TotalSoldProducts = g.Sum(b => b.price_total) });
                IrabaziakNumlbl.Text = resultadoIrabaziak[hilabetea].TotalSoldProducts.ToString() + "€";
                double Irabaziak = Double.Parse(resultadoIrabaziak[hilabetea].TotalSoldProducts.ToString());



                var resultadoGastuak = db.purchase_order_line
                .Where(x => x.write_date.Year.Equals(urtea) && x.write_date.Month.Equals(hilabetea))
                .GroupBy(x => x.write_date.Month)
                .ToDictionary(g => g.Key, g => new { TotalBoughtProducts = g.Sum(b => b.price_total) });
                GastuakNumlbl.Text = resultadoGastuak[hilabetea].TotalBoughtProducts.ToString() + "€";
                double Gastuak = Double.Parse(resultadoGastuak[hilabetea].TotalBoughtProducts.ToString());

                Double erantzuna = Irabaziak - Gastuak;

                GuztiraNumlbl.Text = erantzuna.ToString() + "€";

                var saleorder1 = db.sale_order_line

                .Include("res_partner")
                .Where(x => x.write_date.Year.Equals(urtea) && x.write_date.Month.Equals(hilabetea))
                .GroupBy(x => x.name)
                .Take(5)
                .ToDictionary(g => g.Key, g => g.Sum(b => b.product_uom_qty)); 


                if (saleorder1 != null)
                {
                    if (saleorder1.Count > 0)
                    {
                        var grafikoa = userControl11.Controls 
                        .OfType<System.Windows.Forms.DataVisualization.Charting.Chart>();
                        foreach (var grafiko in grafikoa)
                        {

                            grafiko.DataSource = saleorder1;
                            grafiko.Series[0].YValueMembers = "Value";
                            grafiko.Series[0].XValueMember = "Key";
                            grafiko.DataBind();
                        }
                    }
                }
            }
        }

        private void cmbHilabeteaLaburpena_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHilabeteaLaburpena.SelectedIndex == 0)
            {
                HilabeteaHitzlbl.Text = "Urtarrila";
            }
            else if (cmbHilabeteaLaburpena.SelectedIndex == 1)
            {
                HilabeteaHitzlbl.Text = "Otsaila";
            }
            else if(cmbHilabeteaLaburpena.SelectedIndex == 2)
            {
                HilabeteaHitzlbl.Text = "Martxoa";
            }
            else if(cmbHilabeteaLaburpena.SelectedIndex == 3)
            {
                HilabeteaHitzlbl.Text = "Apirila";
            }
            else if (cmbHilabeteaLaburpena.SelectedIndex == 4)
            {
                HilabeteaHitzlbl.Text = "Maiatza";
            }
            else if (cmbHilabeteaLaburpena.SelectedIndex == 5)
            {
                HilabeteaHitzlbl.Text = "Ekaina";
            }
            else if (cmbHilabeteaLaburpena.SelectedIndex == 6)
            {
                HilabeteaHitzlbl.Text = "Uztaila";
            }
            else if (cmbHilabeteaLaburpena.SelectedIndex == 7)
            {
                HilabeteaHitzlbl.Text = "Abuztua";
            }
            else if (cmbHilabeteaLaburpena.SelectedIndex == 8)
            {
                HilabeteaHitzlbl.Text = "Iraila";
            }
            else if (cmbHilabeteaLaburpena.SelectedIndex == 9)
            {
                HilabeteaHitzlbl.Text = "Urria";
            }
            else if (cmbHilabeteaLaburpena.SelectedIndex == 10)
            {
                HilabeteaHitzlbl.Text = "Azaroa";
            }
            else if (cmbHilabeteaLaburpena.SelectedIndex == 11)
            {
                HilabeteaHitzlbl.Text = "Abendua";
            }
            using (var db = new PhoneTicContext())
            {
                int urtea = int.Parse(cmbUrteaLaburpena.Text.ToString());
                int hilabetea = int.Parse(cmbHilabeteaLaburpena.Text.ToString());

                var resultadoSold = db.sale_order_line
                .Where(x => x.write_date.Year.Equals(urtea) && x.write_date.Month.Equals(hilabetea))
                .GroupBy(x => x.write_date.Month)
                .ToDictionary(g => g.Key, g => new { TotalSoldProducts = g.Sum(b => b.product_uom_qty) });
                 SalmentakNumlbl.Text = resultadoSold[hilabetea].TotalSoldProducts.ToString() + " Produktu"; 
                var resultadoIrabaziak = db.sale_order_line
                .Where(x => x.write_date.Year.Equals(urtea) && x.write_date.Month.Equals(hilabetea))
                .GroupBy(x => x.write_date.Month)
                .ToDictionary(g => g.Key, g => new { TotalSoldProducts = g.Sum(b => b.price_total) });
                IrabaziakNumlbl.Text = resultadoIrabaziak[hilabetea].TotalSoldProducts.ToString() + "€";
                double Irabaziak = Double.Parse(resultadoIrabaziak[hilabetea].TotalSoldProducts.ToString());



                var resultadoGastuak = db.purchase_order_line
                .Where(x => x.write_date.Year.Equals(urtea) && x.write_date.Month.Equals(hilabetea))
                .GroupBy(x => x.write_date.Month)
                .ToDictionary(g => g.Key, g => new { TotalBoughtProducts = g.Sum(b => b.price_total) });
                GastuakNumlbl.Text = resultadoGastuak[hilabetea].TotalBoughtProducts.ToString() + "€";
                double Gastuak = Double.Parse(resultadoGastuak[hilabetea].TotalBoughtProducts.ToString());

                Double erantzuna = Irabaziak - Gastuak;

                GuztiraNumlbl.Text = erantzuna.ToString() + "€";

                var saleorder1 = db.sale_order_line

                .Include("res_partner")
                .Where(x => x.write_date.Year.Equals(urtea) && x.write_date.Month.Equals(hilabetea))
                .GroupBy(x => x.name)
                .Take(5)
                .ToDictionary(g => g.Key, g => g.Sum(b => b.product_uom_qty));


                if (saleorder1 != null)
                {
                    if (saleorder1.Count > 0)
                    {
                        var grafikoa = userControl11.Controls 
                        .OfType<System.Windows.Forms.DataVisualization.Charting.Chart>();
                        foreach (var grafiko in grafikoa)
                        {

                            grafiko.DataSource = saleorder1;
                            grafiko.Series[0].YValueMembers = "Value";
                            grafiko.Series[0].XValueMember = "Key";
                            grafiko.DataBind();
                        }
                    }
                }
            }
        }
        private void FillDGV()
        {
            NpgsqlConnection con = new NpgsqlConnection("Server=192.168.65.13;User Id=IG;Password=admin;Database=PhoneTic");
            con.Open();
            NpgsqlCommand cm = new NpgsqlCommand("SELECT sale_order_line.id,sale_order_line.name,sale_order_line.price_subtotal FROM public.sale_order_line", con);
            NpgsqlDataAdapter com = new NpgsqlDataAdapter("SELECT sale_order_line.id,sale_order_line.name,sale_order_line.price_subtotal FROM public.sale_order_line", con);
            DataTable dt = new DataTable();
            com.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }
        private void ItxiBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formHome = new HomeForm();
            formHome.Show();
        }
    }
}
