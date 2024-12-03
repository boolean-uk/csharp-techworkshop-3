# C# Tech Workshop 3

Today we are going about a few design patterns. 

### Links
* [c# Design Paterns](https://www.dofactory.com/net/design-patterns)


The above you can go though on your own pace and take not as these are guidelines. 
The merely assist you in the right direction and the approach and be taken for any given language IF it allows it.

NB!!! **Take the singleton approach**

## Exercise
Creating an api instance with a service layer where we are going to inject our in-memory storage

## Steps
Follow the steps if you want to create your own project.
Use an existing solution for this
Create a new project
```bash
dotnet new webapi -n InMemoryEFCoreProject
```

Add the following packages to the project
```bash
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Microsoft.EntityFrameworkCore.Design
```

Copy over the the following files.
* `Controller.ProductController.cs`
* `Data.ApplicationDbContext.cs`
* `Controller.Product.cs`

Ensure that the `Program.cs` file has the following
```csharp
using Microsoft.EntityFrameworkCore;
using InMemoryEFCoreProject.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
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
```