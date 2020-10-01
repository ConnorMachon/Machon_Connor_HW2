using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//we need this to validate data
using System.ComponentModel.DataAnnotations;

namespace Machon_Connor_HW2.Models
{
    public class WalkupOrder: Order
    {
        //FIELDS
        const Decimal SALES_TAX_RATE = 0.0875m;

        //PROPERTIES
        [Display(Name="Custome Name:")]
        public String CustomerName { get; set; }

        [Display(Name="Sales Tax")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal SalesTax { get; set; }


        //METHODS
        public void CalcTotals()
        {
            //Calling method from base class (order)
            base.CalcSubtotals();

            SalesTax = Subtotal * SALES_TAX_RATE;

            Total = Subtotal + SalesTax;
        }
    }
}
