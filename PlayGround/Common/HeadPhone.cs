using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class HeadPhone
    {
        public HeadPhone()
        {
            SellingPrice = 1000;
            Color = "Blue";
            FormFactor = "HeadPhone";
            Brand = "JBL";
        }

        public decimal SellingPrice { get; set; }
        public string Color { get; set; }
        public string FormFactor { get; set; }
        public string Brand { get; set; }

        private int _volumeLevel;

        private int VolumeLevel
        {
            get
            {
                return _volumeLevel;
            }
            set
            {
                if (value <= 100)
                    _volumeLevel = value;
            }
        }

        public void IncreseVolume()
        {
            Console.WriteLine($"Volumne Level Increased to {++VolumeLevel}");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine($"Volumne Level Decrease to {--VolumeLevel}");
        }

        public void ConnectToBlueTooth()
        {
            Console.WriteLine("Connected To Blouetooth");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Brand : {Brand}");
            Console.WriteLine($"FormFactor : {FormFactor}");
            Console.WriteLine($"Color : {Color}");
            Console.WriteLine($"SellingPrice : {SellingPrice}");
        }
    }
}
