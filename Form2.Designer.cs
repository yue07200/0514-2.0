namespace 日曆
{
    partial class Form2
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
            addAccountButton = new Button();
            balanceQueryButton = new Button();
            label1 = new Label();
            accountsDataGridView = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            AmountColumn = new DataGridViewTextBoxColumn();
            accountNameTextBox = new TextBox();
            initialBalanceTextBox = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)accountsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // addAccountButton
            // 
            addAccountButton.Location = new Point(570, 273);
            addAccountButton.Name = "addAccountButton";
            addAccountButton.Size = new Size(112, 34);
            addAccountButton.TabIndex = 0;
            addAccountButton.Text = "添加賬戶";
            addAccountButton.UseVisualStyleBackColor = true;
            addAccountButton.Click += addAccountButton_Click;
            // 
            // balanceQueryButton
            // 
            balanceQueryButton.Location = new Point(128, 385);
            balanceQueryButton.Name = "balanceQueryButton";
            balanceQueryButton.Size = new Size(112, 34);
            balanceQueryButton.TabIndex = 2;
            balanceQueryButton.Text = "查詢餘額";
            balanceQueryButton.UseVisualStyleBackColor = true;
            balanceQueryButton.Click += balanceQueryButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(441, 108);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 3;
            label1.Text = "日常開銷名稱：";
            // 
            // accountsDataGridView
            // 
            accountsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountsDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, AmountColumn });
            accountsDataGridView.Location = new Point(33, 25);
            accountsDataGridView.Name = "accountsDataGridView";
            accountsDataGridView.RowHeadersWidth = 62;
            accountsDataGridView.RowTemplate.Height = 32;
            accountsDataGridView.Size = new Size(363, 330);
            accountsDataGridView.TabIndex = 4;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "開銷名稱";
            NameColumn.MinimumWidth = 8;
            NameColumn.Name = "NameColumn";
            NameColumn.Width = 150;
            // 
            // AmountColumn
            // 
            AmountColumn.HeaderText = "金額";
            AmountColumn.MinimumWidth = 8;
            AmountColumn.Name = "AmountColumn";
            AmountColumn.Width = 150;
            // 
            // accountNameTextBox
            // 
            accountNameTextBox.Location = new Point(618, 105);
            accountNameTextBox.Name = "accountNameTextBox";
            accountNameTextBox.Size = new Size(150, 30);
            accountNameTextBox.TabIndex = 5;
            // 
            // initialBalanceTextBox
            // 
            initialBalanceTextBox.Location = new Point(618, 176);
            initialBalanceTextBox.Name = "initialBalanceTextBox";
            initialBalanceTextBox.Size = new Size(150, 30);
            initialBalanceTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 179);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 10;
            label3.Text = "初始餘額:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(468, 38);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 30);
            dateTimePicker1.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(initialBalanceTextBox);
            Controls.Add(accountNameTextBox);
            Controls.Add(accountsDataGridView);
            Controls.Add(label1);
            Controls.Add(balanceQueryButton);
            Controls.Add(addAccountButton);
            Name = "Form2";
            Text = "Form2";
          
            ((System.ComponentModel.ISupportInitialize)accountsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addAccountButton;
        private Button balanceQueryButton;
        private Label label1;
        private DataGridView accountsDataGridView;
        private TextBox accountNameTextBox;
        private TextBox initialBalanceTextBox;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn AmountColumn;
    }
}