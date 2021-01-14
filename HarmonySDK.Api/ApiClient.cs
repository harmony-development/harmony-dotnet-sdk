using Grpc.Core;
using Grpc.Net.Client;

using Protocol.Chat.V1;

namespace HarmonySDK
{
    public sealed partial class ApiClient
    {
        internal GrpcChannel _channel;
        internal string _homeserverURI;
        internal string _authToken;
        internal Grpc.Core.Metadata _defaultAuthMetadata;
        internal ChatService.ChatServiceClient _chatService;

        internal ApiClient(Client client)
        {
            this._homeserverURI = client._homeserverURI;
            this._channel = GrpcChannel.ForAddress(this._homeserverURI);
            this._authToken = client._authToken;

            this._defaultAuthMetadata = new Metadata{ {"auth", this._authToken} };
            this._chatService = new ChatService.ChatServiceClient(this._channel);
        }

        public ApiClient(string homeserverURI, string authToken)
        {
            this._homeserverURI = homeserverURI;
            this._channel = GrpcChannel.ForAddress(this._homeserverURI);
            this._authToken = authToken;

            this._defaultAuthMetadata = new Metadata{ {"auth", this._authToken} };
            this._chatService = new ChatService.ChatServiceClient(this._channel);
        }
    }
}