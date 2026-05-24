using System.Text;

namespace GrokkingAlgorithms._07Trees;

public class HuffmanCoding
{
    /// <summary>
    /// [GA0703] Decodes a Huffman-encoded bit stream using the given binary tree.
    /// Traverses the tree bit by bit (false = go left, true = go right); when a leaf node
    /// is reached, appends its Value to the result and restarts from the root.
    /// </summary>
    /// <param name="root">The root of the Huffman tree.</param>
    /// <param name="bitMask">The encoded bit stream as a list of booleans (index 0 = first bit).</param>
    /// <returns>The decoded string.</returns>
    public static string Decode(BTreeNode root, List<bool> bitMask)
    {
        var result = new StringBuilder();
        BTreeNode? currentNode = root;
        int i = 0;
        bool bitValue = bitMask[i];

        while (currentNode != null
            && i <= bitMask.Count)
        {
            if (currentNode.LeftNode == null
            && currentNode.RightNode == null)
            {// Leaf node.
                result.Append(currentNode.Value);
                currentNode = root;
            }
            else
            {
                if (bitValue)
                {// Right
                    currentNode = currentNode.RightNode;
                }
                else
                {// Left.
                    currentNode = currentNode.LeftNode;
                }
                i++;
                if (i < bitMask.Count)
                {
                    bitValue = bitMask[i];
                }                
            }
        }

        return result.ToString();
    }

    public static void PrintBitMask(ulong bitMask)
    {
        // 1. Automatically calculate the total number of bits for this type
        int totalBits = sizeof(ulong) * 8; // Evaluates to 32

        // 2. Loop from the highest index (leftmost) down to 0 (rightmost)
        for (int i = totalBits - 1; i >= 0; i--)
        {
            // Shift the bit at index 'i' down to the 1st position, then mask it
            bool bitValue = ((bitMask >> i) & 1) == 1;
            
            Console.Write(bitValue ? "1" : "0");
        }
    }
}
