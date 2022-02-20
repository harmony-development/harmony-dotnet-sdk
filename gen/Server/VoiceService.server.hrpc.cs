
namespace Harmony.Server;

public partial interface IRequestHost
{
}

public partial interface IStreamHost
{
	
	public void StreamMessage(Protocol.Voice.V1.StreamMessageRequest pm); // stream Protocol.Voice.V1.StreamMessageResponse
}
