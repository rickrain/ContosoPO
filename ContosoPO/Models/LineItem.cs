using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoPO.Models
{
    public class LineItem
    {
        public int LineItemID { get; set; }

        public int PurchaseOrderID { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        public int Quantity { get; set; }

        [Display(Name="Unit Price")]
        public double UnitPrice { get; set; }
    }
}