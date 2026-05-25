using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;

public class Session
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public required string SessionKey { get; set; }
    public DateTime ExpiresAt { get; set; }
    [ForeignKey("StudentId")]
    public Student Student {get; set;}
}