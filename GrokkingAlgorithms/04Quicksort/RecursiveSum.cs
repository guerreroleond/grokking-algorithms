namespace GrokkingAlgorithms._04Quicksort;

public class RecursiveSum
{
    /// <summary>
    /// Recursively calculates the sum of all elements in the array.
    /// If the array is empty or null, return zero,
    /// Otherwhise, the total sum is the first number in the array
    /// + the sum of the rest of the array.
    /// </summary>
    /// <param name="nums">The array of integers to sum.</param>
    /// <returns>The sum of all elements in <paramref name="nums"/>.</returns>
    public static int Sum(int[] nums)
    {
        if (nums == null || nums.Length == 0) return 0;
        // Base case.
        else if (nums.Length == 1) return nums[0];
        // Recursive case.
        else
        {
            var segment = new ArraySegment<int>(
                nums, 1, nums.Length - 1);
            return nums[0] + Sum(segment.ToArray<int>());
        }
    }
}
