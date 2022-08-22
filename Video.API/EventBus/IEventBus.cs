namespace Video.API.EventBus;

public interface IEventBus
{
    void Publish(BaseVideoEvent @event);

    void Subscribe<T, TH>()
        where T : BaseVideoEvent
        where TH : IVideoEventHandler<T>;
}
