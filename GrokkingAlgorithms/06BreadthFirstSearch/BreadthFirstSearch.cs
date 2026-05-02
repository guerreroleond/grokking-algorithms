namespace GrokkingAlgorithms._06BreadthFirstSearch;

public class BreadthFirstSearch
{
    //public static Dictionary<string, List<string>> Graph = new();

    /// <summary>
    /// [GA0601] Searches for a seller by name using Breadth-First Search.
    /// </summary>
    /// <param name="name">The name of the person to search for.</param>
    /// <returns><c>true</c> if the person is found; otherwise, <c>false</c>.</returns>
    public static bool Search(string name, Dictionary<string, List<string>> graph)
    {
        Queue<string> searchQueue = new();
        foreach (var neighbor in graph[name]) 
            searchQueue.Enqueue(neighbor);

        HashSet<string> searched = [];

        while (searchQueue.Count > 0)
        {
            var person = searchQueue.Dequeue();
            if (!searched.Contains(person))
            {
                // Fake logic to determine if the person is a seller.
                if (person.Length > 7)
                {
                    return true;
                }
                else
                {
                    foreach (var neighbor in graph[person])
                        searchQueue.Enqueue(neighbor);

                    searched.Add(person);
                }
            }
        }

        return false;
    }
}
