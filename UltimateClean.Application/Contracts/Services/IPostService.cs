using UltimateClean.Application.Dtos;

namespace UltimateClean.Application.Contracts.Services;

public interface IPostService
{
    Task<PostDto> GetByIdAsync(uint id);
}
