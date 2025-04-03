using UltimateClean.Application.Contracts.Persistence;
using UltimateClean.Application.Contracts.Services;
using UltimateClean.Application.Dtos;
using UltimateClean.Application.Mappings;

public class PostService : IPostService
{
    private readonly IPostRepository _postRepository;

    public PostService(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task<GetPostDto> GetByIdAsync(uint id)
    {
        var post = await _postRepository.GetByIdAsync(id);

        return post.ToGetPostDto();
    }
}