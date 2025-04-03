using System;

namespace UltimateClean.Application.Dtos;

public class GetPostDto
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
