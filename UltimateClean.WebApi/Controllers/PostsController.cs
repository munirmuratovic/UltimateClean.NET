using Microsoft.AspNetCore.Mvc;
using UltimateClean.Application.Contracts.Persistence;

namespace UltimateClean.WebApi.Controllers
{
    using System.Threading.Tasks;
    using UltimateClean.Application.Contracts.Services;
    using UltimateClean.Application.Dtos;

    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly IUnitOfWork _unitOfWork;

        public PostsController(IPostService postService, IUnitOfWork unitOfWork)
        {
            _postService = postService;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]
        public async Task<PostDto> Get(uint id)
        {
            return await _postService.GetByIdAsync(id);
        }
    }
}
