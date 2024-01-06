using IntegraBasil.Application.Integration.Interfaces;
using IntegraBasil.Application.Integration.Rest;
using IntegraBasil.Application.Integration.Services;
using IntegraBasil.Application.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddScoped<IAddressIntegrationService, AddressIntegrationService>();
builder.Services.AddScoped<IBankIntegrationService, BankIntegrationService>();

builder.Services.AddScoped<IBrasilApiIntegration, BrasilApiIntegrationRest>();

builder.Services.AddAutoMapper(typeof(AddressMapping));
builder.Services.AddAutoMapper(typeof(BankMapping));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapControllers();
}

app.Run();

