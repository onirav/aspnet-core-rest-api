namespace Starter.Core.Entities;

public class Task
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Status { get; set; } = "Pending";
    public DateTime DueDate { get; set; }
    public int ProjectId { get; set; }
    public Project Project { get; set; } = null!;
}
