
namespace Harmony.Server;

public partial interface IRequestHost
{
	
	public Task<Protocol.Bots.V1.MyBotsResponse> MyBots(Protocol.Bots.V1.MyBotsRequest pm);
	
	public Task<Protocol.Bots.V1.GetBotResponse> GetBot(Protocol.Bots.V1.GetBotRequest pm);
	
	public Task<Protocol.Bots.V1.CreateBotResponse> CreateBot(Protocol.Bots.V1.CreateBotRequest pm);
	
	public Task<Protocol.Bots.V1.EditBotResponse> EditBot(Protocol.Bots.V1.EditBotRequest pm);
	
	public Task<Protocol.Bots.V1.DeleteBotResponse> DeleteBot(Protocol.Bots.V1.DeleteBotRequest pm);
	
	public Task<Protocol.Bots.V1.PoliciesResponse> Policies(Protocol.Bots.V1.PoliciesRequest pm);
	
	public Task<Protocol.Bots.V1.AddBotResponse> AddBot(Protocol.Bots.V1.AddBotRequest pm);
}

public partial interface IStreamHost
{
}
