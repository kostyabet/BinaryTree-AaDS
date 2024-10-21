using System.Xml.Linq;

namespace Tree.BinaryTree;
public class BinaryTree
{
	public Tree.TreeNode.TreeNode? _root = null;
    public string ABR_result { get; set; }
    public string ARB_result { get; set; }
    public string RAB_result { get; set; }
    public string threadedNodes { get; set; }
    public int X { get; set; }
    public int VertOffset { get; set; }
    public BinaryTree() {
        ABR_result = string.Empty;
        ARB_result = string.Empty;
        RAB_result = string.Empty;
        threadedNodes = string.Empty;
        VertOffset = 3;
    }
    public void Insert(int value)
	{
        if (_root == null)
        {
            _root = new Tree.TreeNode.TreeNode(value);
        }
        else
        {
            InsertValue(value, _root);
        }
    }
    public void InsertRange(params int[] values)
    {
        foreach (var value in values)
        {
            Insert(value);
        }
    }
    public void Delete(int value)
    {
        deleteNode(value, _root);
    }
    public void DeleteRange(params int[] values)
    {
        foreach (var value in values)
        {
            Delete(value);
        }
    }
    private Tree.TreeNode.TreeNode? deleteNode(int value, Tree.TreeNode.TreeNode? node)
    {
        if (node == null) return null;
        

        if (value < node.Value)
        {
            node.Left = deleteNode(value, node.Left);
        }
        else if (value > node.Value)
        {
            node.Right = deleteNode(value, node.Right);
        }
        else
        {
            if (node.Left == null && node.Right == null)
            {
                return null;
            }
            else if (node.Left == null)
            {
                return node.Right;
            }
            else if (node.Right == null)
            {

                return node.Left;
            }
            else
            {
                Tree.TreeNode.TreeNode successor = findMin(node.Right);
                node.Value = successor.Value;
                node.Right = deleteNode(successor.Value, node.Right);
            }
        }
        return node;
    }
    private Tree.TreeNode.TreeNode findMin(Tree.TreeNode.TreeNode root)
    {
        if (root.Left != null)
        {
            root = root.Left;
        }

        return root;
    }
    public async Task ABR(Tree.TreeNode.TreeNode? node, Panel panel)
    {
        if (node == null)
        {

            ABR_result += "N ";
            return;
        }
        ABR_result += node.Value + " ";
        Brush Cur1 = node.backgroundColor;
        node.backgroundColor = Cur1 == Brushes.PaleGreen ? Brushes.PaleVioletRed : Brushes.LightPink;
        panel.Invalidate();
        await WaitForColorChange(panel, 1000);
        node.backgroundColor = Cur1;
        panel.Invalidate();
        await ABR(node.Left, panel);
        ABR_result += node.Value + " ";
        Brush Cur2 = node.backgroundColor;
        node.backgroundColor = Cur2 == Brushes.PaleGreen ? Brushes.PaleVioletRed : Brushes.LightPink;
        panel.Invalidate();
        await WaitForColorChange(panel, 1000);
        node.backgroundColor = Cur2;
        await ABR(node.Right, panel);
        ABR_result += "(" + node.Value + ") ";
        node.backgroundColor = Brushes.LightPink;
        panel.Invalidate();
        await WaitForColorChange(panel, 1000);
        node.backgroundColor = Brushes.PaleGreen;
        panel.Invalidate();
    }
    public async Task ARB(Tree.TreeNode.TreeNode? node, Panel panel)
    {
        if (node == null)
        {
            ARB_result += "N ";
            return;
        }

        ARB_result += node.Value + " ";
        Brush Cur1 = node.backgroundColor;
        node.backgroundColor = Cur1 == Brushes.PaleGreen ? Brushes.PaleVioletRed : Brushes.LightPink;
        panel.Invalidate();
        await WaitForColorChange(panel, 1000);
        node.backgroundColor = Cur1;
        panel.Invalidate();
        await ARB(node.Left, panel);
        ARB_result += "(" + node.Value + ") ";
        node.backgroundColor = Brushes.LightPink;
        panel.Invalidate();
        await WaitForColorChange(panel, 1000);
        node.backgroundColor = Brushes.PaleGreen;
        await ARB(node.Right, panel);
        ARB_result += node.Value + " ";
        Brush Cur2 = node.backgroundColor;
        node.backgroundColor = Cur2 == Brushes.PaleGreen ? Brushes.PaleVioletRed : Brushes.LightPink;
        panel.Invalidate();
        await WaitForColorChange(panel, 1000);
        node.backgroundColor = Cur2;
        panel.Invalidate();
    }
    public async Task RAB(Tree.TreeNode.TreeNode? node, Panel panel)
    {
        if (node == null)
        {
            RAB_result += "N ";
            return;
        }
        RAB_result += "(" + node.Value + ") ";
        node.backgroundColor = Brushes.LightPink;
        panel.Invalidate();
        await WaitForColorChange(panel, 1000);
        node.backgroundColor = Brushes.PaleGreen;
        panel.Invalidate();
        await RAB(node.Left, panel);
        RAB_result += node.Value + " ";
        Brush Cur1 = node.backgroundColor;
        node.backgroundColor = Cur1 == Brushes.PaleGreen ? Brushes.PaleVioletRed : Brushes.LightPink;
        panel.Invalidate();
        await WaitForColorChange(panel, 1000);
        node.backgroundColor = Cur1;
        await RAB(node.Right, panel);
        RAB_result += node.Value + " ";
        Brush Cur2 = node.backgroundColor;
        node.backgroundColor = Cur2 == Brushes.PaleGreen ? Brushes.PaleVioletRed : Brushes.LightPink;
        panel.Invalidate();
        await WaitForColorChange(panel, 1000);
        node.backgroundColor = Cur2;
        panel.Invalidate();
    }
    public void ResetColors(Tree.TreeNode.TreeNode? node, Panel panel)
    {
        if (node == null)
        {
            return;
        }
        node.backgroundColor = Brushes.LightBlue;
        panel.Invalidate();
        ResetColors(node.Left, panel);
        node.backgroundColor = Brushes.LightBlue;
        panel.Invalidate();
        ResetColors(node.Right, panel);
        node.backgroundColor = Brushes.LightBlue;
        panel.Invalidate();
    }

