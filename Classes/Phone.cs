using DeviceObj;

namespace PhoneObj
{
    public class Phone : Device
    {
        public bool IsSmart;
        public Phone() : base()
        {
            IsSmart = false;
        }

        public Phone(string brand, string model, float screenSize, int charge, int price, int salePrice, int saled, bool isSmart)
            : base(brand, model, screenSize, charge, price, salePrice, saled)
        {
            IsSmart = isSmart;
        }

        public void DisplayPhone()
        {
            DisplayAllInfo();
            Console.WriteLine($"Smartphone: {IsSmart}");
        }
    }
}
