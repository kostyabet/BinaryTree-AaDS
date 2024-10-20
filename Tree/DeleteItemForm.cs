using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public partial class DeleteItemForm : Form
    {
        private Tree.BinaryTree.BinaryTree tree { get; set; }
        public DeleteItemForm(Tree.BinaryTree.BinaryTree tree)
        {
            InitializeComponent();
            this.tree = tree;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            string[] elements = deleteItemsBox.Text.ToString().Split(new[] { ' ' });
            List<int> deleteNodes = new List<int>();
            for (int i = 0; i < elements.Length; i++) 
            { 
                try
                {
                    int cur = int.Parse(elements[i]);
                    deleteNodes.Add(cur);
                }
                catch { }
            }
            tree.DeleteRange(deleteNodes.ToArray());
            this.Close();
        }
    }
}
