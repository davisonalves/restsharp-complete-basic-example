using RestSharp;
using System.Net;
using Newtonsoft.Json.Linq;
using static restsharp_complete_basic_example.app.data.changeless.TestSuiteTags;
using static restsharp_complete_basic_example.app.config.Configuration;

namespace restsharp_complete_basic_example.test.general
{
    [TestFixture]
    public class CreditHealthCheckTest
    {

        private string BASE_URL = baseUrlHealth;
        private RestClient client;

        [OneTimeSetUp]
        public void Setup()
        {
            client = new RestClient(BASE_URL);
        }

        [Test]
        [Category(HEALTH)]
        [Description("Should be able to hit the health endpoint")]
        public void HealthCheck()
        {
            RestRequest request = new RestRequest("/health", Method.Get);

            RestResponse response = client.Execute(request);
            JObject responseBody = JObject.Parse(response.Content);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(responseBody["status"].ToString(), Is.EqualTo("UP"));
        }
    }
}
