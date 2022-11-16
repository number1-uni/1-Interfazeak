using ErronkaDll;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace ErronkaForm
{
    public partial class Salmentak : Form
    {
        public Salmentak()
        {
            InitializeComponent();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            using (var db = new PhoneTicContext())
            {    

                int urtea = int.Parse(cmbUrteaSalmentak.Text.ToString());

                //Sacar los productos vendidos del año 2022
                
                var resultadoSold = db.sale_order_line
                .Where(x => x.write_date.Year.Equals(urtea))
                .GroupBy(x => x.write_date.Year)
                .ToDictionary(g=>g.Key, g => new { TotalSoldProducts = g.Sum(b => b.product_uom_qty) });

                SalmentakNumlbl.Text = resultadoSold[urtea].TotalSoldProducts.ToString() + " Produktu";

                //Sacar las ganancias del año 2022 
               
                var resultadoIrabaziak = db.sale_order_line
                .Where(x => x.write_date.Year.Equals(urtea))
                .GroupBy(x => x.write_date.Year)
                .ToDictionary(g => g.Key, g => new { TotalSoldProducts = g.Sum(b => b.price_total) });

                IrabaziakNumlbl.Text = resultadoIrabaziak[urtea].TotalSoldProducts.ToString() + "€";


                ///PRODUCTOS QUE MAS SE HAN VENDIDO EN UN AÑO
                ///
                ///GRAFICO DE BARRAS
                ///
                /// MENSUALES

                var saleorder1 = db.sale_order_line
                
                .Include("res_partner")
                .Where(x => x.write_date.Year.Equals(urtea))
                .GroupBy(x => x.write_date.Month)
                .ToDictionary(g => g.Key, g => g.Sum(b => b.product_uom_qty));


                if (saleorder1 != null)
                {
                    if (saleorder1.Count > 0)
                    {
                        var grafikoa = userControl21.Controls 
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
                    ///Co
                    var saleorder2 = db.sale_order_line
                    .Include("res_partner")
                    .Where(x => x.write_date.Year.Equals(urtea))
                    .GroupBy(x => x.name)
                    .OrderByDescending(x => x.Sum(b => b.product_uom_qty))
                    .Take(5)
                    .ToDictionary(g => g.Key, g => g.Sum(b => b.product_uom_qty));


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
        

        private void cmbUrtea_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrteaZnblbl.Text = cmbUrteaSalmentak.Text.ToString();
            SalmentakNumlbl.Text= "";
            using (var db = new PhoneTicContext())
            {
                int urtea = int.Parse(cmbUrteaSalmentak.Text.ToString());

                var resultadoSold = db.sale_order_line
                .Where(x => x.write_date.Year.Equals(urtea))
                .GroupBy(x => x.write_date.Year)
                .ToDictionary(g => g.Key, g => new { TotalSoldProducts = g.Sum(b => b.product_uom_qty) });

                SalmentakNumlbl.Text = resultadoSold[urtea].TotalSoldProducts.ToString() + " Produktu";

                var resultadoIrabaziak = db.sale_order_line
                .Where(x => x.write_date.Year.Equals(urtea))
                .GroupBy(x => x.write_date.Year)
                .ToDictionary(g => g.Key, g => new { TotalSoldProducts = g.Sum(b => b.price_total) });

                IrabaziakNumlbl.Text = resultadoIrabaziak[urtea].TotalSoldProducts.ToString() + "€";


                //////////////////////////////////////////////
                ///                                        //
                ///             GRAFICO DE BARRAS         //
                ///                                      //
                //////////////////////////////////////////

                var saleorder1 = db.sale_order_line

                .Include("res_partner")
                .Where(x => x.write_date.Year.Equals(urtea))
                .GroupBy(x => x.write_date.Month)
                .ToDictionary(g => g.Key, g => g.Sum(b => b.product_uom_qty));

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

                /////////////////////////////////////////////
                ///                                       //
                ///             GRAFICO CIRCULAR         //
                ///                                     //
                /////////////////////////////////////////


                var saleorder2 = db.sale_order_line
            .Include("res_partner")
            .Where(x => x.write_date.Year.Equals(urtea))
            .GroupBy(x => x.name)
            .Take(5)
            .ToDictionary(g => g.Key, g => g.Sum(b => b.product_uom_qty));


            if (saleorder2 != null)
            {
                if (saleorder2.Count > 0)
                {
                    var grafikoa = userControl1.Controls 
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

