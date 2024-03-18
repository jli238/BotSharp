namespace BotSharp.Abstraction.Messaging.Models.RichContent;

public class RichContent<T> where T : IRichMessage
{
    public Recipient Recipient { get; set; } = new Recipient();
    /// <summary>
    /// RESPONSE
    /// </summary>
    [JsonPropertyName("messaging_type")]
    public string MessagingType => "RESPONSE";
    public T Message { get; set; }

    /// <summary>
    /// If true, UI component will populate the replyMessage when sending back user message.
    /// </summary>
    [JsonPropertyName("fill_postback")]
    public bool FillPostback { get; set; }

    public RichContent()
    {
        
    }

    public RichContent(T message)
    {
        Message = message;
    }
}
