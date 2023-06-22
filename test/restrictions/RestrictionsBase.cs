using restsharp_complete_basic_example.app.data.factory;

namespace restsharp_complete_basic_example.test.restrictions
{
    public abstract class RestrictionsBase: BaseAPI
    {
        protected static RestrictionDataFactory restrictionDataFactory = new RestrictionDataFactory();
    }
}
