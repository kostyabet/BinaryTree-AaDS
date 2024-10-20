namespace Tree
{
    public partial class CreateTreeForm : Form
    {
        private Tree.BinaryTree.BinaryTree tree {  get; set; }
        public CreateTreeForm(Tree.BinaryTree.BinaryTree tree)
        {
            InitializeComponent();
            this.tree = tree;
        }
        private void applyButton_Click(object sender, EventArgs e)
        {
            string input = inputNodes.Text.ToString();
            string[] nodes = input.Split(' ');
            List<int> intNodes = new List<int>();
            for (int i = 0; i < nodes.Length; i++) 
            {
                try
                {
                    int cur = int.Parse(nodes[i]);
                    intNodes.Add(cur);
                }
                catch { }
            }
            tree.InsertRange(intNodes.ToArray());
            this.Close();
        }
    }
}
