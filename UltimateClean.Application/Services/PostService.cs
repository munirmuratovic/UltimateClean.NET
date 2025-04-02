using UltimateClean.Application.Contracts.Persistence;
using UltimateClean.Application.Contracts.Services;
using UltimateClean.Application.Dtos;

public class PostService : IPostService
{
    private readonly IPostRepository _postRepository;

    public PostService(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task<PostDto> GetByIdAsync(uint id)
    {
        var post = await _postRepository.GetByIdAsync(id);

        var postDto = new PostDto
        {
            Title = post.Title,
            Content = post.Content,
            CreatedAt = post.CreatedAt,
            UpdatedAt = post.UpdatedAt
        };

        return postDto;
    }
}