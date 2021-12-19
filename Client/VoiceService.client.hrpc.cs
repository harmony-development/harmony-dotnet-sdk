using System.Text.RegularExpressions;
using Hrpc;
using Protocol = Harmony;

namespace Harmony.Client;

public class VoiceServiceClient
{
    public readonly Dictionary<string, string> DefaultRequestHeaders = new();
    private string _host { get; init; }
    private string _wsHost => new Regex("http").Replace(_host, "ws", 1);
    public readonly HttpClient _client = new();

    public VoiceServiceClient(string host)
    {
        _host = host;
    }
    // stream StreamMessage
    public async Task<StreamClient<Protocol.Voice.V1.StreamMessageResponse>> StreamMessage(Protocol.Voice.V1.StreamMessageRequest pm)
    {
        var stream = new StreamClient<Protocol.Voice.V1.StreamMessageResponse>(DefaultRequestHeaders);
        await stream.Connect(_wsHost + "/protocol.voice.v1.VoiceService/StreamMessage", pm);
        return stream;
    }

}
