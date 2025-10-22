using HumanObj;
using DeviceObj;
using PhoneObj;
using LaptopObj;
using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_2();
        }

        public static void Task_1()
        {
            Human human_1 = new Human("Qaqas", "Qaqasov", "Male", "Azeri", 88);
            human_1.ShowBirthYear();
            human_1.GetFullName();
        }
        //list kecmemisik deye massiv yaratdim 
        public static void Task_2()
        {
            Phone[] phones = new Phone[3];
            phones[0] = new Phone("Samsung", "Galaxy S24", 6.8f, 95, 1200, 999, 5000, true);
            phones[1] = new Phone("Apple", "iPhone 15", 6.1f, 90, 1500, 1400, 8000, true);
            phones[2] = new Phone("Xiaomi", "Mi 13", 6.5f, 85, 800, 750, 6000, true);

            Laptop[] laptops = new Laptop[3];
            laptops[0] = new Laptop("Asus", "ROG Strix", 17.3f, 90, 1800, 1600, 5000, true);
            laptops[1] = new Laptop("HP", "Pavilion", 15.6f, 85, 1200, 1000, 4000, false);
            laptops[2] = new Laptop("Acer", "Predator", 16.0f, 80, 1500, 1300, 3500, true);


            Console.WriteLine("=== Phones sorted by price ===");
            SortByPrice("phone", phones, laptops);

            Console.WriteLine("\n=== Laptops sorted by price ===");
            SortByPrice("laptop", phones, laptops);

            Console.WriteLine("\n=== Phones sorted by name ===");
            SortByName("phone", phones, laptops);

            Console.WriteLine("\n=== Laptops sorted by name ===");
            SortByName("laptop", phones, laptops);
        }

        //burda sort by prive di
        public static void SortByPrice(string type, Phone[] phones, Laptop[] laptops)
        {
            if (type == "phone")
            {
                for (int i = 0; i < phones.Length - 1; i++)
                {
                    for (int j = 0; j < phones.Length - i - 1; j++)
                    {
                        if (phones[j].Price > phones[j + 1].Price)
                        {
                            Phone temp = phones[j];
                            phones[j] = phones[j + 1];
                            phones[j + 1] = temp;
                        }
                    }
                }

                foreach (Phone p in phones)
                {
                    p.DisplayPhone();
                }
            }
            else if (type == "laptop")
            {
                for (int i = 0; i < laptops.Length - 1; i++)
                {
                    for (int j = 0; j < laptops.Length - i - 1; j++)
                    {
                        if (laptops[j].Price > laptops[j + 1].Price)
                        {
                            Laptop temp = laptops[j];
                            laptops[j] = laptops[j + 1];
                            laptops[j + 1] = temp;
                        }
                    }
                }

                foreach (Laptop l in laptops)
                {
                    l.DisplayLaptop();
                }
            }
            else
            {
                Console.WriteLine("Unknown type! Use 'phone' or 'laptop'.");
            }
        }

        //burda sort namedi
        public static void SortByName(string type, Phone[] phones, Laptop[] laptops)
        {
            if (type == "phone")
            {
                for (int i = 0; i < phones.Length - 1; i++)
                {
                    for (int j = 0; j < phones.Length - i - 1; j++)
                    {
                        if (string.Compare(phones[j].Brand, phones[j + 1].Brand, StringComparison.Ordinal) > 0)
                        {
                            Phone temp = phones[j];
                            phones[j] = phones[j + 1];
                            phones[j + 1] = temp;
                        }
                    }
                }

                foreach (Phone p in phones)
                {
                    p.DisplayPhone();
                }
            }
            else if (type == "laptop")
            {
                for (int i = 0; i < laptops.Length - 1; i++)
                {
                    for (int j = 0; j < laptops.Length - i - 1; j++)
                    {
                        if (string.Compare(laptops[j].Brand, laptops[j + 1].Brand, StringComparison.Ordinal) > 0)
                        {
                            Laptop temp = laptops[j];
                            laptops[j] = laptops[j + 1];
                            laptops[j + 1] = temp;
                        }
                    }
                }

                foreach (Laptop l in laptops)
                {
                    l.DisplayLaptop();
                }
            }
            else
            {
                Console.WriteLine("Unknown type! Use 'phone' or 'laptop'.");
            }
        }
    }
}
