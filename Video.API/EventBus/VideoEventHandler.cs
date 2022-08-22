using Video.API.EventBus.Events;
using Video.Domain.Model;

namespace Video.API.EventBus
{
    public class VideoEventHandler : IVideoEventHandler<BaseVideoEvent>
    {
        private IVideoRepository _videoRepository;

        public VideoEventHandler(IVideoRepository videoRepository)
        {

        }

        public async Task Handle(BaseVideoEvent @event)
        {
            if(@event is VideoAddedEvent)
            {
                var videoMetadata = new VideoMetadata();
                videoMetadata.Id = @event.Id;
                videoMetadata.Url = @event.Url;
                var theme = new Theme();
                theme.Id = @event.ThemeId;
                videoMetadata.Theme = theme;
                await _videoRepository.AddAsync(videoMetadata);
            }
            else if (@event is VideoUpdatedEvent)
            {
                // similar logic for VideoUpdatedEvent, VideoDeleteEvent.
            }
            else
            {
                await Task.CompletedTask;
            }
        }
    }
}
