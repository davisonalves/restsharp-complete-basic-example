namespace restsharp_complete_basic_example.app.data.changeless
{
    public static class RestrictionsData
    {
        public const string SERVICE = "/restrictions";
        public const string GET_RESTRICTIONS = $"{SERVICE}/{{cpf}}";
        public const string CPF = "cpf";
    }
}
