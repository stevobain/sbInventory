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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            ProductID = new DataGridViewTextBoxColumn();
            ProdName = new DataGridViewTextBoxColumn();
            ProductInventory = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            ProductMin = new DataGridViewTextBoxColumn();
            ProductMax = new DataGridViewTextBoxColumn();
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
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(133, 60);
            button1.Name = "button1";
            button1.Size = new Size(52, 25);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.Location = new Point(539, 60);
            button2.Name = "button2";
            button2.Size = new Size(52, 25);
            button2.TabIndex = 7;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
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
            dataGridView2.Size = new Size(400, 242);
            dataGridView2.TabIndex = 5;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.Location = new Point(237, 337);
            button3.Name = "button3";
            button3.Size = new Size(39, 25);
            button3.TabIndex = 9;
            button3.Text = "Add\r\n";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.Location = new Point(282, 337);
            button4.Name = "button4";
            button4.Size = new Size(55, 25);
            button4.TabIndex = 10;
            button4.Text = "Modify";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.Location = new Point(343, 337);
            button5.Name = "button5";
            button5.Size = new Size(50, 25);
            button5.TabIndex = 11;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.Location = new Point(643, 337);
            button6.Name = "button6";
            button6.Size = new Size(39, 25);
            button6.TabIndex = 12;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.Location = new Point(688, 337);
            button7.Name = "button7";
            button7.Size = new Size(55, 25);
            button7.TabIndex = 13;
            button7.Text = "Modify";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button8.Location = new Point(749, 337);
            button8.Name = "button8";
            button8.Size = new Size(50, 25);
            button8.TabIndex = 14;
            button8.Text = "Delete";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.AutoSize = true;
            button9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button9.Location = new Point(762, 368);
            button9.Name = "button9";
            button9.Size = new Size(36, 25);
            button9.TabIndex = 15;
            button9.Text = "Exit";
            button9.UseVisualStyleBackColor = true;
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
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(810, 402);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(textBox1);
            Controls.Add(button1);
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
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label3;
        private DataGridView dataGridView2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
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
