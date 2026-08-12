namespace GrokkingAlgorithms._11DynamicProgramming;

public class LongestCommonSubstring
{
    /// <summary>
    /// [GA1102] Finds the length of the longest common substring between two strings.
    /// </summary>
    /// <param name="wordA">The first string.</param>
    /// <param name="wordB">The second string.</param>
    /// <returns>The length of the longest common substring.</returns>
    public static int Solve(string wordA, string wordB)
    {
        ArgumentNullException.ThrowIfNullOrWhiteSpace(wordA);
        ArgumentNullException.ThrowIfNullOrWhiteSpace(wordB);

        int[,] dp = new int[wordA.Length + 1, wordB.Length + 1];
        int longest = 0;

        for (var a = 0; a < wordA.Length; a++)
        {
            for (var b = 0; b < wordB.Length; b++)
            {
                if (wordA[a] == wordB[b])
                {
                    dp[a + 1, b + 1] = dp[a, b] + 1;
                    longest = Math.Max(dp[a + 1, b + 1], longest);
                }
                else
                    dp[a + 1, b + 1] = 0;
            }
        }

        return longest;
    }
}
