using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

public class TestFixture : IAsyncLifetime
{
    public AppDbContext Context { get; private set; }

    public TestFixture()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseMySql("server=localhost;database=testdb;user=root;password=2564658",
             ServerVersion.AutoDetect("server=localhost;database=testdb;user=root;password=2564658"))
            .Options;

        Context = new AppDbContext(options);
    }

    public async Task InitializeAsync()
    {
        await Context.Database.EnsureDeletedAsync();
        await Context.Database.EnsureCreatedAsync();

        await TestSeeder.SeedAsync(Context);
    }

    public Task DisposeAsync()
    {
        Context.Dispose();
        return Task.CompletedTask;
    }
}