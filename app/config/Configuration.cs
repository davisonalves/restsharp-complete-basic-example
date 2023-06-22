using Newtonsoft.Json.Linq;

namespace restsharp_complete_basic_example.app.config
{
    public static class Configuration
    {
        private static string json = File.ReadAllText("../../../test/resources/config.json");

        private static JObject config = JObject.Parse(json);

        public static string baseUrl = config["api.base.url"].ToString();
        public static string baseUrlHealth = config["api.base.url.health"].ToString();
    }
}