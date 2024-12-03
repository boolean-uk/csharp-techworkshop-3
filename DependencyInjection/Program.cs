// Setup DI Container (e.g., using Microsoft.Extensions.DependencyInjection)
using DependencyInjection;
using Microsoft.Extensions.DependencyInjection;


var serviceProvider = new ServiceCollection()
    .AddTransient<IUserRepository, UserRepository>()
    .AddTransient<UserService>()
    .BuildServiceProvider();

// Resolve UserService from DI Container
var userService = serviceProvider.GetRequiredService<UserService>();

// Use UserService
userService.RegisterUser("John Doe");

Console.WriteLine("This is done");