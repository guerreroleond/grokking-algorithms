namespace GrokkingAlgorithms._07Trees;

public class FileDirectories
{
    /// <summary>
    /// [GA0701] Prints all files in the directory tree starting from the given root node.
    /// Visit every node in the tree.
    /// If this node is a file, print out its name.
    /// If the node is a folder, add it to a queue of folders to search for files.
    /// </summary>
    /// <param name="root">The root node to start traversal from.</param>
    /// <param name="tree">The dictionary representing the tree structure, mapping each node to its children.</param>
    public static void PrintFiles(FileDirNode root, Dictionary<FileDirNode, List<FileDirNode>> tree)
    {
        Queue<FileDirNode> searchQueue = new();
        foreach (var children in tree[root])
            searchQueue.Enqueue(children);

        while(searchQueue.Count > 0)
        {
            var node = searchQueue.Dequeue();
            if (node.IsFile)
                Console.WriteLine(node.Name);
            else
            {
                foreach (var children in tree[node])
                    searchQueue.Enqueue(children);
            }
        }
    }
}
