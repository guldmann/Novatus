using NovatusCommon.ComTypes;
using NovatusCommon.Models;
using Xunit;
using FluentAssertions;

namespace NovatusCommonTest.ComType
{
    public class ComFactoryTest : TestBase
    {
        [Fact]
        public void Given_communicationHttp_and_GetServerUpdateAppInfo_is_called_A_ServerUpdateAppInfo_is_returned()
        {
            string url = GetLocalhostAddress();
            var port = GetPort();
            var factory = new Communication().ExecuteCreation(NovatusCommon.ComTypes.ComType.Http);
            var serverUpdateAppInfo = GetServerUpdateAppInfo();
         
            using (BasicHttpServer(url, serverUpdateAppInfo))
            {
                var result = factory.GetServerUpdateAppInfo(
                    new UpdateServer
                    {
                        ServerName = "someName",
                        ComType = NovatusCommon.ComTypes.ComType.Http,
                        Port = GetPort(),
                        Host = "localhost",
                        Password = "",
                        UserName = "",
                        UpdateFileName = "someName",
                        Url = "someUrl"
                    });

                result.Result.Should().NotBeNull();
                result.Result.AppVersion.Should().Be("1.0");
                result.Result.AppName.Should().Be("Test App");
            }
        }
    }
}