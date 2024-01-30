using System.Globalization;

namespace desafio_heranca_csharp.Entities
{
    public sealed class ImportedProduct : Product
    {
        public double CustomsFee;

        public ImportedProduct(string name, double price, double customsFee) : base ( name, price )
        {
            CustomsFee = customsFee;
        }

        public sealed override string priceTag()
        {
            return Name + " $ " + totalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")"  ;
        }

        public double totalPrice()
        {
            return Price + CustomsFee;
        }

    }
}