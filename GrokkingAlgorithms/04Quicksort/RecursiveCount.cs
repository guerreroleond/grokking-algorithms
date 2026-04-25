namespace GrokkingAlgorithms._04Quicksort;

public class RecursiveCount
{
    /// <summary>
    /// [GA0402] Recursively counts the number of items in the array.
    /// If the array is empty or null, return zero,
    /// Otherwhise, the total count is the count of the current element{1}
    /// + the count of the rest of the array.
    /// </summary>
    /// <param name="items">The array of integers to count.</param>
    /// <returns>The number of elements in <paramref name="items"/>.</returns>
    public static int Count(int[] items)
    {
        if (items == null || items.Length == 0) return 0;
        // Base case.
        else if (items.Length == 1) return 1;
        // Recursive case.
        else
        {
            var segment = new ArraySegment<int>(
                items, 1, items.Length - 1).ToArray();
            return 1 + Count(segment);
        }            
    }
}
