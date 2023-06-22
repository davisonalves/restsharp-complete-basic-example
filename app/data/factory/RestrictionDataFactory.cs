using Bogus;
using Bogus.Extensions.Brazil;

namespace restsharp_complete_basic_example.app.data.factory
{
    public class RestrictionDataFactory
    {
        private Faker faker = new Faker("pt_BR");
        public string CpfWithoutRestriction()
        {
            string cpf = faker.Person.Cpf();
            cpf = cpf.Replace(".", "").Replace("-", "");

            return cpf;
        }


        public String CpfWithRestriction()
        {
            List<string> cpfWithRestriction = new List<string>()
            {
                "97093236014",
                "60094146012",
                "84809766080",
                "62648716050",
                "26276298085",
                "01317496094",
                "55856777050",
                "19626829001",
                "24094592008",
                "58063164083"
            };

            string randomCpf = cpfWithRestriction[new Random().Next(cpfWithRestriction.Count)];

            return randomCpf;
        }
    }
}
