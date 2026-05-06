namespace GrokkingAlgorithms._07Trees;

public class RecursiveDepthFirstSearch
{
    /// <summary>
    /// [GA0702] Prints all files in the directory tree 
    /// starting from the given root node using Depth-First Search recursively.
    /// </summary>
    /// <param name="root">The root node to start traversal from.</param>
    public static void PrintFiles(FileDirNode root)
    {
        foreach(var node in root.Childs)
        {
            if (node.IsFile)
                Console.WriteLine(node.Name);
            else
                PrintFiles(node);
        }
    }
}
