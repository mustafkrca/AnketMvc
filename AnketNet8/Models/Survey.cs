using AnketNet8.Models;

public class Survey
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Gender { get; set; } // "Male", "Female", or "Other"
    public string City { get; set; }
    public ICollection<Question> Questions { get; set; } = new List<Question>();
    public int ParticipantCount { get; set; }
}
