using System;

namespace Core
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class TestRunFixture : IDisposable
    {
        public TestRunFixture()
        {
            string test = "I'm built!";
            Console.Write(test);
        }
        public void Dispose()
        {
            string test = "I'm disposed.";

            Console.Write(test);
        }
    }
}
