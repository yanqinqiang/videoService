using System.Linq.Expressions;
using Video.Domain.Model;

namespace Video.Infrastructure.Repositories;

public class VideoRepository
    : IVideoRepository
{
   
    public VideoRepository()
    {
       
    }

    public Task<VideoMetadata> AddAsync(VideoMetadata video)
    {
        // Logic here is not correct, just for demonstration. Data should be retrieved from database.
        return Task.FromResult(video);
    }

    public Task<VideoMetadata> FindByIdAsync(string id)
    {
        return Task.FromResult(new VideoMetadata());
    }

    public Task<VideoMetadata> UpdateAsync(VideoMetadata video)
    {
        return Task.FromResult(video);
    }

    IQueryable<VideoMetadata> IVideoRepository.FindAllMatchedVideo(Expression<Func<VideoMetadata, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    Task<VideoMetadata> IVideoRepository.FindByIdAsync(int id)
    {
        // here is a example for the returned metadata
       return Task.FromResult(new VideoMetadata() {Name = "Lego video 1", 
           Url= $"https://localhost:7270/api/v1/VideoContent/Id/{id}", 
           Description = "test"});
    }

    Task<List<VideoMetadata>> IVideoRepository.FindVideosByThemesAsync(int themeId)
    {
       return Task.FromResult(new List<VideoMetadata>() { new VideoMetadata() });
    }
}
