
namespace Harmony.Server;

public partial interface IRequestHost
{
	
	public Task<Protocol.Emote.V1.CreateEmotePackResponse> CreateEmotePack(Protocol.Emote.V1.CreateEmotePackRequest pm);
	
	public Task<Protocol.Emote.V1.GetEmotePacksResponse> GetEmotePacks(Protocol.Emote.V1.GetEmotePacksRequest pm);
	
	public Task<Protocol.Emote.V1.GetEmotePackEmotesResponse> GetEmotePackEmotes(Protocol.Emote.V1.GetEmotePackEmotesRequest pm);
	
	public Task<Protocol.Emote.V1.AddEmoteToPackResponse> AddEmoteToPack(Protocol.Emote.V1.AddEmoteToPackRequest pm);
	
	public Task<Protocol.Emote.V1.DeleteEmotePackResponse> DeleteEmotePack(Protocol.Emote.V1.DeleteEmotePackRequest pm);
	
	public Task<Protocol.Emote.V1.DeleteEmoteFromPackResponse> DeleteEmoteFromPack(Protocol.Emote.V1.DeleteEmoteFromPackRequest pm);
	
	public Task<Protocol.Emote.V1.DequipEmotePackResponse> DequipEmotePack(Protocol.Emote.V1.DequipEmotePackRequest pm);
	
	public Task<Protocol.Emote.V1.EquipEmotePackResponse> EquipEmotePack(Protocol.Emote.V1.EquipEmotePackRequest pm);
}

public partial interface IStreamHost
{
}
