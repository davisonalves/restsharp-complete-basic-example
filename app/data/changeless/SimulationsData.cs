namespace restsharp_complete_basic_example.app.data.changeless
{
    public static class SimulationsData
    {
        public const string SERVICE = "/simulations";
        public const string GET_SIMULATIONS = $"{SERVICE}/{{cpf}}";
        public const string CPF = "cpf";
    }
}
