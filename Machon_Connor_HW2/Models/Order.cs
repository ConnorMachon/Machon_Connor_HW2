using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Machon_Connor_HW2.Models
{
    //define the types of customers
    public enum CustomerType {Walkup, Wholesale}

    public abstract class Order
    {
        //FIELDS
        const Decimal HARDBACK_PRICE = 19m;
        const Decimal PAPERBACK_PRICE = 7m;

        //PROPERTIES
        [Display(Name="Customer Type:")]
        public CustomerType CustomerType { get; set; }

        [Required]
        [Display(Name="Number of Hardbacks:")]
        [Range(0,1000000, ErrorMessage = "The Number of Harbacks must be a Positive Integer and less than 1000000")]
        public Int32 NumberOfHardbacks { get; set; }

        [Required]
        [Display(Name ="Number of Paperbacks:")]
        [Range(0, 1000000, ErrorMessage = "The Number of Paperbacks must be a Positive Integer and less than 1000000")]
        public Int32 NumberOfPaperbacks { get; set; }
        
        [Display(Name="Hardback Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal HardbackSubtotal { get; set; }

        [Display(Name ="Paperback Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal PaperbackSubtotal { get; set; }

        [Display(Name="Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Subtotal { get; set; }

        [Display(Name ="Total:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Total { get; set; }

        [Display(Name ="Total Items:")]
        public Int32 TotalItems { get; set; }

        //METHODS
        public void CalcSubtotals()
        {
            //calculate totalitems, hardbacksubtotal, paperbacksubtotal, and subtotal
            TotalItems = NumberOfHardbacks + NumberOfPaperbacks;
            HardbackSubtotal = NumberOfHardbacks * HARDBACK_PRICE;
            PaperbackSubtotal = NumberOfPaperbacks * PAPERBACK_PRICE;
            Subtotal = HardbackSubtotal + PaperbackSubtotal;
        }
    }
}
