using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AkijFoodProjectIntern.Models
{
    public class tblColdDrinks
    {
        [Key]
        public int intColdDrinksId { get; set; }
        [Required]
        [Display(Name = "Cold Drinks Name")]
        public string strColdDrinksName { get; set; }
        [Required]
        public int numQuantity { get; set; }
        [Required] public int numUnitPrice { get; set; }
    }
}
