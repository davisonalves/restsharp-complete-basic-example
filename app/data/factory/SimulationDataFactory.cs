using Bogus;
using Bogus.Extensions.Brazil;
using restsharp_complete_basic_example.app.data.model;

namespace restsharp_complete_basic_example.app.data.factory
{
    public class SimulationDataFactory
    {
        private static Faker faker = new Faker("pt_BR");


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

        public Simulation MissingAllInformation()
        {
            Simulation simulationWithMissingInfo = new Simulation
            {
                Name = "",
                Cpf = faker.Person.Cpf(),
                Email = faker.Name.FirstName() + "." + faker.Name.LastName(),
                Installments = faker.Random.Int(0, 1),
                Insurance = faker.Random.Bool(),
                Amount = faker.Random.Int(0, 999)
            };

            return simulationWithMissingInfo;
        }
    }
}
