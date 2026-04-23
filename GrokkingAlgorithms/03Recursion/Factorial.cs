namespace GrokkingAlgorithms._03Recursion;

public class Factorial
{
    /// <summary>
    /// Recursively computes the factorial of <paramref name="num"/>.
    /// Is the <paramref name="num"/> multiplied by every integer below it
    /// that is greater than zero.
    /// </summary>
    /// <param name="num">A positive integer whose factorial is to be computed.</param>
    /// <returns>The factorial of <paramref name="num"/> (i.e. num!).</returns>
    public static int Fact(int num)
    {
        // Base case
        if (num == 1) return 1;
        // Recursive case.
        else return num * Fact(num - 1);
    }
}
