using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Video.Domain.Model;

namespace Video.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/v1/[controller]")]
    public class VideoMetadataController : ControllerBase
    {
        private readonly ILogger<VideoMetadataController> _logger;
        private readonly IVideoRepository _videoRepository;

        public VideoMetadataController(ILogger<VideoMetadataController> logger, IVideoRepository videoRepository)
        {
            _logger = logger;
            _videoRepository = videoRepository;
        }

        [Route("Id/{videoId:int}")]
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(typeof(VideoMetadata), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult> GetVideoMetadataByIdAsync(int videoId)
        {
            try
            {
                var video = await _videoRepository.FindByIdAsync(videoId);
                return Ok(video);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("themeId/{themeId:int}")]
        [HttpGet]
        [ProducesResponseType(typeof(VideoMetadata), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult> GetVideoMetadatasByThemeAsync(int themeId)
        {
            try
            {
                var videoList = await _videoRepository.FindVideosByThemesAsync(themeId);
                return Ok(videoList);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}