namespace GrokkingAlgorithms._04Quicksort;

public class RecursiveMax
{
    /// <summary>
    /// [GA0403] Recursively finds the maximum value in the array.
    /// If the array is empty or null, return zero,
    /// Otherwhise, the max is the max between current num in the array
    /// and the max of rest of the array.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <returns>The maximum element in <paramref name="nums"/>.</returns>
    public static int Max(int[] nums)
    {
        if (nums == null || nums.Length == 0) return 0;
        // Base case.
        else if (nums.Length == 1) return nums[0];
        // Recursive case.
        else
        {
            var segment = new ArraySegment<int>(
                nums, 1, nums.Length - 1).ToArray<int>();
            return Math.Max(nums[0], Max(segment));
        }
    }
}
