namespace DataAccess.Entities;

public class Student
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Password {get; set;} // this should be hashed, but not our business
    public string? Email {get; set;}
    public bool Frozen {get; set;} = false;

    public List<Session> Sessions { get; set; } = new();
    public List<AuditLog> AuditLogs { get; set; } = new();
}