using DeviceObj;

namespace LaptopObj
{
    class Laptop : Device
    {
        public bool isRGBKeyboard;
        public Laptop() : base()
        {
            isRGBKeyboard = false;
        }

        public Laptop(string brand, string model, float screenSize, int charge, int price, int salePrice, int saled, bool isRGBKeyboard)
            : base(brand, model, screenSize, charge, price, salePrice, saled)
        {
            this.isRGBKeyboard = isRGBKeyboard;
        }

        public void DisplayLaptop()
        {
            DisplayAllInfo();
            Console.WriteLine($"Keyboard: {isRGBKeyboard}");
        }

    }
}