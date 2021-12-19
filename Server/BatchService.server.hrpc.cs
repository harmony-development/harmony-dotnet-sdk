using Protocol = Harmony;

namespace Harmony.Server;

public partial interface IRequestHost
{

    public Task<Protocol.Batch.V1.BatchResponse> Batch(Protocol.Batch.V1.BatchRequest pm);

    public Task<Protocol.Batch.V1.BatchSameResponse> BatchSame(Protocol.Batch.V1.BatchSameRequest pm);
}

public partial interface IStreamHost
{
}
