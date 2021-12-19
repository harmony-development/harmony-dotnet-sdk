using System.Text.RegularExpressions;
using Hrpc;
using Protocol = Harmony;

namespace Harmony.Client;

public class AuthServiceClient
{
    public readonly Dictionary<string, string> DefaultRequestHeaders = new();
    private string _host { get; init; }
    private string _wsHost => new Regex("http").Replace(_host, "ws", 1);
    public readonly HttpClient _client = new();

    public AuthServiceClient(string host)
    {
        _host = host;
    }
    // unary Federate
    public async Task<Protocol.Auth.V1.FederateResponse> Federate(Protocol.Auth.V1.FederateRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Auth.V1.FederateRequest, Protocol.Auth.V1.FederateResponse>(_host + "/protocol.auth.v1.AuthService/Federate", pm);

    // unary LoginFederated
    public async Task<Protocol.Auth.V1.LoginFederatedResponse> LoginFederated(Protocol.Auth.V1.LoginFederatedRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Auth.V1.LoginFederatedRequest, Protocol.Auth.V1.LoginFederatedResponse>(_host + "/protocol.auth.v1.AuthService/LoginFederated", pm);

    // unary Key
    public async Task<Protocol.Auth.V1.KeyResponse> Key(Protocol.Auth.V1.KeyRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Auth.V1.KeyRequest, Protocol.Auth.V1.KeyResponse>(_host + "/protocol.auth.v1.AuthService/Key", pm);

    // unary BeginAuth
    public async Task<Protocol.Auth.V1.BeginAuthResponse> BeginAuth(Protocol.Auth.V1.BeginAuthRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Auth.V1.BeginAuthRequest, Protocol.Auth.V1.BeginAuthResponse>(_host + "/protocol.auth.v1.AuthService/BeginAuth", pm);

    // unary NextStep
    public async Task<Protocol.Auth.V1.NextStepResponse> NextStep(Protocol.Auth.V1.NextStepRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Auth.V1.NextStepRequest, Protocol.Auth.V1.NextStepResponse>(_host + "/protocol.auth.v1.AuthService/NextStep", pm);

    // unary StepBack
    public async Task<Protocol.Auth.V1.StepBackResponse> StepBack(Protocol.Auth.V1.StepBackRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Auth.V1.StepBackRequest, Protocol.Auth.V1.StepBackResponse>(_host + "/protocol.auth.v1.AuthService/StepBack", pm);

    // stream StreamSteps
    public async Task<StreamClient<Protocol.Auth.V1.StreamStepsResponse>> StreamSteps(Protocol.Auth.V1.StreamStepsRequest pm)
    {
        var stream = new StreamClient<Protocol.Auth.V1.StreamStepsResponse>(DefaultRequestHeaders);
        await stream.Connect(_wsHost + "/protocol.auth.v1.AuthService/StreamSteps", pm);
        return stream;
    }

    // unary CheckLoggedIn
    public async Task<Protocol.Auth.V1.CheckLoggedInResponse> CheckLoggedIn(Protocol.Auth.V1.CheckLoggedInRequest pm)
        => await _client.HrpcUnaryAsync<Protocol.Auth.V1.CheckLoggedInRequest, Protocol.Auth.V1.CheckLoggedInResponse>(_host + "/protocol.auth.v1.AuthService/CheckLoggedIn", pm);

}
