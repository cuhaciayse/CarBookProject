using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Domain.Entities
{
    public class Car
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public Brand Brand { get; set; } // marka
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }  // vites türü
        public string Seat { get; set; }  // koltuk sayısı
        public string Luggage { get; set; } // bagaj
        public string Fuel { get; set; }  // yakıt türü
        public string BigImageUrl { get; set; }
        public List<CarDescription> CarDescriptions { get; set; }
        public List<CarFeature> CarFeatures { get; set; }
        public List<CarPricing> CarPricings { get; set; }
    }
}
