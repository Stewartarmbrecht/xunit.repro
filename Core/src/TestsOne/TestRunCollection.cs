using Core;
using Xunit;

namespace TestsOne
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    [CollectionDefinition("TestsOne")]
    public class TestRunCollection : ICollectionFixture<TestRunFixture>
    {

    }
}
