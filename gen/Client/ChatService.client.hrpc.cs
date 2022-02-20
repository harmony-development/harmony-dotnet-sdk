using System.Text.RegularExpressions;
using Hrpc;

namespace Harmony.Client;

public class ChatServiceClient
{
	public readonly Dictionary<string, string> DefaultRequestHeaders = new();
	private string _host { get; init; }
	private string _wsHost => new Regex("http").Replace(_host, "ws", 1);
	public readonly HttpClient _client = new();
	
	public ChatServiceClient(string host)
	{
		_host = host;
	}
	// unary CreateGuild
	public async Task<Protocol.Chat.V1.CreateGuildResponse> CreateGuild(Protocol.Chat.V1.CreateGuildRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.CreateGuildRequest, Protocol.Chat.V1.CreateGuildResponse>(_host + "/protocol.chat.v1.ChatService/CreateGuild", pm);
	
	// unary CreateRoom
	public async Task<Protocol.Chat.V1.CreateRoomResponse> CreateRoom(Protocol.Chat.V1.CreateRoomRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.CreateRoomRequest, Protocol.Chat.V1.CreateRoomResponse>(_host + "/protocol.chat.v1.ChatService/CreateRoom", pm);
	
	// unary CreateDirectMessage
	public async Task<Protocol.Chat.V1.CreateDirectMessageResponse> CreateDirectMessage(Protocol.Chat.V1.CreateDirectMessageRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.CreateDirectMessageRequest, Protocol.Chat.V1.CreateDirectMessageResponse>(_host + "/protocol.chat.v1.ChatService/CreateDirectMessage", pm);
	
	// unary UpgradeRoomToGuild
	public async Task<Protocol.Chat.V1.UpgradeRoomToGuildResponse> UpgradeRoomToGuild(Protocol.Chat.V1.UpgradeRoomToGuildRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.UpgradeRoomToGuildRequest, Protocol.Chat.V1.UpgradeRoomToGuildResponse>(_host + "/protocol.chat.v1.ChatService/UpgradeRoomToGuild", pm);
	
	// unary CreateInvite
	public async Task<Protocol.Chat.V1.CreateInviteResponse> CreateInvite(Protocol.Chat.V1.CreateInviteRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.CreateInviteRequest, Protocol.Chat.V1.CreateInviteResponse>(_host + "/protocol.chat.v1.ChatService/CreateInvite", pm);
	
	// unary CreateChannel
	public async Task<Protocol.Chat.V1.CreateChannelResponse> CreateChannel(Protocol.Chat.V1.CreateChannelRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.CreateChannelRequest, Protocol.Chat.V1.CreateChannelResponse>(_host + "/protocol.chat.v1.ChatService/CreateChannel", pm);
	
	// unary GetGuildList
	public async Task<Protocol.Chat.V1.GetGuildListResponse> GetGuildList(Protocol.Chat.V1.GetGuildListRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GetGuildListRequest, Protocol.Chat.V1.GetGuildListResponse>(_host + "/protocol.chat.v1.ChatService/GetGuildList", pm);
	
	// unary InviteUserToGuild
	public async Task<Protocol.Chat.V1.InviteUserToGuildResponse> InviteUserToGuild(Protocol.Chat.V1.InviteUserToGuildRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.InviteUserToGuildRequest, Protocol.Chat.V1.InviteUserToGuildResponse>(_host + "/protocol.chat.v1.ChatService/InviteUserToGuild", pm);
	
	// unary GetPendingInvites
	public async Task<Protocol.Chat.V1.GetPendingInvitesResponse> GetPendingInvites(Protocol.Chat.V1.GetPendingInvitesRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GetPendingInvitesRequest, Protocol.Chat.V1.GetPendingInvitesResponse>(_host + "/protocol.chat.v1.ChatService/GetPendingInvites", pm);
	
	// unary RejectPendingInvite
	public async Task<Protocol.Chat.V1.RejectPendingInviteResponse> RejectPendingInvite(Protocol.Chat.V1.RejectPendingInviteRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.RejectPendingInviteRequest, Protocol.Chat.V1.RejectPendingInviteResponse>(_host + "/protocol.chat.v1.ChatService/RejectPendingInvite", pm);
	
	// unary IgnorePendingInvite
	public async Task<Protocol.Chat.V1.IgnorePendingInviteResponse> IgnorePendingInvite(Protocol.Chat.V1.IgnorePendingInviteRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.IgnorePendingInviteRequest, Protocol.Chat.V1.IgnorePendingInviteResponse>(_host + "/protocol.chat.v1.ChatService/IgnorePendingInvite", pm);
	
	// unary GetGuild
	public async Task<Protocol.Chat.V1.GetGuildResponse> GetGuild(Protocol.Chat.V1.GetGuildRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GetGuildRequest, Protocol.Chat.V1.GetGuildResponse>(_host + "/protocol.chat.v1.ChatService/GetGuild", pm);
	
	// unary GetGuildInvites
	public async Task<Protocol.Chat.V1.GetGuildInvitesResponse> GetGuildInvites(Protocol.Chat.V1.GetGuildInvitesRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GetGuildInvitesRequest, Protocol.Chat.V1.GetGuildInvitesResponse>(_host + "/protocol.chat.v1.ChatService/GetGuildInvites", pm);
	
	// unary GetGuildMembers
	public async Task<Protocol.Chat.V1.GetGuildMembersResponse> GetGuildMembers(Protocol.Chat.V1.GetGuildMembersRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GetGuildMembersRequest, Protocol.Chat.V1.GetGuildMembersResponse>(_host + "/protocol.chat.v1.ChatService/GetGuildMembers", pm);
	
	// unary GetGuildChannels
	public async Task<Protocol.Chat.V1.GetGuildChannelsResponse> GetGuildChannels(Protocol.Chat.V1.GetGuildChannelsRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GetGuildChannelsRequest, Protocol.Chat.V1.GetGuildChannelsResponse>(_host + "/protocol.chat.v1.ChatService/GetGuildChannels", pm);
	
	// unary GetChannelMessages
	public async Task<Protocol.Chat.V1.GetChannelMessagesResponse> GetChannelMessages(Protocol.Chat.V1.GetChannelMessagesRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GetChannelMessagesRequest, Protocol.Chat.V1.GetChannelMessagesResponse>(_host + "/protocol.chat.v1.ChatService/GetChannelMessages", pm);
	
	// unary GetMessage
	public async Task<Protocol.Chat.V1.GetMessageResponse> GetMessage(Protocol.Chat.V1.GetMessageRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GetMessageRequest, Protocol.Chat.V1.GetMessageResponse>(_host + "/protocol.chat.v1.ChatService/GetMessage", pm);
	
	// unary UpdateGuildInformation
	public async Task<Protocol.Chat.V1.UpdateGuildInformationResponse> UpdateGuildInformation(Protocol.Chat.V1.UpdateGuildInformationRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.UpdateGuildInformationRequest, Protocol.Chat.V1.UpdateGuildInformationResponse>(_host + "/protocol.chat.v1.ChatService/UpdateGuildInformation", pm);
	
	// unary UpdateChannelInformation
	public async Task<Protocol.Chat.V1.UpdateChannelInformationResponse> UpdateChannelInformation(Protocol.Chat.V1.UpdateChannelInformationRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.UpdateChannelInformationRequest, Protocol.Chat.V1.UpdateChannelInformationResponse>(_host + "/protocol.chat.v1.ChatService/UpdateChannelInformation", pm);
	
	// unary UpdateChannelOrder
	public async Task<Protocol.Chat.V1.UpdateChannelOrderResponse> UpdateChannelOrder(Protocol.Chat.V1.UpdateChannelOrderRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.UpdateChannelOrderRequest, Protocol.Chat.V1.UpdateChannelOrderResponse>(_host + "/protocol.chat.v1.ChatService/UpdateChannelOrder", pm);
	
	// unary UpdateAllChannelOrder
	public async Task<Protocol.Chat.V1.UpdateAllChannelOrderResponse> UpdateAllChannelOrder(Protocol.Chat.V1.UpdateAllChannelOrderRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.UpdateAllChannelOrderRequest, Protocol.Chat.V1.UpdateAllChannelOrderResponse>(_host + "/protocol.chat.v1.ChatService/UpdateAllChannelOrder", pm);
	
	// unary UpdateMessageText
	public async Task<Protocol.Chat.V1.UpdateMessageTextResponse> UpdateMessageText(Protocol.Chat.V1.UpdateMessageTextRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.UpdateMessageTextRequest, Protocol.Chat.V1.UpdateMessageTextResponse>(_host + "/protocol.chat.v1.ChatService/UpdateMessageText", pm);
	
	// unary DeleteGuild
	public async Task<Protocol.Chat.V1.DeleteGuildResponse> DeleteGuild(Protocol.Chat.V1.DeleteGuildRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.DeleteGuildRequest, Protocol.Chat.V1.DeleteGuildResponse>(_host + "/protocol.chat.v1.ChatService/DeleteGuild", pm);
	
	// unary DeleteInvite
	public async Task<Protocol.Chat.V1.DeleteInviteResponse> DeleteInvite(Protocol.Chat.V1.DeleteInviteRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.DeleteInviteRequest, Protocol.Chat.V1.DeleteInviteResponse>(_host + "/protocol.chat.v1.ChatService/DeleteInvite", pm);
	
	// unary DeleteChannel
	public async Task<Protocol.Chat.V1.DeleteChannelResponse> DeleteChannel(Protocol.Chat.V1.DeleteChannelRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.DeleteChannelRequest, Protocol.Chat.V1.DeleteChannelResponse>(_host + "/protocol.chat.v1.ChatService/DeleteChannel", pm);
	
	// unary DeleteMessage
	public async Task<Protocol.Chat.V1.DeleteMessageResponse> DeleteMessage(Protocol.Chat.V1.DeleteMessageRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.DeleteMessageRequest, Protocol.Chat.V1.DeleteMessageResponse>(_host + "/protocol.chat.v1.ChatService/DeleteMessage", pm);
	
	// unary JoinGuild
	public async Task<Protocol.Chat.V1.JoinGuildResponse> JoinGuild(Protocol.Chat.V1.JoinGuildRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.JoinGuildRequest, Protocol.Chat.V1.JoinGuildResponse>(_host + "/protocol.chat.v1.ChatService/JoinGuild", pm);
	
	// unary LeaveGuild
	public async Task<Protocol.Chat.V1.LeaveGuildResponse> LeaveGuild(Protocol.Chat.V1.LeaveGuildRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.LeaveGuildRequest, Protocol.Chat.V1.LeaveGuildResponse>(_host + "/protocol.chat.v1.ChatService/LeaveGuild", pm);
	
	// unary TriggerAction
	public async Task<Protocol.Chat.V1.TriggerActionResponse> TriggerAction(Protocol.Chat.V1.TriggerActionRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.TriggerActionRequest, Protocol.Chat.V1.TriggerActionResponse>(_host + "/protocol.chat.v1.ChatService/TriggerAction", pm);
	
	// unary SendMessage
	public async Task<Protocol.Chat.V1.SendMessageResponse> SendMessage(Protocol.Chat.V1.SendMessageRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.SendMessageRequest, Protocol.Chat.V1.SendMessageResponse>(_host + "/protocol.chat.v1.ChatService/SendMessage", pm);
	
	// unary HasPermission
	public async Task<Protocol.Chat.V1.HasPermissionResponse> HasPermission(Protocol.Chat.V1.HasPermissionRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.HasPermissionRequest, Protocol.Chat.V1.HasPermissionResponse>(_host + "/protocol.chat.v1.ChatService/HasPermission", pm);
	
	// unary SetPermissions
	public async Task<Protocol.Chat.V1.SetPermissionsResponse> SetPermissions(Protocol.Chat.V1.SetPermissionsRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.SetPermissionsRequest, Protocol.Chat.V1.SetPermissionsResponse>(_host + "/protocol.chat.v1.ChatService/SetPermissions", pm);
	
	// unary GetPermissions
	public async Task<Protocol.Chat.V1.GetPermissionsResponse> GetPermissions(Protocol.Chat.V1.GetPermissionsRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GetPermissionsRequest, Protocol.Chat.V1.GetPermissionsResponse>(_host + "/protocol.chat.v1.ChatService/GetPermissions", pm);
	
	// unary MoveRole
	public async Task<Protocol.Chat.V1.MoveRoleResponse> MoveRole(Protocol.Chat.V1.MoveRoleRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.MoveRoleRequest, Protocol.Chat.V1.MoveRoleResponse>(_host + "/protocol.chat.v1.ChatService/MoveRole", pm);
	
	// unary GetGuildRoles
	public async Task<Protocol.Chat.V1.GetGuildRolesResponse> GetGuildRoles(Protocol.Chat.V1.GetGuildRolesRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GetGuildRolesRequest, Protocol.Chat.V1.GetGuildRolesResponse>(_host + "/protocol.chat.v1.ChatService/GetGuildRoles", pm);
	
	// unary AddGuildRole
	public async Task<Protocol.Chat.V1.AddGuildRoleResponse> AddGuildRole(Protocol.Chat.V1.AddGuildRoleRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.AddGuildRoleRequest, Protocol.Chat.V1.AddGuildRoleResponse>(_host + "/protocol.chat.v1.ChatService/AddGuildRole", pm);
	
	// unary ModifyGuildRole
	public async Task<Protocol.Chat.V1.ModifyGuildRoleResponse> ModifyGuildRole(Protocol.Chat.V1.ModifyGuildRoleRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.ModifyGuildRoleRequest, Protocol.Chat.V1.ModifyGuildRoleResponse>(_host + "/protocol.chat.v1.ChatService/ModifyGuildRole", pm);
	
	// unary DeleteGuildRole
	public async Task<Protocol.Chat.V1.DeleteGuildRoleResponse> DeleteGuildRole(Protocol.Chat.V1.DeleteGuildRoleRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.DeleteGuildRoleRequest, Protocol.Chat.V1.DeleteGuildRoleResponse>(_host + "/protocol.chat.v1.ChatService/DeleteGuildRole", pm);
	
	// unary ManageUserRoles
	public async Task<Protocol.Chat.V1.ManageUserRolesResponse> ManageUserRoles(Protocol.Chat.V1.ManageUserRolesRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.ManageUserRolesRequest, Protocol.Chat.V1.ManageUserRolesResponse>(_host + "/protocol.chat.v1.ChatService/ManageUserRoles", pm);
	
	// unary GetUserRoles
	public async Task<Protocol.Chat.V1.GetUserRolesResponse> GetUserRoles(Protocol.Chat.V1.GetUserRolesRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GetUserRolesRequest, Protocol.Chat.V1.GetUserRolesResponse>(_host + "/protocol.chat.v1.ChatService/GetUserRoles", pm);
	
	// unary Typing
	public async Task<Protocol.Chat.V1.TypingResponse> Typing(Protocol.Chat.V1.TypingRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.TypingRequest, Protocol.Chat.V1.TypingResponse>(_host + "/protocol.chat.v1.ChatService/Typing", pm);
	
	// unary PreviewGuild
	public async Task<Protocol.Chat.V1.PreviewGuildResponse> PreviewGuild(Protocol.Chat.V1.PreviewGuildRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.PreviewGuildRequest, Protocol.Chat.V1.PreviewGuildResponse>(_host + "/protocol.chat.v1.ChatService/PreviewGuild", pm);
	
	// unary GetBannedUsers
	public async Task<Protocol.Chat.V1.GetBannedUsersResponse> GetBannedUsers(Protocol.Chat.V1.GetBannedUsersRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GetBannedUsersRequest, Protocol.Chat.V1.GetBannedUsersResponse>(_host + "/protocol.chat.v1.ChatService/GetBannedUsers", pm);
	
	// unary BanUser
	public async Task<Protocol.Chat.V1.BanUserResponse> BanUser(Protocol.Chat.V1.BanUserRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.BanUserRequest, Protocol.Chat.V1.BanUserResponse>(_host + "/protocol.chat.v1.ChatService/BanUser", pm);
	
	// unary KickUser
	public async Task<Protocol.Chat.V1.KickUserResponse> KickUser(Protocol.Chat.V1.KickUserRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.KickUserRequest, Protocol.Chat.V1.KickUserResponse>(_host + "/protocol.chat.v1.ChatService/KickUser", pm);
	
	// unary UnbanUser
	public async Task<Protocol.Chat.V1.UnbanUserResponse> UnbanUser(Protocol.Chat.V1.UnbanUserRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.UnbanUserRequest, Protocol.Chat.V1.UnbanUserResponse>(_host + "/protocol.chat.v1.ChatService/UnbanUser", pm);
	
	// unary GetPinnedMessages
	public async Task<Protocol.Chat.V1.GetPinnedMessagesResponse> GetPinnedMessages(Protocol.Chat.V1.GetPinnedMessagesRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GetPinnedMessagesRequest, Protocol.Chat.V1.GetPinnedMessagesResponse>(_host + "/protocol.chat.v1.ChatService/GetPinnedMessages", pm);
	
	// unary PinMessage
	public async Task<Protocol.Chat.V1.PinMessageResponse> PinMessage(Protocol.Chat.V1.PinMessageRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.PinMessageRequest, Protocol.Chat.V1.PinMessageResponse>(_host + "/protocol.chat.v1.ChatService/PinMessage", pm);
	
	// unary UnpinMessage
	public async Task<Protocol.Chat.V1.UnpinMessageResponse> UnpinMessage(Protocol.Chat.V1.UnpinMessageRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.UnpinMessageRequest, Protocol.Chat.V1.UnpinMessageResponse>(_host + "/protocol.chat.v1.ChatService/UnpinMessage", pm);
	
	// stream StreamEvents
	public async Task<StreamClient<Protocol.Chat.V1.StreamEventsResponse>> StreamEvents(Protocol.Chat.V1.StreamEventsRequest pm)
	{
		var stream = new StreamClient<Protocol.Chat.V1.StreamEventsResponse>(DefaultRequestHeaders);
		await stream.Connect(_wsHost + "/protocol.chat.v1.ChatService/StreamEvents", pm);
		return stream;
	}
	
	// unary AddReaction
	public async Task<Protocol.Chat.V1.AddReactionResponse> AddReaction(Protocol.Chat.V1.AddReactionRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.AddReactionRequest, Protocol.Chat.V1.AddReactionResponse>(_host + "/protocol.chat.v1.ChatService/AddReaction", pm);
	
	// unary RemoveReaction
	public async Task<Protocol.Chat.V1.RemoveReactionResponse> RemoveReaction(Protocol.Chat.V1.RemoveReactionRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.RemoveReactionRequest, Protocol.Chat.V1.RemoveReactionResponse>(_host + "/protocol.chat.v1.ChatService/RemoveReaction", pm);
	
	// unary GrantOwnership
	public async Task<Protocol.Chat.V1.GrantOwnershipResponse> GrantOwnership(Protocol.Chat.V1.GrantOwnershipRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GrantOwnershipRequest, Protocol.Chat.V1.GrantOwnershipResponse>(_host + "/protocol.chat.v1.ChatService/GrantOwnership", pm);
	
	// unary GiveUpOwnership
	public async Task<Protocol.Chat.V1.GiveUpOwnershipResponse> GiveUpOwnership(Protocol.Chat.V1.GiveUpOwnershipRequest pm)
		=> await _client.HrpcUnaryAsync<Protocol.Chat.V1.GiveUpOwnershipRequest, Protocol.Chat.V1.GiveUpOwnershipResponse>(_host + "/protocol.chat.v1.ChatService/GiveUpOwnership", pm);
	
}
