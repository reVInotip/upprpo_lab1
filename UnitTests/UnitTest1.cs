using Solvers;
using Xunit;

namespace UnitTests;

public class TestSolvers
{
    private void RunTest(ISolver solver, object[] input, object[] expectedOutput)
    {
        solver.SetInput(input);
        solver.Run();

        var actualOutput = solver.GetOutput();

        Assert.Equal(expectedOutput.Length, actualOutput.Length);

        for (var index = 0; index < actualOutput.Length; index++)
        {
            Assert.Equal(expectedOutput[index], actualOutput[index]);
        }
    }

    private void RunTest(ISolver solver, object[] input, double[] expectedOutput, double delta)
    {
        solver.SetInput(input);
        solver.Run();

        var actualOutput = solver.GetOutput();

        Assert.Equal(expectedOutput.Length, actualOutput.Length);

        for (var index = 0; index < actualOutput.Length; index++)
        {
            Assert.Equal(expectedOutput[index], (double)actualOutput[index], delta);
        }
    }


    [Fact]
    public void TestQuadraticEquationSolver()
    {
        RunTest(new QuadraticEquationSolver(), [3.0, 6.0, 2.0], [-0.422, -1.577], 1.0e-3);
        RunTest(new QuadraticEquationSolver(), [-1.0, 10.0, -10.0], [1.127, 8.872], 1.0e-3);
        RunTest(new QuadraticEquationSolver(), [18.0, 19.0, 20.0], [], 1.0e-3);
        RunTest(new QuadraticEquationSolver(), [7.0, 1.0, 2.0], [], 0.0);

    }
}
