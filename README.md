# xunit.repro
Project to reproduce an issue with text fixtures in xUnit.

### Issue:

When two projects have a collection definition that point to the same class definition in a third project
the test fixture only runs once with tests are run (using VS Test explorer) from both projects.

### Steps to reproduce:
After building the project:

1. Set breakpoints in the constructor and dispose method of the Core.TestRunFixture
class.
2. Select both MyTestOne.MyFirstTest and MyTestTwo.MySecondTest and debug them.

### Problem:
The breakpoints in TestRunFixture are only hit for the first test.

### Expected:
The breakpoints would be hit twice, once for each test.

### Note
If you debug the tests separately you will hit the breakpoints for each test.

### One More Thing
I get an error when debugging a single test at the end.  I do not get this error when I debug both tests in a single pass.  Not sure what it means.

Managed Debugging Assistant 'DisconnectedContext' has detected a problem in 'C:\PROGRAM FILES (X86)\MICROSOFT VISUAL STUDIO 14.0\COMMON7\IDE\COMMONEXTENSIONS\MICROSOFT\TESTWINDOW\te.processhost.managed.exe'.

Additional information: Transition into COM context 0x12251f0 for this RuntimeCallableWrapper failed with the following error: The object invoked has disconnected from its clients. (Exception from HRESULT: 0x80010108 (RPC_E_DISCONNECTED)). This is typically because the COM context 0x12251f0 where this RuntimeCallableWrapper was created has been disconnected or it is busy doing something else. Releasing the interfaces from the current COM context (COM context 0x1225080). This may cause corruption or data loss. To avoid this problem, please ensure that all COM contexts/apartments/threads stay alive and are available for context transition, until the application is completely done with the RuntimeCallableWrappers that represents COM components that live inside them.