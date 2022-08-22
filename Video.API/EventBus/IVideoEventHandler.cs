namespace Video.API.EventBus
{
    public interface IVideoEventHandler<in TEvent>
    where TEvent : BaseVideoEvent
    {
        Task Handle(BaseVideoEvent @event);
    }
}
