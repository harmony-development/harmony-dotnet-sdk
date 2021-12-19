using System.Text.RegularExpressions;
using Hrpc;
using Protocol = Harmony;

namespace Harmony.Client;

public class MediaProxyServiceClient
{
    public readonly Dictionary<string, string> DefaultRequestHeaders = new();
    private string _host { get; init; }
    private string _wsHost => new Regex("http").Replace(_host, "ws", 1);
    public readonly HttpClient _client = new();

    public MediaProxyServiceClient(string host)
    {
        _host = host;
    }
    // unary FetchLinkMetadata
    public async Task<Protocol.Mediaproxy.V1.FetchLinkMetadataResponse> FetchLinkMetadata(Protocol.Mediaproxy.V1.FetchLinkMetadataRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Mediaproxy.V1.FetchLinkMetadataRequest, Protocol.Mediaproxy.V1.FetchLinkMetadataResponse>(_host + "/protocol.mediaproxy.v1.MediaProxyService/FetchLinkMetadata", pm);

    // unary InstantView
    public async Task<Protocol.Mediaproxy.V1.InstantViewResponse> InstantView(Protocol.Mediaproxy.V1.InstantViewRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Mediaproxy.V1.InstantViewRequest, Protocol.Mediaproxy.V1.InstantViewResponse>(_host + "/protocol.mediaproxy.v1.MediaProxyService/InstantView", pm);

    // unary CanInstantView
    public async Task<Protocol.Mediaproxy.V1.CanInstantViewResponse> CanInstantView(Protocol.Mediaproxy.V1.CanInstantViewRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Mediaproxy.V1.CanInstantViewRequest, Protocol.Mediaproxy.V1.CanInstantViewResponse>(_host + "/protocol.mediaproxy.v1.MediaProxyService/CanInstantView", pm);

}
