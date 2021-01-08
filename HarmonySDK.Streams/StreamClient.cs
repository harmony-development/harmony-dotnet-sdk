using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Grpc.Core;
using Grpc.Net.Client;

using Protocol.Chat.V1;

namespace HarmonySDK
{
    public sealed class StreamClient
    {
        private Dictionary<string, AsyncDuplexStreamingCall<StreamEventsRequest, Event>> _serverStreamMap 
            = new Dictionary<string, AsyncDuplexStreamingCall<StreamEventsRequest, Event>>();

        internal StreamClient(Client client)
        {
            this._api = client.Api;
            this.Events = new EventHandler(client);
        }

        public StreamClient(string host, string token)
        {
            this._api = new ApiClient(host, token);
            this.Events = new EventHandler();
        }

        public StreamClient(ApiClient api)
        {
            this._api = api;
            this.Events = new EventHandler();            
        }

        private ApiClient _api;
        public EventHandler Events { get; }

        public async Task BeginHomeserverStream()
        {
            var stream = _api._chatService.StreamEvents(_api._defaultAuthMetadata);
            this._serverStreamMap.Add(_api._homeserverURI, stream);
            _ = this.HandleStreamEvents(stream);
            
            var guilds = await this._api.GetGuildList();
            foreach (GetGuildListResponse.Types.GuildListEntry g in guilds)
            {
                var r = new StreamEventsRequest();
                var sub = new StreamEventsRequest.Types.SubscribeToGuild();
                sub.GuildId = g.GuildId;
                r.SubscribeToGuild = sub;
                await stream.RequestStream.WriteAsync(r);               
            }
        }

        private async Task HandleStreamEvents(AsyncDuplexStreamingCall<StreamEventsRequest, Event> stream)
        {
            await stream.ResponseStream.MoveNext(new CancellationToken());

            while (true) {
                if (stream.ResponseStream.Current == null) continue;
                Events.HandleEvent(stream.ResponseStream.Current);
                await stream.ResponseStream.MoveNext(new CancellationToken());
            }
        }

        public void EndServerStream(string host)
        {
            _serverStreamMap.TryGetValue(host, out var stream);
            stream?.Dispose();
        }
    }
}