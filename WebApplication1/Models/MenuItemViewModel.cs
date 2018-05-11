using System.Collections.Generic;
namespace ASPNetexercises.Models
{
    public class MenuItemViewModel
    {
        public string CategoryName { get; set; }
        public IEnumerable<MenuItem> MenuItems { get; set; }
    }
}