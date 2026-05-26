using System.Reflection.Metadata;
using DataAccess.Entities;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace Business.Sessions;

public class SessionManager
{
    /// <summary>
    /// delete all student sessions
    /// </summary>
    /// <param name="_context"></param>
    /// <param name="studentId"></param>
    /// <returns>if there all student sessions where invalidated, or he has none, it returns true, otherwise flase</returns>
    public static async Task<bool> InvalidateAll(AppDbContext _context, int studentId)
    {
        var student = await _context.Students.FirstOrDefaultAsync(s => s.Id == studentId);
        if(student != null)
        {
            await _context.Sessions.Where(s => s.StudentId == studentId).ExecuteDeleteAsync();
            return true;
        }
        else return false;
    }
}