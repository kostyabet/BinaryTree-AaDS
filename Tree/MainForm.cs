namespace Tree
{
    public partial class MainForm : Form
    {
        public Tree.BinaryTree.BinaryTree tree { get; private set; }
        public MainForm()
        {
            InitializeComponent();
            tree = new Tree.BinaryTree.BinaryTree();
            RAB_res_label.Text = "RAB: ";
            ARB_res_label.Text = "ARB: ";
            ABR_res_label.Text = "ABR: ";
            threadingInfo.Text = "Узлы имеющие прошивку: ";
        }

        private void createTree_Click(object sender, EventArgs e)
        {
            tree = new Tree.BinaryTree.BinaryTree();
            CreateTreeForm createTreeForm = new CreateTreeForm(tree);
            createTreeForm.ShowDialog();
            panel.Invalidate();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            tree.DrawTree(e.Graphics, panel.Width / 2);
        }

        private async void RABbutton_Click(object sender, EventArgs e)
        {
            tree.ResetThreadStatus();
            tree.RAB_result = string.Empty;
            await tree.RAB(tree._root, panel);
            RAB_res_label.Text = "RAB: " + tree.RAB_result;
            tree.ResetColors(tree._root, panel);
        }

        private async void ARBbutton_Click(object sender, EventArgs e)
        {
            tree.ResetThreadStatus();
            tree.ARB_result = string.Empty;
            await tree.ARB(tree._root, panel);
            ARB_res_label.Text = "ARB: " + tree.ARB_result;
            tree.ResetColors(tree._root, panel);
        }

        private async void ABRbutton_Click(object sender, EventArgs e)
        {
            tree.ResetThreadStatus();
            tree.ABR_result = string.Empty;
            await tree.ABR(tree._root, panel);
            ABR_res_label.Text = "ABR: " + tree.ABR_result;
            tree.ResetColors(tree._root, panel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tree.threadTree();
            threadingInfo.Text = "Узлы имеющие прошивку: " + tree.threadedNodes;
            panel.Invalidate();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteItemForm createDeleteItemForm = new DeleteItemForm(tree);
            createDeleteItemForm.ShowDialog();
            panel.Invalidate();
        }
    }
}
