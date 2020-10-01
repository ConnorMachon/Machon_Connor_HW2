using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//we need this to validate data
using System.ComponentModel.DataAnnotations;

namespace Machon_Connor_HW2.Models
{
    public class WholesaleOrder: Order
    {
        //PROPERTIES
        [Required]
        [Display(Name ="Customer Code:")]
        [RegularExpression("^[a-zA-Z]{2,4}$", ErrorMessage ="The Customer Code May NOT contain Numbers or Special Characters, and MUST be 2, 3, or 4 characters")]
        public String CustomerCode { get; set; }
        
        [Required]
        [Display(Name="Delivery Fee:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Range(0,175, ErrorMessage ="The Delivery Fee must be between 0 & 175")]
        public Decimal DeliveryFee { get; set; }
        
        [Display(Name="Is This a Preferred Customer?:")]
        public Boolean PreferredCustomer { get; set; }

        //METHODS
        public void CalcTotals(Decimal decDeliveryFee)
        {
            //Call CalcSubtotals from base class (order)
            base.CalcSubtotals();
            
            //if statement to set delivery fee property
            if (PreferredCustomer == true)
            {
                DeliveryFee = 0;
            }
            else
            {
                DeliveryFee = decDeliveryFee;
            }

            //calculate total
            Total = Subtotal + DeliveryFee;
        }
    }
}
