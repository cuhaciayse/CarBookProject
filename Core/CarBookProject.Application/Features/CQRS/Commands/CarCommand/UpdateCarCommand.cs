using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Commands.CarCommand
{
    public class UpdateCarCommand
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }  // vites türü
        public byte Seat { get; set; }  // koltuk sayısı
        public byte Luggage { get; set; } // bagaj
        public string Fuel { get; set; }  // yakıt türü
        public string BigImageUrl { get; set; }
    }
}
