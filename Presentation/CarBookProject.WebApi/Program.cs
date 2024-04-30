using CarBookProject.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBookProject.Application.Interfaces;
using CarBookProject.Persistence.Context;
using CarBookProject.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<CarBookContext>();
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));


builder.Services.AddScoped<GetAboutQueryHandler>(); 
builder.Services.AddScoped<GetAboutByIdQueryHandler>(); 
builder.Services.AddScoped<CreateAboutCommandHandler>(); 
builder.Services.AddScoped<UpdateAboutCommandHandler>(); 
builder.Services.AddScoped<RemoveAboutCommandHandler>(); 
 
builder.Services.AddControllers();

builder.Services.AddApplicationServices(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });

    app.UseHttpsRedirection();
};

app.UseAuthorization();

app.MapControllers();

app.Run();
