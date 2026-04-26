namespace GrokkingAlgorithms._04Quicksort;

public class Quicksort
{
    /// <summary>
    /// [GA0404] Recursively sorts an array of integers using the quicksort algorithm.
    /// **Steps:**
    ///     1. Pick a `pivot`.
    ///     2. Partition the array into two sub-arrays:
    //          a. Elements `less` than the pivot.
    //          b. Elements `greater` than the pivot.
    ///     3. Call quicksort `recursively` on the two sub-arrays.
    /// </summary>
    /// <param name="nums">The array of integers to sort.</param>
    /// <returns>A new sorted array containing all elements from <paramref name="nums"/>.</returns>
    public static int[] QSort(int[] nums)
    {
        // Base case.
        if (nums == null || nums.Length < 2) return nums;
        // Recursive case.
        else
        {
            var pivot = nums[0];

            var smallers = new List<int>();
            var biggers = new List<int>();

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= pivot)
                    smallers.Add(nums[i]);
                else
                    biggers.Add(nums[i]);
            }
            int[] pivotArr = [pivot];

            return [..QSort([.. smallers]),  // List to array collection expression.
                    ..pivotArr,
                    ..QSort([.. biggers])];  // List to array collection expression.
        }
    }
}
