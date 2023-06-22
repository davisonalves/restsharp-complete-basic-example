using restsharp_complete_basic_example.app.data.factory;
namespace restsharp_complete_basic_example.test.simulations
{
    public abstract class SimulationsBase: BaseAPI
    {
        protected static SimulationDataFactory simulationDataFactory = new SimulationDataFactory();
    }
}
