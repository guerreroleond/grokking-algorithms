namespace GrokkingAlgorithms._11DynamicProgramming;

public class KnapsackProblem
{
    public record Item(string Name, int Weight, int Value);
    public record KnapsackResult(int MaxValue, int TotalWeight, IReadOnlyList<Item> SelectedItems);
    public record Knapsack(int MaxValue, Dictionary<string, int> Items);

    /// <summary>
    /// [GA1101] Solves the 0/1 knapsack problem using dynamic programming.
    /// Returns the maximum value achievable within the given capacity, along with the selected items.
    /// </summary>
    /// <param name="items">The list of items available to place in the knapsack.</param>
    /// <param name="capacity">The maximum weight capacity of the knapsack.</param>
    /// <returns>A <see cref="KnapsackResult"/> containing the maximum value, total weight, and selected items.</returns>
    public static KnapsackResult Solve(IReadOnlyList<Item> items, int capacity)
    {
        ArgumentNullException.ThrowIfNull(items);

        if (capacity < 0)
            throw new ArgumentOutOfRangeException(
                nameof(capacity), "Capacity must ne non-negative.");

        // ToDo: Add for each item Weight/Value validatiions.

        int itemCount = items.Count;

        // dp[i, w] = best value using the first i items with capacity w.
        // Extra row/column represent zero items and zero capacity.
        int[,] dp = new int[itemCount + 1, capacity + 1];

        // Construct the dynamic-programming table.
        for (var i = 1; i <= itemCount; i++)
        {
            var item = items[i - 1];
            // For each item, compute the answer for every knapsack size.
            for (var w = 0; w <= capacity; w++)
            {
                // Assume we don't take the current item (for now we take the previous best).
                dp[i, w] = dp[i - 1, w];

                // Take the item if it fits.
                if(item.Weight <= w)
                {                     
                    var valueWithItem =
                        item.Value +    // Current item value +
                        // best value (already calculated) that fits in remaining capacity.
                        dp[i - 1, w - item.Weight]; 
                    dp[i, w] = Math.Max(dp[i, w], valueWithItem);
                }
            }
        }

        // Backtrack from the bottom-right cell to recover selected items.
        var selectedItems = new List<Item>();
        var remainingCapacity = capacity;

        for (var i = itemCount; i > 0; i--)
        {
            if(dp[i, remainingCapacity] != dp[i -1, remainingCapacity])
            {
                var item = items[i - 1];
                selectedItems.Add(item);
                remainingCapacity -= item.Weight;
            }
        }

        selectedItems.Reverse();

        var totalWeight = 0;
        foreach (var item in selectedItems)
            totalWeight += item.Weight;

        return new KnapsackResult(
            MaxValue: dp[itemCount, capacity],
            TotalWeight: totalWeight,
            SelectedItems: selectedItems
        );

    }
}
