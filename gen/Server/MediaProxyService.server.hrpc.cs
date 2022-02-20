
namespace Harmony.Server;

public partial interface IRequestHost
{
	
	public Task<Protocol.Mediaproxy.V1.FetchLinkMetadataResponse> FetchLinkMetadata(Protocol.Mediaproxy.V1.FetchLinkMetadataRequest pm);
	
	public Task<Protocol.Mediaproxy.V1.InstantViewResponse> InstantView(Protocol.Mediaproxy.V1.InstantViewRequest pm);
	
	public Task<Protocol.Mediaproxy.V1.CanInstantViewResponse> CanInstantView(Protocol.Mediaproxy.V1.CanInstantViewRequest pm);
}

public partial interface IStreamHost
{
}
