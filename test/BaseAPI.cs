using RestSharp;
using restsharp_complete_basic_example.app.config;

namespace restsharp_complete_basic_example.test
{
    public abstract class BaseAPI
    {
        protected static string BASE_URL = Configuration.baseUrl;
        protected static RestClient client;

        [OneTimeSetUp]
        public static void BeforeAllTests()
        {
            client = new RestClient(BASE_URL);
        }
    }
}
