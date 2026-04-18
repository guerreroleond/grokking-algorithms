namespace GrokkingAlgorithms._01IntroToAlgorithms;

public class BinarySearch
{
    
    /// <summary>
    /// Searches for <paramref name="item"/> in a sorted array using binary search.
    /// Each time you check the middle element,
    /// if the guess is too high, update high accordingly,
    /// and if the guess is to low, update low accordingly.
    /// </summary>
    /// <param name="nums">A sorted array of integers to search.</param>
    /// <param name="item">The value to search for.</param>
    /// <returns>The zero-based index of <paramref name="item"/> if found; 
    /// otherwise, -1.
    /// </returns>
    public static int Search(int[] nums, int item)
    {
        int low = 0;
        int high = nums.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int guess = nums[mid];

            if (guess == item)
                return mid;

            if (guess > item)
                high = mid - 1;
            else
                low = mid + 1;
        }

        return -1;
    }
}
