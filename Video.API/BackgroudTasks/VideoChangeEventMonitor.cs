using Video.API.EventBus;

namespace Video.API.BackgroudTasks
{
    public class VideoChangeEventMonitor : BackgroundService
    {
        private readonly IEventBus _eventBus;

        public VideoChangeEventMonitor(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _eventBus.Subscribe<BaseVideoEvent, VideoEventHandler>();
            return Task.CompletedTask;
        }
    }
}
