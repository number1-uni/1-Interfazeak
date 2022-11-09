using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErronkaForm.Models
{
    public partial class purchase_order_line
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int sequence { get; set; }
        public int product_qty { get; set; }
        public double product_uom_qty { get; set; }
        public int product_id { get; set; }
        public double price_unit { get; set; }
        public double price_subtotal { get; set; }
        public double price_total { get; set; }
        public string state { get; set; }
        public int partner_id { get; set; }

        [ForeignKey("partner_id")]

        public virtual res_partner res_partner { get; set; }
        public DateTime write_date { get; set; }

    }
}
