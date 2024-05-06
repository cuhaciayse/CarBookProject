using CarBookProject.Application.Features.Mediator.Commands.TestimonialCommand;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;

        public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.TestimonialID);
            value.Comment = request.Comment;
            value.Title = request.Title;
            value.Name = request.Name;
            value.ImageUrl = request.ImageUrl;
            value.TestimonialID = request.TestimonialID;
            await _repository.UpdateAsync(value);
        }
    }
}
