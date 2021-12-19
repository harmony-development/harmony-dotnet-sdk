using System.Text.RegularExpressions;
using Hrpc;
using Protocol = Harmony;

namespace Harmony.Client;

public class BatchServiceClient
{
    public readonly Dictionary<string, string> DefaultRequestHeaders = new();
    private string _host { get; init; }
    private string _wsHost => new Regex("http").Replace(_host, "ws", 1);
    public readonly HttpClient _client = new();

    public BatchServiceClient(string host)
    {
        _host = host;
    }
    // unary Batch
    public async Task<Protocol.Batch.V1.BatchResponse> Batch(Protocol.Batch.V1.BatchRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Batch.V1.BatchRequest, Protocol.Batch.V1.BatchResponse>(_host + "/protocol.batch.v1.BatchService/Batch", pm);

    // unary BatchSame
    public async Task<Protocol.Batch.V1.BatchSameResponse> BatchSame(Protocol.Batch.V1.BatchSameRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Batch.V1.BatchSameRequest, Protocol.Batch.V1.BatchSameResponse>(_host + "/protocol.batch.v1.BatchService/BatchSame", pm);

}
