using Microsoft.Extensions.DependencyInjection;
using DataAccess.DependencyInjection;
using DataAccess.Context;

var services = new ServiceCollection();

// register DataAccess (THIS is your DI setup)
services.AddDataAccess("server=localhost;database=testdb;user=root;password=2564658");

var provider = services.BuildServiceProvider();

// test DbContext creation
using var scope = provider.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

Console.WriteLine(context.Database.CanConnect());