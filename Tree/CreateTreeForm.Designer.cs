namespace Tree
{
    partial class CreateTreeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTreeForm));
            applyButton = new Button();
            conditionLabel = new Label();
            inputNodes = new TextBox();
            SuspendLayout();
            // 
            // applyButton
            // 
            applyButton.Location = new Point(12, 112);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(304, 29);
            applyButton.TabIndex = 0;
            applyButton.Text = "Сформировать дерево";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // conditionLabel
            // 
            conditionLabel.Location = new Point(12, 9);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new Size(304, 40);
            conditionLabel.TabIndex = 1;
            conditionLabel.Text = "Введите элементы дерева через пробел и нажмите кнопку \"Сформировать дерево\"";
            // 
            // inputNodes
            // 
            inputNodes.Location = new Point(12, 52);
            inputNodes.Multiline = true;
            inputNodes.Name = "inputNodes";
            inputNodes.Size = new Size(304, 54);
            inputNodes.TabIndex = 2;
            // 
            // CreateTreeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 153);
            Controls.Add(inputNodes);
            Controls.Add(conditionLabel);
            Controls.Add(applyButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateTreeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ввод дерева";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button applyButton;
        private Label conditionLabel;
        private TextBox inputNodes;
    }
}