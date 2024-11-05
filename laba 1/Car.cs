using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double EngineSize { get; set; }
        public string BodyType { get; set; }
        public string FuelType { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public Car(string brand, string model, string color, double engineSize, string bodyType, string fuelType, int count, double price)
        {
            Brand = brand;
            Model = model;
            Color = color;
            EngineSize = engineSize;
            BodyType = bodyType;
            FuelType = fuelType;
            Count = count;
            Price = price;
        }


    }
}
