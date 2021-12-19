using Protocol = Harmony;

namespace Harmony.Server;

public partial interface IRequestHost
{

    public Task<Protocol.Auth.V1.FederateResponse> Federate(Protocol.Auth.V1.FederateRequest pm);

    public Task<Protocol.Auth.V1.LoginFederatedResponse> LoginFederated(Protocol.Auth.V1.LoginFederatedRequest pm);

    public Task<Protocol.Auth.V1.KeyResponse> Key(Protocol.Auth.V1.KeyRequest pm);

    public Task<Protocol.Auth.V1.BeginAuthResponse> BeginAuth(Protocol.Auth.V1.BeginAuthRequest pm);

    public Task<Protocol.Auth.V1.NextStepResponse> NextStep(Protocol.Auth.V1.NextStepRequest pm);

    public Task<Protocol.Auth.V1.StepBackResponse> StepBack(Protocol.Auth.V1.StepBackRequest pm);

    public Task<Protocol.Auth.V1.CheckLoggedInResponse> CheckLoggedIn(Protocol.Auth.V1.CheckLoggedInRequest pm);
}

public partial interface IStreamHost
{

    public void StreamSteps(Protocol.Auth.V1.StreamStepsRequest pm); // stream Protocol.Auth.V1.StreamStepsResponse
}
