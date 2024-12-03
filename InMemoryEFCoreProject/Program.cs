using Microsoft.EntityFrameworkCore;
using InMemoryEFCoreProject.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// This add all the files inside the Controller folder to the services
builder.Services.AddControllers();

// Add the DbContext to the services
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("InMemoryDb"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();