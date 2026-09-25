using Challenge5_PetAdoptionAPICThomason.Data;
using Challenge5_PetAdoptionAPICThomason.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//implement before the migration and database update commands
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

//responsible for connecting our interface/controller to our services
builder.Services.AddScoped<IPetService, PetService>(); 

builder.Services.AddScoped<IStaffServices, StaffServices>(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
