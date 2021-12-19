using Protocol = Harmony;

namespace Harmony.Server;

public partial interface IRequestHost
{

    public Task<Protocol.Sync.V1.PullResponse> Pull(Protocol.Sync.V1.PullRequest pm);

    public Task<Protocol.Sync.V1.PushResponse> Push(Protocol.Sync.V1.PushRequest pm);

    public Task<Protocol.Sync.V1.NotifyNewIdResponse> NotifyNewId(Protocol.Sync.V1.NotifyNewIdRequest pm);
}

public partial interface IStreamHost
{
}
