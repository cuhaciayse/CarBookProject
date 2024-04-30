using CarBookProject.Application.Features.CQRS.Commands.AboutCommand;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle (UpdateAboutCommand command)
        {
            var values = await _repository.GetByIdAsync(command.AboutID);
            values.Description = command.Description;
            values.Title = command.Title;
            values.ImageUrl = command.ImageUrl;
            await _repository.UpdateAsync(values);

            //var about = new About
            //{
            //    AboutID = command.AboutID,
            //    Title = command.Title,
            //    ImageUrl = command.ImageUrl,
            //    Description = command.Description,
            //};
            //await _repository.UpdateAsync(about);
        }
    }
}
