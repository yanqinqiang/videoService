using Video.Domain.SeedWork;

namespace Video.Domain.Model
{
    public class VideoMetadata : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; } 
        public Theme Theme { get; set; }    // Suppose each video only belongs to one theme
    }
}
