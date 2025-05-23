using System;
using Solvers;

namespace upprpo_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quadraticEquationSolver = new QuadraticEquationSolver();
            quadraticEquationSolver.SetInput([3, 6, 2]);
            quadraticEquationSolver.Run();

            var solution = quadraticEquationSolver.GetOutput();

            Console.WriteLine($"X1: {solution[0]}\n" +
                              $"X2: {solution[1]}");

            Console.ReadLine();

            Console.WriteLine("Hello world!");
            Console.WriteLine("Hello world2!");
        }
    }
}
