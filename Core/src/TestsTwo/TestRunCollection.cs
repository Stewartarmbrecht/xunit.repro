using Core;
using Xunit;

namespace TestsTwo
{
    [CollectionDefinition("TestsTwo")]
    public class TestRunCollection : ICollectionFixture<TestRunFixture>
    {

    }
}
