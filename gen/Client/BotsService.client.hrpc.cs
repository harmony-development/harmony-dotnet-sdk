using System.Text.RegularExpressions;
using Hrpc;

namespace Harmony.Client;

public class BotsServiceClient
{
	public readonly Dictionary<string, string> DefaultRequestHeaders = new();
	private string _host { get; init; }
	private string _wsHost => new Regex("http").Replace(_host, "ws", 1);
	public readonly HttpClient _client = new();
	
	public BotsServiceClient(string host)
	{
		_host = host;
	}
	// unary MyBots
	public async Task<Protocol.Bots.V1.MyBotsResponse> MyBots(Protocol.Bots.V1.MyBotsRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Bots.V1.MyBotsRequest, Protocol.Bots.V1.MyBotsResponse>(_host + "/protocol.bots.v1.BotsService/MyBots", pm);
	
	// unary GetBot
	public async Task<Protocol.Bots.V1.GetBotResponse> GetBot(Protocol.Bots.V1.GetBotRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Bots.V1.GetBotRequest, Protocol.Bots.V1.GetBotResponse>(_host + "/protocol.bots.v1.BotsService/GetBot", pm);
	
	// unary CreateBot
	public async Task<Protocol.Bots.V1.CreateBotResponse> CreateBot(Protocol.Bots.V1.CreateBotRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Bots.V1.CreateBotRequest, Protocol.Bots.V1.CreateBotResponse>(_host + "/protocol.bots.v1.BotsService/CreateBot", pm);
	
	// unary EditBot
	public async Task<Protocol.Bots.V1.EditBotResponse> EditBot(Protocol.Bots.V1.EditBotRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Bots.V1.EditBotRequest, Protocol.Bots.V1.EditBotResponse>(_host + "/protocol.bots.v1.BotsService/EditBot", pm);
	
	// unary DeleteBot
	public async Task<Protocol.Bots.V1.DeleteBotResponse> DeleteBot(Protocol.Bots.V1.DeleteBotRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Bots.V1.DeleteBotRequest, Protocol.Bots.V1.DeleteBotResponse>(_host + "/protocol.bots.v1.BotsService/DeleteBot", pm);
	
	// unary Policies
	public async Task<Protocol.Bots.V1.PoliciesResponse> Policies(Protocol.Bots.V1.PoliciesRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Bots.V1.PoliciesRequest, Protocol.Bots.V1.PoliciesResponse>(_host + "/protocol.bots.v1.BotsService/Policies", pm);
	
	// unary AddBot
	public async Task<Protocol.Bots.V1.AddBotResponse> AddBot(Protocol.Bots.V1.AddBotRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Bots.V1.AddBotRequest, Protocol.Bots.V1.AddBotResponse>(_host + "/protocol.bots.v1.BotsService/AddBot", pm);
	
}
