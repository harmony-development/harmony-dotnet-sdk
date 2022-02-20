
namespace Harmony.Server;

public partial interface IRequestHost
{
	
	public Task<Protocol.Profile.V1.GetProfileResponse> GetProfile(Protocol.Profile.V1.GetProfileRequest pm);
	
	public Task<Protocol.Profile.V1.UpdateProfileResponse> UpdateProfile(Protocol.Profile.V1.UpdateProfileRequest pm);
	
	public Task<Protocol.Profile.V1.GetAppDataResponse> GetAppData(Protocol.Profile.V1.GetAppDataRequest pm);
	
	public Task<Protocol.Profile.V1.SetAppDataResponse> SetAppData(Protocol.Profile.V1.SetAppDataRequest pm);
}

public partial interface IStreamHost
{
}
