using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bsis3a_webapp.Models
{
    public class Instrument
    {
        public int Id { get; set; }
        
        public Item Item { get; set; }
        [RegularExpression("^*[1-9]*$", ErrorMessage = "Please select item.")]
        public int ItemId { get; set; }
        public Type Type { get; set; }
        [RegularExpression("^*[1-9]*$", ErrorMessage = "Please select type.")]
         public int TypeId { get; set; }
         [Required(ErrorMessage = "Provide selling price.")]
         public int Price { get; set; }
         public string ImagePath { get; set; }
    }
}