using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EtiquetaCsharp.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }
       public UsedProduct(String name, double price, DateTime manuDate)
            :base(name, price)
        {
            ManufactureDate = manuDate;
        }

        public override string PriceTag()
        {
            return Name + "(used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture)+" (Manufacture date: "+ManufactureDate.ToString("dd/MM/yyyy")+")";
        }
    }
}
