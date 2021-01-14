using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Grpc.Core;
using Grpc.Net.Client;

using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

using HarmonySDK;

using Protocol.Auth.V1;
using Protocol.Chat.V1;

namespace HarmonySDK.Tests
{
    [TestClass]
    public class SDKTests
    {
        private GrpcChannel _channel;
        private ulong _userId;
        private string _authToken;
        internal Grpc.Core.Metadata _defaultAuthMetadata;

        private ChatService.ChatServiceClient _chatService;
        private AuthService.AuthServiceClient _authService;

        // probably should rewrite all this with a proper testing library at some point but y'know
        // or figure out how to run tests in a certain order in MSTest, I guess

        public async Task CreateChannels()
        {
            this._channel = GrpcChannel.ForAddress("http://localhost:2289");
            this._authService = new AuthService.AuthServiceClient(this._channel);
            this._chatService = new ChatService.ChatServiceClient(this._channel);
        }

        public async Task GenerateAuth()
        {
            var authId = (await _authService.BeginAuthAsync(new Empty())).AuthId;
            await _authService.NextStepAsync(new NextStepRequest { AuthId = authId, } );

            await _authService.NextStepAsync(new NextStepRequest { AuthId = authId,
                Choice = new NextStepRequest.Types.Choice { Choice_ = "register" }
            });

            var form = new NextStepRequest.Types.Form();
            form.Fields.Insert(0, new NextStepRequest.Types.FormFields { String = "test@test.testing", });
            form.Fields.Insert(1, new NextStepRequest.Types.FormFields { String = "testUser1234", });
            form.Fields.Insert(2, new NextStepRequest.Types.FormFields { Bytes = ByteString.CopyFromUtf8("Some5b23!"), });

            var thirdStep = await _authService.NextStepAsync(new NextStepRequest { AuthId = authId, Form = form, });

            _userId = (thirdStep as AuthStep).Session.UserId;
            _authToken = (thirdStep as AuthStep).Session.SessionToken;

            this._defaultAuthMetadata = new Metadata{ {"auth", this._authToken} };
        }

        [TestMethod]
        public async Task RunTests()
        {
            await CreateChannels();
            await GenerateAuth();
            var client = new Client("http://localhost:2289", _authToken);

            await client.Api.UpdateProfile(newUsername: "Test2", isBot: true);

            await client.Api.GetUser(_userId);
            // await client.Api.GetUserMetadata(_userId);

            await client.Api.UpdateStatus(UserStatus.OnlineUnspecified);
            await client.Api.UpdateStatus(UserStatus.Streaming);
            await client.Api.UpdateStatus(UserStatus.Idle);
            await client.Api.UpdateStatus(UserStatus.DoNotDisturb);

            var guild = await client.Api.CreateGuild("test");
            await client.Api.ModifyGuild(guild, "Test2");
            await client.Api.CreateInvite(guild, "test");
            await client.Api.PreviewGuild("test");
            await client.Api.DeleteInvite(guild, "test");

            var channel = await client.Api.CreateChannel(guild, "test", false, new ChannelPosition());
            await client.Api.UpdateChannelName(guild, channel, "Test2");
            await client.Api.GetGuildChannels(guild);

            await client.Api.SendChannelTyping(guild, channel);
            var message = await client.Api.CreateMessage(guild, channel, "test");
            
            // this doesn't work?
            // await client.Api.GetChannelMessages(guild, channel, message);

            await client.Api.UpdateMessage(guild, channel, message, "Test2");
            await client.Api.DeleteMessage(guild, channel, message);

            // this hangs forever
            // await client.Api.DeleteChannel(guild, channel);
            // await client.Api.DeleteGuild(guild);
        }

        [TestMethod]
        public void MeowAsync()
        {
            // throw new Exception("cannot meow right now");
            Console.WriteLine("meow!");
        }
    }
}
