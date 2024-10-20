namespace Tree
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            createTree = new Button();
            button2 = new Button();
            buttonsGroupBox = new GroupBox();
            ABRbutton = new Button();
            ARBbutton = new Button();
            RABbutton = new Button();
            panel = new Panel();
            resultBox = new GroupBox();
            threadingInfo = new Label();
            ABR_res_label = new Label();
            ARB_res_label = new Label();
            RAB_res_label = new Label();
            DeleteButton = new Button();
            buttonsGroupBox.SuspendLayout();
            resultBox.SuspendLayout();
            SuspendLayout();
            // 
            // createTree
            // 
            createTree.Location = new Point(0, 12);
            createTree.Name = "createTree";
            createTree.Size = new Size(178, 50);
            createTree.TabIndex = 0;
            createTree.Text = "Ввести дерево";
            createTree.UseVisualStyleBackColor = true;
            createTree.Click += createTree_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 362);
            button2.Name = "button2";
            button2.Size = new Size(178, 50);
            button2.TabIndex = 1;
            button2.Text = "Выполнить прошивку";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonsGroupBox
            // 
            buttonsGroupBox.Controls.Add(ABRbutton);
            buttonsGroupBox.Controls.Add(ARBbutton);
            buttonsGroupBox.Controls.Add(RABbutton);
            buttonsGroupBox.Location = new Point(0, 124);
            buttonsGroupBox.Name = "buttonsGroupBox";
            buttonsGroupBox.Size = new Size(174, 232);
            buttonsGroupBox.TabIndex = 5;
            buttonsGroupBox.TabStop = false;
            buttonsGroupBox.Text = "Обходы";
            // 
            // ABRbutton
            // 
            ABRbutton.Location = new Point(9, 160);
            ABRbutton.Name = "ABRbutton";
            ABRbutton.Size = new Size(159, 61);
            ABRbutton.TabIndex = 2;
            ABRbutton.Text = "ABR";
            ABRbutton.UseVisualStyleBackColor = true;
            ABRbutton.Click += ABRbutton_Click;
            // 
            // ARBbutton
            // 
            ARBbutton.Location = new Point(9, 93);
            ARBbutton.Name = "ARBbutton";
            ARBbutton.Size = new Size(159, 61);
            ARBbutton.TabIndex = 1;
            ARBbutton.Text = "ARB";
            ARBbutton.UseVisualStyleBackColor = true;
            ARBbutton.Click += ARBbutton_Click;
            // 
            // RABbutton
            // 
            RABbutton.Location = new Point(9, 26);
            RABbutton.Name = "RABbutton";
            RABbutton.Size = new Size(159, 61);
            RABbutton.TabIndex = 0;
            RABbutton.Text = "RAB";
            RABbutton.UseVisualStyleBackColor = true;
            RABbutton.Click += RABbutton_Click;
            // 
            // panel
            // 
            panel.Location = new Point(178, 0);
            panel.Name = "panel";
            panel.Size = new Size(1004, 429);
            panel.TabIndex = 6;
            panel.Paint += panel_Paint;
            // 
            // resultBox
            // 
            resultBox.Controls.Add(threadingInfo);
            resultBox.Controls.Add(ABR_res_label);
            resultBox.Controls.Add(ARB_res_label);
            resultBox.Controls.Add(RAB_res_label);
            resultBox.Location = new Point(0, 435);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(1182, 118);
            resultBox.TabIndex = 7;
            resultBox.TabStop = false;
            resultBox.Text = "Результаты обходов";
            // 
            // threadingInfo
            // 
            threadingInfo.AutoSize = true;
            threadingInfo.Font = new Font("Segoe UI", 7F);
            threadingInfo.Location = new Point(9, 91);
            threadingInfo.Name = "threadingInfo";
            threadingInfo.Size = new Size(38, 15);
            threadingInfo.TabIndex = 3;
            threadingInfo.Text = "label4";
            // 
            // ABR_res_label
            // 
            ABR_res_label.AutoSize = true;
            ABR_res_label.Font = new Font("Segoe UI", 7F);
            ABR_res_label.Location = new Point(9, 70);
            ABR_res_label.Name = "ABR_res_label";
            ABR_res_label.Size = new Size(38, 15);
            ABR_res_label.TabIndex = 2;
            ABR_res_label.Text = "label3";
            // 
            // ARB_res_label
            // 
            ARB_res_label.AutoSize = true;
            ARB_res_label.Font = new Font("Segoe UI", 7F);
            ARB_res_label.Location = new Point(9, 48);
            ARB_res_label.Name = "ARB_res_label";
            ARB_res_label.Size = new Size(38, 15);
            ARB_res_label.TabIndex = 1;
            ARB_res_label.Text = "label2";
            // 
            // RAB_res_label
            // 
            RAB_res_label.AutoSize = true;
            RAB_res_label.Font = new Font("Segoe UI", 7.7F);
            RAB_res_label.Location = new Point(9, 23);
            RAB_res_label.Name = "RAB_res_label";
            RAB_res_label.Size = new Size(43, 17);
            RAB_res_label.TabIndex = 0;
            RAB_res_label.Text = "label1";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(0, 68);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(178, 50);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Удалить элемент";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(DeleteButton);
            Controls.Add(buttonsGroupBox);
            Controls.Add(resultBox);
            Controls.Add(panel);
            Controls.Add(button2);
            Controls.Add(createTree);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1200, 600);
            MinimumSize = new Size(1200, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Дерево двоичного поиска";
            buttonsGroupBox.ResumeLayout(false);
            resultBox.ResumeLayout(false);
            resultBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button createTree;
        private Button button2;
        private GroupBox buttonsGroupBox;
        private Button ABRbutton;
        private Button ARBbutton;
        private Button RABbutton;
        private Panel panel;
        private GroupBox resultBox;
        private Label ABR_res_label;
        private Label ARB_res_label;
        private Label RAB_res_label;
        private Button DeleteButton;
        private Label threadingInfo;
    }
}
