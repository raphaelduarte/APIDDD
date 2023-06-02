using APIDDD.Infrastructure.CrossCutting.IoC;
using APIDDD.Infrastructure.Data;
using Autofac;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SqlContext>
    (options => options.UseSqlServer("Data Source=DESKTOP-I4TK8NF\\SQLEXPRESS;Initial Catalog=TestDb;Integrated Security=True"));
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

void ConfigureContainer(ContainerBuilder builder)
{
    builder.RegisterModule(new ModuleIOC());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
