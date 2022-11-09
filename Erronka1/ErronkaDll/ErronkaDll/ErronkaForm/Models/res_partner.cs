using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErronkaForm.Models
{
    public partial class res_partner
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }

        public List<sale_order_line> sale_order_line { get; set; }
        public List<purchase_order_line> purchase_order_line { get; set; }
    }
}
