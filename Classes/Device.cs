using System;

namespace DeviceObj
{
    public class Device
    {
        public string Brand;
        public string Model;
        public float ScreenSize;
        public int Charge;
        public int Price;
        public int SalePrice;
        public int Saled;

        public Device()
        {
            Console.WriteLine("Device created with default constructor");
        }

        public Device(string brand) : this()
        {
            Brand = brand;
            Model = "Unknown";
            ScreenSize = 0;
            Charge = 0;
            Price = 0;
            SalePrice = 0;
            Saled = 0;
        }

        public Device(string brand, string model) : this(brand)
        {
            Model = model;
        }

        public Device(string brand, string model, float screenSize) : this(brand, model)
        {
            ScreenSize = screenSize;
        }

        public Device(string brand, string model, float screenSize, int charge) : this(brand, model, screenSize)
        {
            Charge = charge;
        }

        public Device(string brand, string model, float screenSize, int charge, int price) : this(brand, model, screenSize, charge)
        {
            Price = price;
        }

        public Device(string brand, string model, float screenSize, int charge, int price, int salePrice)
            : this(brand, model, screenSize, charge, price)
        {
            SalePrice = salePrice;
        }

        public Device(string brand, string model, float screenSize, int charge, int price, int salePrice, int saled)
            : this(brand, model, screenSize, charge, price, salePrice)
        {
            Saled = saled;
        }

        public void DisplayAllInfo()
        {
            Console.WriteLine("\n=== Device Info ===");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Screen Size: {ScreenSize}\"");
            Console.WriteLine($"Charge: {Charge}%");
            Console.WriteLine($"Price: {Price}$");
            Console.WriteLine($"Sale Price: {SalePrice}$");
            Console.WriteLine($"Units Sold: {Saled}");
            DisplayBatteryLevel();
            CalcProfit();
        }
        public void DisplayBatteryLevel()
        {
            Console.WriteLine($"Charge: {Charge}%");
        }
        public void CalcProfit()
        {
            int result = 0;
            result = SalePrice - Price;
            if (result > 0)
            {
                Console.WriteLine($"Our profit is : {result}");
            }
            else
            {
                Console.WriteLine($"Our loss is : {result}");
            }
        }
    }
}
