using BlacklistedMobiles.API.Data;
using BlacklistedMobiles.API.Mappings;
using BlacklistedMobiles.API.Repositories;
using BlacklistedMobiles.API.Repositories.Adapters;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped<ITrademarkRepository, SqliteTrademarkRepository>();
builder.Services.AddScoped<IProvinceRepository, SqliteProvinceRepository>();
builder.Services.AddScoped<IMunicipalityRepository, SqliteMunicipalityRepository>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();