using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EtiquetaCsharp.Entities
{
    class ImportedProduct: Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customs)
            :base(name, price)
        {
            CustomsFee = customs;
        }

        public override string PriceTag()
        {
            return Name + " $ " + Price + " Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
