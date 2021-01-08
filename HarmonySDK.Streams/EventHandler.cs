using System;
using System.Threading.Tasks;

using AsyncEvent;

using Protocol.Chat.V1;

namespace HarmonySDK
{
    public sealed class EventHandler
    {
        private Client _client;

        internal EventHandler(Client client)
        {
            this._client = client;
        }

        public EventHandler() {}

        public event AsyncEventHandler<Event.Types.GuildAddedToList> OnGuildAddedToList;
        public event AsyncEventHandler<Event.Types.GuildRemovedFromList> OnGuildRemovedFromList;
        public event AsyncEventHandler<Event.Types.ActionPerformed> OnActionPerformed;
        public event AsyncEventHandler<Event.Types.MessageSent> OnMessageSent;
        public event AsyncEventHandler<Event.Types.MessageUpdated> OnMessageUpdated;
        public event AsyncEventHandler<Event.Types.MessageDeleted> OnMessageDeleted;
        public event AsyncEventHandler<Event.Types.ChannelCreated> OnChannelCreated;
        public event AsyncEventHandler<Event.Types.ChannelUpdated> OnChannelUpdated;
        public event AsyncEventHandler<Event.Types.ChannelDeleted> OnChannelDeleted;
        public event AsyncEventHandler<Event.Types.GuildUpdated> OnGuildUpdated;
        public event AsyncEventHandler<Event.Types.GuildDeleted> OnGuildDeleted;
        public event AsyncEventHandler<Event.Types.MemberJoined> OnMemberJoined;
        public event AsyncEventHandler<Event.Types.MemberLeft> OnMemberLeft;
        public event AsyncEventHandler<Event.Types.RoleMoved> OnRoleMoved;
        public event AsyncEventHandler<Event.Types.ProfileUpdated> OnProfileUpdated;
        public event AsyncEventHandler<Event.Types.Typing> OnTyping;
        public event AsyncEventHandler<Event> OnUnknownEvent;
        internal void HandleEvent(Event ev)
        {
            if (ev.GuildAddedToList != null)
                OnGuildAddedToList.InvokeAsync(_client, ev.GuildAddedToList);
            else if (ev.GuildRemovedFromList != null)
                OnGuildRemovedFromList.InvokeAsync(_client, ev.GuildRemovedFromList);
            else if (ev.ActionPerformed != null)
                OnActionPerformed.InvokeAsync(_client, ev.ActionPerformed);
            else if (ev.SentMessage != null)
                OnMessageSent.InvokeAsync(_client, ev.SentMessage);
            else if (ev.EditedMessage != null)
                OnMessageUpdated.InvokeAsync(_client, ev.EditedMessage);
            else if (ev.DeletedMessage != null)
                OnMessageDeleted.InvokeAsync(_client, ev.DeletedMessage);
            else if (ev.CreatedChannel != null)
                OnChannelCreated.InvokeAsync(_client, ev.CreatedChannel);
            else if (ev.EditedChannel != null)
                OnChannelUpdated.InvokeAsync(_client, ev.EditedChannel);
            else if (ev.DeletedChannel != null)
                OnChannelDeleted.InvokeAsync(_client, ev.DeletedChannel);
            else if (ev.EditedGuild != null)
                OnGuildUpdated.InvokeAsync(_client, ev.EditedGuild);
            else if (ev.DeletedGuild != null)
                OnGuildDeleted.InvokeAsync(_client, ev.DeletedGuild);
            else if (ev.JoinedMember != null)
                OnMemberJoined.InvokeAsync(_client, ev.JoinedMember);
            else if (ev.LeftMember != null)
                OnMemberLeft.InvokeAsync(_client, ev.LeftMember);
            else if (ev.RoleMoved != null)
                OnRoleMoved.InvokeAsync(_client, ev.RoleMoved);
            else if (ev.ProfileUpdated != null)
                OnProfileUpdated.InvokeAsync(_client, ev.ProfileUpdated);
            else if (ev.Typing != null)
                OnTyping.InvokeAsync(_client, ev.Typing);
            else
                OnUnknownEvent.InvokeAsync(_client, ev);
        }

    }
}