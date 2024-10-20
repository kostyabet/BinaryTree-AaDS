namespace Tree
{
    partial class DeleteItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteItemForm));
            ApplyButton = new Button();
            DeleteLabel = new Label();
            deleteItemsBox = new TextBox();
            SuspendLayout();
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(12, 65);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(611, 39);
            ApplyButton.TabIndex = 0;
            ApplyButton.Text = "Подтвердить";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // DeleteLabel
            // 
            DeleteLabel.AutoSize = true;
            DeleteLabel.Location = new Point(12, 9);
            DeleteLabel.Name = "DeleteLabel";
            DeleteLabel.Size = new Size(611, 20);
            DeleteLabel.TabIndex = 1;
            DeleteLabel.Text = "Напишите через пробел элементы, которые хотите удалить и нажмите \"Подтвердить\"";
            // 
            // deleteItemsBox
            // 
            deleteItemsBox.Location = new Point(12, 32);
            deleteItemsBox.Name = "deleteItemsBox";
            deleteItemsBox.Size = new Size(611, 27);
            deleteItemsBox.TabIndex = 2;
            // 
            // DeleteItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 115);
            Controls.Add(deleteItemsBox);
            Controls.Add(DeleteLabel);
            Controls.Add(ApplyButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Удаление элементов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ApplyButton;
        private Label DeleteLabel;
        private TextBox deleteItemsBox;
    }
}