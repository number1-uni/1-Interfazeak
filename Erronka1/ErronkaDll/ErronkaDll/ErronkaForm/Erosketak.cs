using ErronkaForm.Models;
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
    public partial class Erosketak : Form
    {
        public Erosketak()
        {
            InitializeComponent();
        }

        private void Erosketak_Load(object sender, EventArgs e)
        {
            using (var db = new PhoneTicContext())
            {


                int urtea = int.Parse(cmbUrteaErosketak.Text.ToString());


                //Sacar los productos comprados del año 2022
                //SELECT SUM(purchase_order_line.product_uom_qty) AS TotalBoughtProducts FROM purchase_order_line where write_date between '2022-01-01' and '2022-12-31';
                var resultadoBought = db.purchase_order_line
                .Where(x => x.write_date.Year.Equals(urtea))
                .GroupBy(x => x.write_date.Year)
                .ToDictionary(g => g.Key, g => new { TotalBoughtProducts = g.Sum(b => b.product_uom_qty) });

                ErosketakNumlbl.Text = resultadoBought[urtea].TotalBoughtProducts.ToString() + " Produktu";

                //Sacar las ganancias del año 2022 
                //SELECT SUM(purchase_order_line.price_total) AS TotalSoldProducts FROM purchase_order_line where write_date between '2022-01-01' and '2022-12-31';
                var resultadoGastuak = db.purchase_order_line
                .Where(x => x.write_date.Year.Equals(urtea))
                .GroupBy(x => x.write_date.Year)
                .ToDictionary(g => g.Key, g => new { TotalBoughtProducts = g.Sum(b => b.price_total) });

                GastuakNumlbl.Text = resultadoGastuak[urtea].TotalBoughtProducts.ToString() + "€";

                ///PRODUCTOS QUE MAS SE HAN VENDIDO EN UN AÑO
                ///
                ///GRAFICO DE BARRAS
                ///
                /// MENSUALES
                /// 
                var saleorder1 = db.purchase_order_line

                .Include("res_partner")
                .Where(x => x.write_date.Year.Equals(urtea))
                .GroupBy(x => x.write_date.Month)//el nombre que aparece abajo en los valores
                .ToDictionary(g => g.Key, g => g.Sum(b => b.product_uom_qty));// lo que sale en el grafico, por lo que lo vamos a medir 
                

                if (saleorder1 != null)
                {
                    if (saleorder1.Count > 0)
                    {
                        var grafikoa = userControl21.Controls // el grafico que queremos usar
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

                ///SALMENTAK
                ///
                ///GRAFICO CIRCULAR
                ///
                ///ANUALES

                var saleorder2 = db.purchase_order_line
                .Include("res_partner")
                .Where(x => x.write_date.Year.Equals(urtea))
                .GroupBy(x => x.name)//el nombre que aparece abajo en los valores
                .OrderByDescending(x => x.Sum(b => b.product_uom_qty))
                .Take(3)
                .ToDictionary(g => g.Key, g => g.Sum(b => b.product_uom_qty));// lo que sale en el grafico, por lo que lo vamos a medir 


                if (saleorder2 != null)
                {
                    if (saleorder2.Count > 0)
                    {
                        var grafikoa = userControl1.Controls // el grafico que queremos usar
                        .OfType<System.Windows.Forms.DataVisualization.Charting.Chart>();
                        foreach (var grafiko in grafikoa)
                        {

                            grafiko.DataSource = saleorder2;
                            grafiko.Series[0].YValueMembers = "Value";
                            grafiko.Series[0].XValueMember = "Key";
                            grafiko.DataBind();
                        }
                    }
                }
            }
    }

        private void cmbUrteaErosketak_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrteaZnblbl.Text = cmbUrteaErosketak.Text.ToString();
            using (var db = new PhoneTicContext())
            {

                int urtea = int.Parse(cmbUrteaErosketak.Text.ToString());

                var resultadoBought = db.purchase_order_line
                .Where(x => x.write_date.Year.Equals(urtea))
                .GroupBy(x => x.write_date.Year)
                .ToDictionary(g => g.Key, g => new { TotalBoughtProducts = g.Sum(b => b.product_uom_qty) });

                ErosketakNumlbl.Text = resultadoBought[urtea].TotalBoughtProducts.ToString() + " Produktu";

                var resultadoGastuak = db.purchase_order_line
                .Where(x => x.write_date.Year.Equals(urtea))
                .GroupBy(x => x.write_date.Year)
                .ToDictionary(g => g.Key, g => new { TotalBoughtProducts = g.Sum(b => b.price_total) });

                GastuakNumlbl.Text = resultadoGastuak[urtea].TotalBoughtProducts.ToString() + "€";

                var saleorder1 = db.purchase_order_line

                .Include("res_partner")
                .Where(x => x.write_date.Year.Equals(urtea))
                .GroupBy(x => x.write_date.Month)//el nombre que aparece abajo en los valores
                .ToDictionary(g => g.Key, g => g.Sum(b => b.product_uom_qty));// lo que sale en el grafico, por lo que lo vamos a medir 

               
                if (saleorder1 != null)
                {
                    if (saleorder1.Count > 0)
                    {
                        var grafikoa = userControl21.Controls // el grafico que queremos usar
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

                var saleorder2 = db.purchase_order_line
                .Include("res_partner")
                .Where(x => x.write_date.Year.Equals(urtea))
                .GroupBy(x => x.name)//el nombre que aparece abajo en los valores
                .ToDictionary(g => g.Key, g => g.Sum(b => b.product_uom_qty));// lo que sale en el grafico, por lo que lo vamos a medir 


                if (saleorder2 != null)
                {
                    if (saleorder2.Count > 0)
                    {
                        var grafikoa = userControl1.Controls // el grafico que queremos usar
                        .OfType<System.Windows.Forms.DataVisualization.Charting.Chart>();
                        foreach (var grafiko in grafikoa)
                        {

                            grafiko.DataSource = saleorder2;
                            grafiko.Series[0].YValueMembers = "Value";
                            grafiko.Series[0].XValueMember = "Key";
                            grafiko.DataBind();
                        }
                    }
                }

            }
        }

        private void ItxiBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formHome = new HomeForm();
            formHome.Show();
        }
    }
}

