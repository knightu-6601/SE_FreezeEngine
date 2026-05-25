using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;
public class AuditLog
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    /*we need something like
    [ForeignKey(DecisionId)] 
    but again, non of our business*/
    public int DecisionId {get; set;}
    public string? Details {get; set;}
    public DateTime Timestamp { get; set; }

    [ForeignKey("StudentId")]
    public Student Student { get; set; }
    
}