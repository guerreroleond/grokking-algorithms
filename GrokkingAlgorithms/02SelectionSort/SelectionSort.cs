namespace GrokkingAlgorithms._02SelectionSort;

public class SelectionSort
{
    /// <summary>
    /// Use two pointers: `i` & `j`, `j` will start one position ahead of `i`.
    /// Iterate numbers from 0 to one before last one. `i`
    /// In an inner iteration `j` until the last one, 
    /// traverse remaining elements to compare with `i`, 
    /// and get the `smallest index`.
    /// At the end of the inner iteration compare `smallest index` 
    /// to the `current one` (`i`). 
    /// **Swap** if different, meaning smallest is actually smaller than current one.
    /// </summary>
    /// <param name="nums">Array of numbers to be sorted.</param>
    /// <returns>Array of sorted numbers.</returns>
    public static int[] Sort(int[] nums)
    {
        for (var i = 0; i < nums.Length - 1; i++)
        {
            var smallestIndex = i;
            // Find the smallest.
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] < nums[smallestIndex])
                {
                    smallestIndex = j;
                }
            }

            // Swap if needed.
            if (smallestIndex != i)
            {
                // ToDo: Check how to do this with a tuple.
                var temp = nums[i];
                nums[i] = nums[smallestIndex];
                nums[smallestIndex] = temp;
            }
        }

        return nums;
    }
}
