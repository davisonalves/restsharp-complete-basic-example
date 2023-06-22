using RestSharp;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using restsharp_complete_basic_example.app.data.changeless;
using restsharp_complete_basic_example.test.simulations;
using static restsharp_complete_basic_example.app.data.changeless.TestSuiteTags;

namespace restsharp_complete_basic_example.test.general
{
    [TestFixture]
    public class SimulationsContractTest : SimulationsBase
    {
        [Test]
        [Category(CONTRACT)]
        [Description("Should validate the simulation schema for non-existing simulation")]
        public void ContractOnSimulationNotFound()
        {
            RestRequest request = new RestRequest(SimulationsData.GET_SIMULATIONS, Method.Get);
            request.AddUrlSegment(SimulationsData.CPF, simulationDataFactory.NotExistentCpf());

            RestResponse response = client.Execute(request);

            JObject responseBody = JObject.Parse(response.Content);
            JSchema schemaJson = JSchema.Parse(File.ReadAllText("../../../test/resources/schemas/simulations_not_existent_v1_schema.json"));


            Assert.That(responseBody.IsValid(schemaJson, out IList<string> messages), string.Join(",", messages), Is.True);
        }
    }
}
