using Xunit;
using DataAccess.Context;
using DataAccess.Entities;
using Business.Sessions;

using Microsoft.EntityFrameworkCore;


public class SessionManagerTests : IClassFixture<TestFixture>
{
    private readonly AppDbContext _context;

    public SessionManagerTests(TestFixture fixture)
    {
        _context = fixture.Context;
    }

    [Fact]
    public async Task InvalidateAll_ShouldRemoveAllSessions_ForStudent()
    {
        // Arrange
        var student = await _context.Students.FirstOrDefaultAsync();
        Assert.NotNull(student);

        // Act
        var result = await SessionManager.InvalidateAll(_context, student.Id);

        // Assert
        Assert.True(result);

        var sessions = await _context.Sessions
            .Where(s => s.StudentId == student.Id)
            .ToListAsync();

        Assert.Empty(sessions);
    }

    [Fact]
    public async Task InvalidateAll_ShouldReturnTrue_WhenNoSessionsExist()
    {
        // Arrange
        var student = await _context.Students.FirstOrDefaultAsync();
        Assert.NotNull(student);

        await SessionManager.InvalidateAll(_context, student.Id);

        // Act
        var result = await SessionManager.InvalidateAll(_context, student.Id);

        // Assert
        Assert.True(result);

        var sessions = await _context.Sessions
            .Where(s => s.StudentId == student.Id)
            .ToListAsync();

        Assert.Empty(sessions);
    }
}