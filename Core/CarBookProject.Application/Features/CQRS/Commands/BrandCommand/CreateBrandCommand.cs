using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Commands.BrandCommand
{
    public class CreateBrandCommand
    {
        public string BrandName { get; set; }
    }
}