    public void threadTree()
    {
        threadedNodes = string.Empty;
        
        Tree.TreeNode.TreeNode? tempNode = null;
        ARBtemp(_root);
        void ARBtemp(Tree.TreeNode.TreeNode? node)
        {
            if (node == null)
            {
                return;
            }
            ARBtemp(node.Left);
            if (tempNode != null)
            {
                tempNode.isThread = true;
                tempNode.threadLink = node;
                tempNode = null;
            }
            if (node.Right == null) 
            {
                threadedNodes += " " + node.Value;
                tempNode = node;
            }
            ARBtemp(node.Right);
        }
        if (tempNode != null)
        {
            tempNode.isThread = true;
            tempNode.threadLink = _root;
        }
    }
    public void DrawTree(Graphics g, int x)
    {
        X = x;
        DrawNodeTree(g, _root, x, 20, 210);
    }

    private void DrawNodeTree(Graphics g, Tree.TreeNode.TreeNode node, int x, int y, int offset)
    {
        if (node == null) return;
        g.FillEllipse(node.backgroundColor, x, y, 30, 30);
        g.DrawEllipse(node.borderColor, x, y, 30, 30);
        g.DrawString(node.Value.ToString(), new Font("Arial", 8), node.textColor, x + 3, y + 7);
        if (node.Left != null)
        {
            g.DrawLine(node.borderColor, x + 15, y + 30, x - offset + 15, y + 70);
            DrawNodeTree(g, node.Left, x - offset, y + 70, offset / 2);
        }
        if (node.Right != null)
        {
            g.DrawLine(node.borderColor, x + 15, y + 30, x + offset + 15, y + 70);
            DrawNodeTree(g, node.Right, x + offset, y + 70, offset / 2);
        }
        else if (node.isThread)
        {
            int[] coords = NodeCoords(node.threadLink.Value, X, 20, 210);
            g.DrawLine(Pens.Red, x + 18, y + 30, x + 18, y + 30 + VertOffset);
            int xTemp, yTemp;
            xTemp = x > coords[0] ? coords[0] + 3 : coords[0] - 3;
            g.DrawLine(Pens.Red, x + 18, y + 30 + VertOffset, xTemp, y + 30 + VertOffset);
            g.DrawLine(Pens.Red, xTemp, y + 30 + VertOffset, xTemp, coords[1]);
            Thread.Sleep(1000);
            VertOffset += 3;
        }
    }
    public void ResetThreadStatus()
    {
        VertOffset = 3;
        ResetThread(_root);
        void ResetThread(Tree.TreeNode.TreeNode? node)
        {
            if (node == null) return;
            node.isThread = false;
            node.threadLink = null;
            ResetThread(node.Left);
            node.isThread = false;
            node.threadLink = null;
            ResetThread(node.Right);
            node.isThread = false;
            node.threadLink = null;
        }
    }
    private int[] NodeCoords(int value, int x, int y, int offset)
    {
        int[] resCoords = { x, y };
        bool state = false;
        Search(_root, resCoords[0], resCoords[1], offset);
        void Search(Tree.TreeNode.TreeNode node, int x, int y, int offset)
        {   
            if (node == null) return;
            if (state || node.Value == value)
            {
                if (state == false)
                {
                    resCoords[0] = x;
                    resCoords[1] = y;
                }
                state = true;
                return;
            }
            if (node.Left != null && !state)
            {
                if (state || node.Value == value)
                {
                    if (state == false)
                    {
                        resCoords[0] = x;
                        resCoords[1] = y;
                    }
                    state = true;
                    return;
                }
                Search(node.Left, x - offset, y + 70, offset / 2);
            }
            if (state || node.Value == value)
            {
                if (state == false)
                {
                    resCoords[0] = x;
                    resCoords[1] = y;
                }
                state = true;
                return;
            }
            if (node.Right != null && !state) 
            {
                if (state || node.Value == value)
                {
                    if (state == false)
                    {
                        resCoords[0] = x;
                        resCoords[1] = y;
                    }
                    state = true;
                    return;
                }
                Search(node.Right, x + offset, y + 70, offset / 2);
            }
            if (state || node.Value == value)
            {
                if (state == false)
                {
                    resCoords[0] = x;
                    resCoords[1] = y;
                }
                state = true;
                return;
            }
        }
        resCoords[0] += 15;
        resCoords[1] += 30;
        return resCoords;
    }
    private void InsertValue(int value, Tree.TreeNode.TreeNode node)
    {
        if (node.Value < value)
        {
            if (node.Right == null)
            {
                node.Right = new Tree.TreeNode.TreeNode(value);
            }
            else
            {
                InsertValue(value, node.Right);
            }
        }
        else if (node.Value > value)
        {
            if (node.Left == null)
            {
                node.Left = new Tree.TreeNode.TreeNode(value);
            }
            else
            {
                InsertValue(value, node.Left);
            }
        }
    }
    private Task WaitForColorChange(Panel panel, int milliseconds)
    {
        var tcs = new TaskCompletionSource<bool>();
        var timer = new System.Timers.Timer(milliseconds);
        timer.Elapsed += (s, e) =>
        {
            timer.Stop();
            tcs.SetResult(true);
        };
        timer.AutoReset = false;
        timer.Start();
        return tcs.Task;
    }
}
