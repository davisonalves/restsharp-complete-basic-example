using Bogus;
using Bogus.Extensions.Brazil;

namespace restsharp_complete_basic_example.app.data.factory
{
    public class SimulationDataFactory
    {
        private Faker faker = new Faker("pt_BR");

        public string NonExistentName()
        {
            string nonExistentName = faker.Name.FirstName();

            return nonExistentName;
        }

        public string NotExistentCpf()
        {
            string notExistentCpf = faker.Person.Cpf();
            notExistentCpf = notExistentCpf.Replace(".", "").Replace("-", "");

            return notExistentCpf;
        }
    }
}
