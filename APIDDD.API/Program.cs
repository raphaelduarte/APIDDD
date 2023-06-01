using APIDDD.Infrastructure.CrossCutting.IoC;
using APIDDD.Infrastructure.Data;
using Autofac;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = Configuration["SqlConnection:SqlConnectionString"];
builder.Services.AddDbContext<SqlContext>(options => options.UseApplicationServiceProvider());
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
