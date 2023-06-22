using RestSharp;
using System.Net;
using Newtonsoft.Json.Linq;
using restsharp_complete_basic_example.app.data.changeless;
using restsharp_complete_basic_example.test.restrictions;
using static restsharp_complete_basic_example.app.data.changeless.TestSuiteTags;

namespace restsharp_complete_basic_example.test.general
{
    [TestFixture]
    public class RestrictionsFunctionalTest:RestrictionsBase
    {
        [Test]
        [Category(FUNCTIONAL)]
        [Description("Should query a CPF without restriction")]
        public void CpfWithNoRestriction()
        {
            RestRequest request = new RestRequest(RestrictionsData.GET_RESTRICTIONS, Method.Get);
            request.AddUrlSegment(RestrictionsData.CPF, restrictionDataFactory.CpfWithoutRestriction());

            RestResponse response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
        }

        [Test]
        [Category(FUNCTIONAL)]
        [Description("Should query a CPF with restriction")]
        public void CpfWithRestriction()
        {
            string cpfWithRestriction = restrictionDataFactory.CpfWithRestriction();
            RestRequest request = new RestRequest(RestrictionsData.GET_RESTRICTIONS, Method.Get);
            request.AddUrlSegment(RestrictionsData.CPF, cpfWithRestriction);

            RestResponse response = client.Execute(request);
            JObject responseBody = JObject.Parse(response.Content);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(responseBody["message"].ToString, Is.EqualTo($"CPF {cpfWithRestriction} has a restriction"));
        }
    }
}
