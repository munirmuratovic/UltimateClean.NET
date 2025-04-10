using UltimateClean.Application.Contracts.Persistence;
using UltimateClean.Application.Contracts.Services;
using UltimateClean.Application.Dtos;
using UltimateClean.Application.Mappings;

public class PostService : IPostService
{
    private readonly IUnitOfWork _unitOfWork;

    public PostService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<GetPostDto> GetByIdAsync(uint id)
    {
        var post = await _unitOfWork.PostRepository.GetByIdAsync(id);

        return post.ToGetPostDto();
    }

    public async Task CreateAsync(CreatePostDto postDto)
    {
        var newPost = postDto.ToPost();
        await _unitOfWork.PostRepository.AddAsync(newPost);
        await _unitOfWork.SaveChangesAsync();
    }

    public Task UpdateAsync(UpdatePostDto postDto)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(uint id)
    {
        await _unitOfWork.PostRepository.DeleteAsync(id);
    }
}