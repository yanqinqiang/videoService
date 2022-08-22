namespace Video.API.EventBus
{
    public class RabbitMqEventBus : IEventBus
    {
        public void Publish(BaseVideoEvent @event)
        {
            throw new NotImplementedException();
        }

        public void Subscribe<T, TH>()
            where T : BaseVideoEvent
            where TH : IVideoEventHandler<T>
        {
            // register event to trully event handler.
        }
    }
}
