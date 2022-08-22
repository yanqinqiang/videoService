using System.Text.Json.Serialization;
namespace Video.API.EventBus;

public record BaseVideoEvent
{        
    public BaseVideoEvent()
    {
        Id = -1;
        CreationDate = DateTime.UtcNow;
    }

    [JsonConstructor]
    public BaseVideoEvent(int id, string url, string desc, int themeId, DateTime createDate)
    {
        Id = id;
        Url = url;
        Desc = desc;
        ThemeId = themeId;
        CreationDate = createDate;
    }

    [JsonInclude]
    public int Id { get; private init; }

    [JsonInclude]
    public string Url { get; private init; }

    [JsonInclude]
    public string Desc { get; private init; }

    [JsonInclude]
    public int ThemeId { get; private init; }

    [JsonInclude]
    public DateTime CreationDate { get; private init; }
}
