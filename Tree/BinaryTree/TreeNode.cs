namespace Tree.TreeNode;
public class TreeNode
{
    public int Value;
    public TreeNode? Left;
    public TreeNode? Right;

    public bool isThread;
    public TreeNode? threadLink;

    public Brush textColor;
    public Brush backgroundColor;
    public Pen borderColor;

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
        threadLink = null;
        isThread = false;
        textColor = Brushes.Black;
        backgroundColor = Brushes.LightBlue;
        borderColor = Pens.Black;
    }
}