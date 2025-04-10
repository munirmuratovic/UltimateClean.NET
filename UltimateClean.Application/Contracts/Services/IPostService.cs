using UltimateClean.Application.Dtos;

namespace UltimateClean.Application.Contracts.Services;

public interface IPostService
{
    Task<GetPostDto> GetByIdAsync(uint id);
    Task CreateAsync(CreatePostDto postDto);
    Task UpdateAsync(UpdatePostDto postDto);
    Task DeleteAsync(uint id);
}
