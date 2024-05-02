using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Commands.CategoryCommand
{
    public class CreateCategoryCommand
    {
        public string Name { get; set; }
    }
}
