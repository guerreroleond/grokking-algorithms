namespace GrokkingAlgorithms._07Trees;

public class FileDirNode
{
    public string Name { get; set; } = string.Empty;
    public bool IsFile { get; set; }

    public List<FileDirNode>? Childs = null;
}
