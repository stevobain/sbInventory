namespace sbInventory
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            PartID = new DataGridViewTextBoxColumn();
            PartName = new DataGridViewTextBoxColumn();
            PartInventory = new DataGridViewTextBoxColumn();
            PartPrice = new DataGridViewTextBoxColumn();
            PartMin = new DataGridViewTextBoxColumn();
            PartMax = new DataGridViewTextBoxColumn();
            label2 = new Label();
            mainSearchPartBtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            mainSearchProductBtn = new Button();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProdName = new DataGridViewTextBoxColumn();
            ProductInventory = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            ProductMin = new DataGridViewTextBoxColumn();
            ProductMax = new DataGridViewTextBoxColumn();
            mainAddPartBtn = new Button();
            mainModifyPartBtn = new Button();
            mainDeletePartBtn = new Button();
            mainAddProdBtn = new Button();
            mainModifyProdBtn = new Button();
            mainDeleteProdBtn = new Button();
            mainExitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management System";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PartID, PartName, PartInventory, PartPrice, PartMin, PartMax });
            dataGridView1.Location = new Point(12, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(381, 242);
            dataGridView1.TabIndex = 1;
            // 
            // PartID
            // 
            PartID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartID.HeaderText = "Part ID";
            PartID.Name = "PartID";
            PartID.Width = 67;
            // 
            // PartName
            // 
            PartName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartName.HeaderText = "Name";
            PartName.Name = "PartName";
            PartName.Width = 64;
            // 
            // PartInventory
            // 
            PartInventory.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartInventory.HeaderText = "Inventory";
            PartInventory.Name = "PartInventory";
            PartInventory.Width = 82;
            // 
            // PartPrice
            // 
            PartPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartPrice.HeaderText = "Price";
            PartPrice.Name = "PartPrice";
            PartPrice.Width = 58;
            // 
            // PartMin
            // 
            PartMin.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartMin.HeaderText = "Min";
            PartMin.Name = "PartMin";
            PartMin.Width = 53;
            // 
            // PartMax
            // 
            PartMax.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartMax.HeaderText = "Max";
            PartMax.Name = "PartMax";
            PartMax.Width = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Parts";
            // 
            // mainSearchPartBtn
            // 
            mainSearchPartBtn.AutoSize = true;
            mainSearchPartBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainSearchPartBtn.Location = new Point(133, 60);
            mainSearchPartBtn.Name = "mainSearchPartBtn";
            mainSearchPartBtn.Size = new Size(52, 25);
            mainSearchPartBtn.TabIndex = 3;
            mainSearchPartBtn.Text = "Search";
            mainSearchPartBtn.UseVisualStyleBackColor = true;
            mainSearchPartBtn.Click += mainSearchPartBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(597, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 23);
            textBox2.TabIndex = 8;
            // 
            // mainSearchProductBtn
            // 
            mainSearchProductBtn.AutoSize = true;
            mainSearchProductBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainSearchProductBtn.Location = new Point(539, 60);
            mainSearchProductBtn.Name = "mainSearchProductBtn";
            mainSearchProductBtn.Size = new Size(52, 25);
            mainSearchProductBtn.TabIndex = 7;
            mainSearchProductBtn.Text = "Search";
            mainSearchProductBtn.UseVisualStyleBackColor = true;
            mainSearchProductBtn.Click += mainSearchProductBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 71);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Products";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProdName, ProductInventory, ProductPrice, ProductMin, ProductMax });
            dataGridView2.Location = new Point(399, 89);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.ScrollBars = ScrollBars.Vertical;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(400, 242);
            dataGridView2.TabIndex = 5;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductID.HeaderText = "Product ID";
            ProductID.Name = "ProductID";
            ProductID.Width = 88;
            // 
            // ProdName
            // 
            ProdName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProdName.HeaderText = "Name";
            ProdName.Name = "ProdName";
            ProdName.Width = 64;
            // 
            // ProductInventory
            // 
            ProductInventory.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductInventory.HeaderText = "Inventory";
            ProductInventory.Name = "ProductInventory";
            ProductInventory.Width = 82;
            // 
            // ProductPrice
            // 
            ProductPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductPrice.HeaderText = "Price";
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Width = 58;
            // 
            // ProductMin
            // 
            ProductMin.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductMin.HeaderText = "Min";
            ProductMin.Name = "ProductMin";
            ProductMin.Width = 53;
            // 
            // ProductMax
            // 
            ProductMax.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProductMax.HeaderText = "Max";
            ProductMax.Name = "ProductMax";
            ProductMax.Width = 55;
            // 
            // mainAddPartBtn
            // 
            mainAddPartBtn.AutoSize = true;
            mainAddPartBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainAddPartBtn.Location = new Point(237, 337);
            mainAddPartBtn.Name = "mainAddPartBtn";
            mainAddPartBtn.Size = new Size(39, 25);
            mainAddPartBtn.TabIndex = 9;
            mainAddPartBtn.Text = "Add\r\n";
            mainAddPartBtn.UseVisualStyleBackColor = true;
            mainAddPartBtn.Click += mainAddPartBtn_Click;
            // 
            // mainModifyPartBtn
            // 
            mainModifyPartBtn.AutoSize = true;
            mainModifyPartBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainModifyPartBtn.Location = new Point(282, 337);
            mainModifyPartBtn.Name = "mainModifyPartBtn";
            mainModifyPartBtn.Size = new Size(55, 25);
            mainModifyPartBtn.TabIndex = 10;
            mainModifyPartBtn.Text = "Modify";
            mainModifyPartBtn.UseVisualStyleBackColor = true;
            mainModifyPartBtn.Click += mainModifyPartBtn_Click;
            // 
            // mainDeletePartBtn
            // 
            mainDeletePartBtn.AutoSize = true;
            mainDeletePartBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainDeletePartBtn.Location = new Point(343, 337);
            mainDeletePartBtn.Name = "mainDeletePartBtn";
            mainDeletePartBtn.Size = new Size(50, 25);
            mainDeletePartBtn.TabIndex = 11;
            mainDeletePartBtn.Text = "Delete";
            mainDeletePartBtn.UseVisualStyleBackColor = true;
            mainDeletePartBtn.Click += mainDeletePartBtn_Click;
            // 
            // mainAddProdBtn
            // 
            mainAddProdBtn.AutoSize = true;
            mainAddProdBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainAddProdBtn.Location = new Point(643, 337);
            mainAddProdBtn.Name = "mainAddProdBtn";
            mainAddProdBtn.Size = new Size(39, 25);
            mainAddProdBtn.TabIndex = 12;
            mainAddProdBtn.Text = "Add";
            mainAddProdBtn.UseVisualStyleBackColor = true;
            mainAddProdBtn.Click += mainAddProdBtn_Click;
            // 
            // mainModifyProdBtn
            // 
            mainModifyProdBtn.AutoSize = true;
            mainModifyProdBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainModifyProdBtn.Location = new Point(688, 337);
            mainModifyProdBtn.Name = "mainModifyProdBtn";
            mainModifyProdBtn.Size = new Size(55, 25);
            mainModifyProdBtn.TabIndex = 13;
            mainModifyProdBtn.Text = "Modify";
            mainModifyProdBtn.UseVisualStyleBackColor = true;
            mainModifyProdBtn.Click += mainModifyProdBtn_Click;
            // 
            // mainDeleteProdBtn
            // 
            mainDeleteProdBtn.AutoSize = true;
            mainDeleteProdBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainDeleteProdBtn.Location = new Point(749, 337);
            mainDeleteProdBtn.Name = "mainDeleteProdBtn";
            mainDeleteProdBtn.Size = new Size(50, 25);
            mainDeleteProdBtn.TabIndex = 14;
            mainDeleteProdBtn.Text = "Delete";
            mainDeleteProdBtn.UseVisualStyleBackColor = true;
            mainDeleteProdBtn.Click += mainDeleteProdBtn_Click;
            // 
            // mainExitBtn
            // 
            mainExitBtn.AutoSize = true;
            mainExitBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainExitBtn.Location = new Point(762, 368);
            mainExitBtn.Name = "mainExitBtn";
            mainExitBtn.Size = new Size(36, 25);
            mainExitBtn.TabIndex = 15;
            mainExitBtn.Text = "Exit";
            mainExitBtn.UseVisualStyleBackColor = true;
            mainExitBtn.Click += mainExitBtn_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(810, 402);
            Controls.Add(mainExitBtn);
            Controls.Add(mainDeleteProdBtn);
            Controls.Add(mainModifyProdBtn);
            Controls.Add(mainAddProdBtn);
            Controls.Add(mainDeletePartBtn);
            Controls.Add(mainModifyPartBtn);
            Controls.Add(mainAddPartBtn);
            Controls.Add(textBox2);
            Controls.Add(mainSearchProductBtn);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(textBox1);
            Controls.Add(mainSearchPartBtn);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "MainScreen";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button mainSearchPartBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button mainSearchProductBtn;
        private Label label3;
        private DataGridView dataGridView2;
        private Button mainAddPartBtn;
        private Button mainModifyPartBtn;
        private Button mainDeletePartBtn;
        private Button mainAddProdBtn;
        private Button mainModifyProdBtn;
        private Button mainDeleteProdBtn;
        private Button mainExitBtn;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn PartName;
        private DataGridViewTextBoxColumn PartInventory;
        private DataGridViewTextBoxColumn PartPrice;
        private DataGridViewTextBoxColumn PartMin;
        private DataGridViewTextBoxColumn PartMax;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProdName;
        private DataGridViewTextBoxColumn ProductInventory;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductMin;
        private DataGridViewTextBoxColumn ProductMax;
    }
}
