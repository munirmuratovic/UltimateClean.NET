using UltimateClean.Application.Dtos;
using UltimateClean.Domain.Entities;

namespace UltimateClean.Application.Mappings;

public static class PostMappingProfile
{
    public static GetPostDto ToGetPostDto(this Post post)
    {
        return new GetPostDto
        {
            Title = post.Title,
            Content = post.Content,
            CreatedAt = post.CreatedAt,
            UpdatedAt = post.UpdatedAt
        };
    }
}
