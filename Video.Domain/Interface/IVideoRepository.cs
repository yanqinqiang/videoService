//This is just the RepositoryContracts or Interface defined at the Domain Layer

using Video.Domain.SeedWork;
using Video.Domain.Model;
using System.Linq.Expressions;

public interface IVideoRepository : IRepository<VideoMetadata>
{
    Task<VideoMetadata> AddAsync(VideoMetadata video);
    Task<VideoMetadata> UpdateAsync(VideoMetadata video);
    
    
    Task<VideoMetadata> FindByIdAsync(int id);
    Task<List<VideoMetadata>> FindVideosByThemesAsync(int themeId);
    IQueryable<VideoMetadata> FindAllMatchedVideo(Expression<Func<VideoMetadata, Boolean>> predicate);
}