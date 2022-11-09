using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using Npgsql.TypeHandlers.NumericHandlers;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ErronkaForm.Models
{
    public partial class sale_order_line
    {
        [Key]
        public int id { get; set; }
        public int order_id { get; set; }

        public string name { get; set; }
        public int sequence { get; set; }

        public string invoice_status { get; set; }

        public int price_unit { get; set; }
        public int order_partner_id { get; set; }
        public double price_subtotal { get; set; }

        [ForeignKey("order_partner_id")]
        public virtual res_partner res_partner { get; set; }
        public int product_uom_qty { get; set; }
        
        public DateTime write_date { get; set; }

        public double price_total { get; set; }
        //public double price_tax { get; set; }
       
        //public DateTime create_date { get; set; }
        //public int price_reduce { get; set; }
        //public int price_reduce_taxinc { get; set; }
        //public int price_reduce_taxexcl { get; set; }
        //public int discount { get; set; }
        //public int product_id { get; set; }

        //public int product_uom { get; set; }
        //public string qty_delivered_method { get; set; }
        //public int qty_delivered { get; set; }
        //public int qty_delivered_manual { get; set; }
        //public int qty_to_invoice { get; set; }
        //public int qty_invoiced { get; set; }
        //public int untaxed_amount_invoiced { get; set; }
        //public int untaxed_amount_to_invoice { get; set; }
        //public int salesman_id { get; set; }
        //public int currency_id { get; set; }
        //public int company_id { get; set; }
        //public Boolean is_expense { get; set; }
        //public Boolean is_downpayment { get; set; }
        //public string state { get; set; }
        //public int customer_lead { get; set; }
        //public string display_type { get; set; }
        //public int product_packaging_id { get; set; }
        //public int product_packaging_qty { get; set; }
        //public int create_uid { get; set; }

        //public int write_uid { get; set; }

        //public int route_id { get; set; }
    }
}