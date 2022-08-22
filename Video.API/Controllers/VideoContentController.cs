using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Video.API.Authorization;
using Video.Domain.Model;

namespace Video.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VideoContentController : ControllerBase
    {
        private readonly ILogger<VideoContentController> _logger;
        private readonly IVideoRepository _videoRepository;

        public VideoContentController(ILogger<VideoContentController> logger, IVideoRepository videoRepository)
        {
            _logger = logger;
            _videoRepository = videoRepository;
        }

        [Route("Id/{videoId:int}")]
        [HttpGet]
        [WhitelistHostFilter]
        public async Task<HttpResponseMessage> GetVideoByIdAsync(int videoId)
        {
            try
            {
                var video = await _videoRepository.FindByIdAsync(videoId);
                var originalUrl =video.Url = "https://www.bing.com"; 
                HttpClient httpClient = new HttpClient();
                var reponse = await httpClient.GetAsync(originalUrl);
                return reponse;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
        }
    }
}