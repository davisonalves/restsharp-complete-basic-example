using RestSharp;
using restsharp_complete_basic_example.app.config;

namespace restsharp_complete_basic_example.test
{
    public abstract class BaseAPI
    {
        public string BASE_URL = Configuration.baseUrl;
        public RestClient client;

        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            client = new RestClient(BASE_URL);
        }
    }
}
