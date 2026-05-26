using DataAccess.Context;
using DataAccess.Entities;


public static class TestSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.Students.Any()) return;

        var student = new Student
        {
            Name = "Test Student",
            Password = "123456789"
        };

        context.Students.Add(student);

        context.Sessions.Add(new Session
        {
            Student = student,
            SessionKey = "any kind of key in the world for testing"
        });

        await context.SaveChangesAsync();
    }
}