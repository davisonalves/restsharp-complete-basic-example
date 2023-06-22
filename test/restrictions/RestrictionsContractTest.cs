using RestSharp;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using restsharp_complete_basic_example.app.data.changeless;
using restsharp_complete_basic_example.test.restrictions;
using static restsharp_complete_basic_example.app.data.changeless.TestSuiteTags;

namespace restsharp_complete_basic_example.test.general
{
    [TestFixture]
    public class RestrictionsContractTest : RestrictionsBase
    {
        [Test]
        [Category(CONTRACT)]
        [Description("Should validate the restrictions schema for GET method in v1")]
        public void ContractOnV1()
        {
            RestRequest request = new RestRequest(RestrictionsData.GET_RESTRICTIONS, Method.Get);
            request.AddUrlSegment(RestrictionsData.CPF, restrictionDataFactory.CpfWithRestriction());

            RestResponse response = client.Execute(request);

            JObject responseBody = JObject.Parse(response.Content);
            JSchema schemaJson = JSchema.Parse(File.ReadAllText("../../../test/resources/schemas/restrictions_v1_schema.json"));

            Assert.That(responseBody.IsValid(schemaJson, out IList<string> messages), string.Join(",", messages), Is.True);
        }
    }
}
