namespace GrokkingAlgorithms._10GreedyAlgorithms;

public class SetCoveringProblem
{
    /// <summary>
    /// [GA1001] Returns the set of stations that covers all the states needed using a greedy approach.
    /// </summary>
    /// <param name="statesNeeded">The set of states that need to be covered.</param>
    /// <param name="stations">A dictionary mapping station names to the set of states they cover.</param>
    /// <returns>A <see cref="HashSet{T}"/> of station names that covers all required states.</returns>
    public static HashSet<string> GetStations(
        HashSet<string> statesNeeded, Dictionary<string, HashSet<string>> stations)
    {
        HashSet<string> finalStations = [];

        while (statesNeeded.Count > 0)
        {
            string? bestStation = null;
            var statesCovered = new HashSet<string>();

            foreach (var (station, statesForStation) in stations)
            {
                var covered = new HashSet<string>(statesNeeded);
                covered.IntersectWith(statesForStation);

                if (covered.Count > statesCovered.Count)
                {
                    bestStation = station;
                    statesCovered = covered;
                }
            }

            statesNeeded.ExceptWith(statesCovered);
            finalStations.Add(bestStation);
        }

        return finalStations;
    }
}
