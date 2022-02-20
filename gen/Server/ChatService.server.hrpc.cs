
namespace Harmony.Server;

public partial interface IRequestHost
{
	
	public Task<Protocol.Chat.V1.CreateGuildResponse> CreateGuild(Protocol.Chat.V1.CreateGuildRequest pm);
	
	public Task<Protocol.Chat.V1.CreateRoomResponse> CreateRoom(Protocol.Chat.V1.CreateRoomRequest pm);
	
	public Task<Protocol.Chat.V1.CreateDirectMessageResponse> CreateDirectMessage(Protocol.Chat.V1.CreateDirectMessageRequest pm);
	
	public Task<Protocol.Chat.V1.UpgradeRoomToGuildResponse> UpgradeRoomToGuild(Protocol.Chat.V1.UpgradeRoomToGuildRequest pm);
	
	public Task<Protocol.Chat.V1.CreateInviteResponse> CreateInvite(Protocol.Chat.V1.CreateInviteRequest pm);
	
	public Task<Protocol.Chat.V1.CreateChannelResponse> CreateChannel(Protocol.Chat.V1.CreateChannelRequest pm);
	
	public Task<Protocol.Chat.V1.GetGuildListResponse> GetGuildList(Protocol.Chat.V1.GetGuildListRequest pm);
	
	public Task<Protocol.Chat.V1.InviteUserToGuildResponse> InviteUserToGuild(Protocol.Chat.V1.InviteUserToGuildRequest pm);
	
	public Task<Protocol.Chat.V1.GetPendingInvitesResponse> GetPendingInvites(Protocol.Chat.V1.GetPendingInvitesRequest pm);
	
	public Task<Protocol.Chat.V1.RejectPendingInviteResponse> RejectPendingInvite(Protocol.Chat.V1.RejectPendingInviteRequest pm);
	
	public Task<Protocol.Chat.V1.IgnorePendingInviteResponse> IgnorePendingInvite(Protocol.Chat.V1.IgnorePendingInviteRequest pm);
	
	public Task<Protocol.Chat.V1.GetGuildResponse> GetGuild(Protocol.Chat.V1.GetGuildRequest pm);
	
	public Task<Protocol.Chat.V1.GetGuildInvitesResponse> GetGuildInvites(Protocol.Chat.V1.GetGuildInvitesRequest pm);
	
	public Task<Protocol.Chat.V1.GetGuildMembersResponse> GetGuildMembers(Protocol.Chat.V1.GetGuildMembersRequest pm);
	
	public Task<Protocol.Chat.V1.GetGuildChannelsResponse> GetGuildChannels(Protocol.Chat.V1.GetGuildChannelsRequest pm);
	
	public Task<Protocol.Chat.V1.GetChannelMessagesResponse> GetChannelMessages(Protocol.Chat.V1.GetChannelMessagesRequest pm);
	
	public Task<Protocol.Chat.V1.GetMessageResponse> GetMessage(Protocol.Chat.V1.GetMessageRequest pm);
	
	public Task<Protocol.Chat.V1.UpdateGuildInformationResponse> UpdateGuildInformation(Protocol.Chat.V1.UpdateGuildInformationRequest pm);
	
	public Task<Protocol.Chat.V1.UpdateChannelInformationResponse> UpdateChannelInformation(Protocol.Chat.V1.UpdateChannelInformationRequest pm);
	
	public Task<Protocol.Chat.V1.UpdateChannelOrderResponse> UpdateChannelOrder(Protocol.Chat.V1.UpdateChannelOrderRequest pm);
	
	public Task<Protocol.Chat.V1.UpdateAllChannelOrderResponse> UpdateAllChannelOrder(Protocol.Chat.V1.UpdateAllChannelOrderRequest pm);
	
	public Task<Protocol.Chat.V1.UpdateMessageTextResponse> UpdateMessageText(Protocol.Chat.V1.UpdateMessageTextRequest pm);
	
	public Task<Protocol.Chat.V1.DeleteGuildResponse> DeleteGuild(Protocol.Chat.V1.DeleteGuildRequest pm);
	
	public Task<Protocol.Chat.V1.DeleteInviteResponse> DeleteInvite(Protocol.Chat.V1.DeleteInviteRequest pm);
	
	public Task<Protocol.Chat.V1.DeleteChannelResponse> DeleteChannel(Protocol.Chat.V1.DeleteChannelRequest pm);
	
	public Task<Protocol.Chat.V1.DeleteMessageResponse> DeleteMessage(Protocol.Chat.V1.DeleteMessageRequest pm);
	
