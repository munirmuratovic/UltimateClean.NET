namespace UltimateClean.Application.Contracts.Services;

public class CreatePostDto
{
    public string Title { get; set; }
    public string Content { get; set; }
    public int CategoryId { get; set; }
    public int UserId { get; set; }
}