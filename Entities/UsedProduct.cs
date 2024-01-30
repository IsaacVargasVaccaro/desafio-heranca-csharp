using System.Globalization;


namespace desafio_heranca_csharp.Entities
{
    public sealed class UsedProduct : Product
    {
        public DateTime Manufacture;

        public UsedProduct(string name, double price, DateTime manufacture) : base (name, price)
        {
            Manufacture = manufacture;            
        }

        public sealed override string priceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: " +  Manufacture.ToString("dd/MM/yyyy") + " )";
        }
    }
}