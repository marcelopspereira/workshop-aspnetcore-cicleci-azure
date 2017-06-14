using UnitTestApp.Configuration;
using Xunit;

namespace UnitTestApp
{
    [CollectionDefinition("Base collection")]
    public abstract class BaseTestCollection : ICollectionFixture<BaseTestFixture>
    {

    }
}