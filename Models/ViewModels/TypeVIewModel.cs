using System.Collections.Generic;
using bsis3a_webapp.Models;

namespace bsis3a_webapp.Models.ViewModels
{
    public class TypeViewModel
    {
        public Type Type{ get; set; }

        public IEnumerable<Item> Items { get; set; }
    }
}