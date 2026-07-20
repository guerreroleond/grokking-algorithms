using System.Reflection;
using System.Runtime.CompilerServices;

namespace GrokkingAlgorithms._09DijkstrasAlgorithm;

public class DijkstrasAlgorithm
{
    /// <summary>
    /// [GA0901] Finds the lowest-cost path from the start node to "fin" using Dijkstra's algorithm.
    /// Repeatedly picks the lowest-cost unvisited node, updates neighbor costs and parents,
    /// and returns the total cost of the shortest path to "fin".
    /// </summary>
    /// <param name="graph">The weighted directed graph: node → (neighbor → weight).</param>
    /// <param name="costs">The current best-known cost to reach each node from the start.</param>
    /// <param name="parents">Tracks the preceding node cost for each node on the shortest path.</param>
    /// <returns>The cost of the shortest path to "fin".</returns>
    public static int GetShortestPath(
        Dictionary<string, Dictionary<string, int>> graph,
        Dictionary<string, int> costs,
        Dictionary<string, string?> parents)
    {
        var processed = new HashSet<string>();
        var node = FindLowestCostNode(costs, processed);

        while (node is not null)
        {
            var cost = costs[node];
            var neighbors = graph[node];

            foreach (var n in neighbors.Keys)
            {
                var newCost = cost + neighbors[n];
                if (costs[n] > newCost)
                {
                    costs[n] = newCost;
                    parents[n] = node;
                }
            }

            processed.Add(node);
            node = FindLowestCostNode(costs, processed);
        }

        return costs["fin"];
    }

    private static string? FindLowestCostNode(
        Dictionary<string, int> costs,
        HashSet<string> processed)
    {
        var lowestCost = int.MaxValue;
        string? lowestCostNode = null;

        foreach (var node in costs.Keys)
        {
            var cost = costs[node];
            if (cost < lowestCost
            && !processed.Contains(node))
            {
                lowestCost = cost;
                lowestCostNode = node;
            }
        }

        return lowestCostNode;
    }
}