	public Task<Protocol.Chat.V1.JoinGuildResponse> JoinGuild(Protocol.Chat.V1.JoinGuildRequest pm);
	
	public Task<Protocol.Chat.V1.LeaveGuildResponse> LeaveGuild(Protocol.Chat.V1.LeaveGuildRequest pm);
	
	public Task<Protocol.Chat.V1.TriggerActionResponse> TriggerAction(Protocol.Chat.V1.TriggerActionRequest pm);
	
	public Task<Protocol.Chat.V1.SendMessageResponse> SendMessage(Protocol.Chat.V1.SendMessageRequest pm);
	
	public Task<Protocol.Chat.V1.HasPermissionResponse> HasPermission(Protocol.Chat.V1.HasPermissionRequest pm);
	
	public Task<Protocol.Chat.V1.SetPermissionsResponse> SetPermissions(Protocol.Chat.V1.SetPermissionsRequest pm);
	
	public Task<Protocol.Chat.V1.GetPermissionsResponse> GetPermissions(Protocol.Chat.V1.GetPermissionsRequest pm);
	
	public Task<Protocol.Chat.V1.MoveRoleResponse> MoveRole(Protocol.Chat.V1.MoveRoleRequest pm);
	
	public Task<Protocol.Chat.V1.GetGuildRolesResponse> GetGuildRoles(Protocol.Chat.V1.GetGuildRolesRequest pm);
	
	public Task<Protocol.Chat.V1.AddGuildRoleResponse> AddGuildRole(Protocol.Chat.V1.AddGuildRoleRequest pm);
	
	public Task<Protocol.Chat.V1.ModifyGuildRoleResponse> ModifyGuildRole(Protocol.Chat.V1.ModifyGuildRoleRequest pm);
	
	public Task<Protocol.Chat.V1.DeleteGuildRoleResponse> DeleteGuildRole(Protocol.Chat.V1.DeleteGuildRoleRequest pm);
	
	public Task<Protocol.Chat.V1.ManageUserRolesResponse> ManageUserRoles(Protocol.Chat.V1.ManageUserRolesRequest pm);
	
	public Task<Protocol.Chat.V1.GetUserRolesResponse> GetUserRoles(Protocol.Chat.V1.GetUserRolesRequest pm);
	
	public Task<Protocol.Chat.V1.TypingResponse> Typing(Protocol.Chat.V1.TypingRequest pm);
	
	public Task<Protocol.Chat.V1.PreviewGuildResponse> PreviewGuild(Protocol.Chat.V1.PreviewGuildRequest pm);
	
	public Task<Protocol.Chat.V1.GetBannedUsersResponse> GetBannedUsers(Protocol.Chat.V1.GetBannedUsersRequest pm);
	
	public Task<Protocol.Chat.V1.BanUserResponse> BanUser(Protocol.Chat.V1.BanUserRequest pm);
	
	public Task<Protocol.Chat.V1.KickUserResponse> KickUser(Protocol.Chat.V1.KickUserRequest pm);
	
	public Task<Protocol.Chat.V1.UnbanUserResponse> UnbanUser(Protocol.Chat.V1.UnbanUserRequest pm);
	
	public Task<Protocol.Chat.V1.GetPinnedMessagesResponse> GetPinnedMessages(Protocol.Chat.V1.GetPinnedMessagesRequest pm);
	
	public Task<Protocol.Chat.V1.PinMessageResponse> PinMessage(Protocol.Chat.V1.PinMessageRequest pm);
	
	public Task<Protocol.Chat.V1.UnpinMessageResponse> UnpinMessage(Protocol.Chat.V1.UnpinMessageRequest pm);
	
	public Task<Protocol.Chat.V1.AddReactionResponse> AddReaction(Protocol.Chat.V1.AddReactionRequest pm);
	
	public Task<Protocol.Chat.V1.RemoveReactionResponse> RemoveReaction(Protocol.Chat.V1.RemoveReactionRequest pm);
	
	public Task<Protocol.Chat.V1.GrantOwnershipResponse> GrantOwnership(Protocol.Chat.V1.GrantOwnershipRequest pm);
	
	public Task<Protocol.Chat.V1.GiveUpOwnershipResponse> GiveUpOwnership(Protocol.Chat.V1.GiveUpOwnershipRequest pm);
}

public partial interface IStreamHost
{
	
	public void StreamEvents(Protocol.Chat.V1.StreamEventsRequest pm); // stream Protocol.Chat.V1.StreamEventsResponse
}
