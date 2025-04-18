using Microsoft.AspNetCore.Mvc;
using UltimateClean.Application.Contracts.Persistence;

namespace UltimateClean.Api.Controllers
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
        public async Task<GetPostDto> Get(uint id)
        {
            return await _postService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task Create([FromBody] CreatePostDto postDto)
        {
            await _postService.CreateAsync(postDto);
        }

        [HttpDelete("{id}")]
        public async Task Delete(uint id)
        {
            await _postService.DeleteAsync(id);
        }
    }
}
