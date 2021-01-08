namespace HarmonySDK
{
    public sealed class Client
    {

        internal string _homeserverURI;
        internal string _authToken;

        public Client(string homeserverURI, string authToken)
        {
            this._homeserverURI = homeserverURI;
            this._authToken = authToken;

            this.Api = new ApiClient(this);
            this.Streams = new StreamClient(this);
        }

        public ApiClient Api { get; }
        public StreamClient Streams { get; }

    }
}