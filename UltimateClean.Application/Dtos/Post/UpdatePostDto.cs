namespace UltimateClean.Application.Contracts.Services;

public class UpdatePostDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int CategoryId { get; set; }
    public int UserId { get; set; }
}
