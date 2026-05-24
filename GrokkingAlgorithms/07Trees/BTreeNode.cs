namespace GrokkingAlgorithms._07Trees;

public class BTreeNode
{
    public string Value { get; set; } = string.Empty;
    public BTreeNode? LeftNode { get; set; }
    public BTreeNode? RightNode { get; set; }
}
