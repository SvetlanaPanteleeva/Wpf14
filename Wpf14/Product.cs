using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf14
{
    public enum ProductCategorys
    {
        SportsEquipment,
        SportWearShoes 
    }
        public class Product
    {
        public string ProdName { get; set; }
        public decimal ProdPrise { get; set; }
        public string ProdImage { get; set; }
        public ProductCategorys ProductCategory { get; set; }
    }
}
