using System;
using System.Collections.Generic;
using bsis3a_webapp.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace bsis3a_webapp.Models.ViewModels
{
    public class InstrumentViewModel
    {
        public Instrument Instrument { get; set; }

        public IEnumerable<Item> Items { get; set; }
        public IEnumerable<Type> Types { get; set; }
        public IEnumerable<SelectListItem> selectListItem(IEnumerable<Item> Item)
        {
            List<SelectListItem> ItemList = new List<SelectListItem>();
            SelectListItem sli = new SelectListItem
            {
                Text = "Select Item",
                Value = "0"
            };
            ItemList.Add(sli);
            foreach(Item item in Items)
            {
                sli = new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                };
                ItemList.Add(sli);
            }
            return ItemList;
        }
        public IEnumerable<SelectListItem> selectListType(IEnumerable<Type> Type)
        {
            List<SelectListItem> TypeList = new List<SelectListItem>();
            SelectListItem sli = new SelectListItem
            {
                Text = "Select Item",
                Value = "0"
            };
            TypeList.Add(sli);
            foreach(Type type in Types)
            {
                sli = new SelectListItem
                {
                    Text = type.Name,
                    Value = type.Id.ToString()
                };
                TypeList.Add(sli);
            }
            return TypeList;
        }
    }
}