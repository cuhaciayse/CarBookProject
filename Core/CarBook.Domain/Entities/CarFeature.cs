using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Domain.Entities
{
    public class CarFeature
    {
        public int CarFeatureID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; } // bire bir ilişki
        public int FeatureID { get; set; }
        public Feature Feature { get; set; }
        public bool Available { get; set; } // bu özellik var mı yok mu
    }
}
