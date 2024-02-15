namespace sbInventory.Forms
{
    partial class ModifyProductForm
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
            cancelButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            searchTextBox = new TextBox();
            searchButton = new Button();
            label9 = new Label();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            PartID2 = new DataGridViewTextBoxColumn();
            PartName2 = new DataGridViewTextBoxColumn();
            PartInventory2 = new DataGridViewTextBoxColumn();
            PartPrice2 = new DataGridViewTextBoxColumn();
            PartMin2 = new DataGridViewTextBoxColumn();
            PartMax2 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            PartID = new DataGridViewTextBoxColumn();
            PartName = new DataGridViewTextBoxColumn();
            PartInventory = new DataGridViewTextBoxColumn();
            PartPrice = new DataGridViewTextBoxColumn();
            PartMin = new DataGridViewTextBoxColumn();
            PartMax = new DataGridViewTextBoxColumn();
            minTextBox = new TextBox();
            maxTextBox = new TextBox();
            priceTextBox = new TextBox();
            inventoryTextBox = new TextBox();
            nameTextBox = new TextBox();
            idTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.AutoSize = true;
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Location = new Point(563, 495);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(53, 25);
            cancelButton.TabIndex = 45;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.AutoSize = true;
            saveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveButton.Location = new Point(516, 495);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(41, 25);
            saveButton.TabIndex = 44;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteButton.Location = new Point(566, 442);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(50, 25);
            deleteButton.TabIndex = 43;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addButton.Location = new Point(586, 210);
            addButton.Name = "addButton";
            addButton.Size = new Size(39, 25);
            addButton.TabIndex = 42;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(482, 25);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(143, 23);
            searchTextBox.TabIndex = 41;
            // 
            // searchButton
            // 
            searchButton.AutoSize = true;
            searchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchButton.Location = new Point(424, 25);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(52, 25);
            searchButton.TabIndex = 40;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(244, 268);
            label9.Name = "label9";
            label9.Size = new Size(186, 15);
            label9.TabIndex = 39;
            label9.Text = "Parts Associated with this Product";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(244, 36);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 38;
            label8.Text = "All candidate Parts";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { PartID2, PartName2, PartInventory2, PartPrice2, PartMin2, PartMax2 });
            dataGridView2.Location = new Point(244, 286);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(382, 150);
            dataGridView2.TabIndex = 37;
            // 
            // PartID2
            // 
            PartID2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartID2.DataPropertyName = "PartID";
            PartID2.HeaderText = "Part ID";
            PartID2.Name = "PartID2";
            PartID2.ReadOnly = true;
            PartID2.Width = 67;
            // 
            // PartName2
            // 
            PartName2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartName2.DataPropertyName = "Name";
            PartName2.HeaderText = "Name";
            PartName2.Name = "PartName2";
            PartName2.ReadOnly = true;
            PartName2.Width = 64;
            // 
            // PartInventory2
            // 
            PartInventory2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartInventory2.DataPropertyName = "InStock";
            PartInventory2.HeaderText = "Inventory";
            PartInventory2.Name = "PartInventory2";
            PartInventory2.ReadOnly = true;
            PartInventory2.Width = 82;
            // 
            // PartPrice2
            // 
            PartPrice2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartPrice2.DataPropertyName = "Price";
            PartPrice2.HeaderText = "Price";
            PartPrice2.Name = "PartPrice2";
            PartPrice2.ReadOnly = true;
            PartPrice2.Width = 58;
            // 
            // PartMin2
            // 
            PartMin2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartMin2.DataPropertyName = "Min";
            PartMin2.HeaderText = "Min";
            PartMin2.Name = "PartMin2";
            PartMin2.ReadOnly = true;
            PartMin2.Width = 53;
            // 
            // PartMax2
            // 
            PartMax2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartMax2.DataPropertyName = "Max";
            PartMax2.HeaderText = "Max";
            PartMax2.Name = "PartMax2";
            PartMax2.ReadOnly = true;
            PartMax2.Width = 55;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PartID, PartName, PartInventory, PartPrice, PartMin, PartMax });
            dataGridView1.Location = new Point(244, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(382, 150);
            dataGridView1.TabIndex = 36;
            // 
            // PartID
            // 
            PartID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartID.DataPropertyName = "PartID";
            PartID.HeaderText = "Part ID";
            PartID.Name = "PartID";
            PartID.ReadOnly = true;
            PartID.Width = 67;
            // 
            // PartName
            // 
            PartName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartName.DataPropertyName = "Name";
            PartName.HeaderText = "Name";
            PartName.Name = "PartName";
            PartName.ReadOnly = true;
            PartName.Width = 64;
            // 
            // PartInventory
            // 
            PartInventory.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartInventory.DataPropertyName = "InStock";
            PartInventory.HeaderText = "Inventory";
            PartInventory.Name = "PartInventory";
            PartInventory.ReadOnly = true;
            PartInventory.Width = 82;
            // 
            // PartPrice
            // 
            PartPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartPrice.DataPropertyName = "Price";
            PartPrice.HeaderText = "Price";
            PartPrice.Name = "PartPrice";
            PartPrice.ReadOnly = true;
            PartPrice.Width = 58;
            // 
            // PartMin
            // 
            PartMin.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartMin.DataPropertyName = "Min";
            PartMin.HeaderText = "Min";
            PartMin.Name = "PartMin";
            PartMin.ReadOnly = true;
            PartMin.Width = 53;
            // 
            // PartMax
            // 
            PartMax.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartMax.DataPropertyName = "Max";
            PartMax.HeaderText = "Max";
            PartMax.Name = "PartMax";
            PartMax.ReadOnly = true;
            PartMax.Width = 55;
            // 
            // minTextBox
            // 
            minTextBox.Location = new Point(160, 286);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(50, 23);
            minTextBox.TabIndex = 35;
            minTextBox.TextChanged += minTextBox_TextChanged;
            // 
            // maxTextBox
            // 
            maxTextBox.Location = new Point(70, 286);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(50, 23);
            maxTextBox.TabIndex = 34;
            maxTextBox.TextChanged += maxTextBox_TextChanged;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(70, 257);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(100, 23);
            priceTextBox.TabIndex = 33;
            priceTextBox.TextChanged += priceTextBox_TextChanged;
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.Location = new Point(70, 228);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(100, 23);
            inventoryTextBox.TabIndex = 32;
            inventoryTextBox.TextChanged += inventoryTextBox_TextChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(70, 199);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 31;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // idTextBox
            // 
            idTextBox.Cursor = Cursors.No;
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(70, 170);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(126, 289);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 29;
            label7.Text = "Min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 289);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 28;
            label6.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 260);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 27;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 231);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 26;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 202);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 25;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 173);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 24;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 23;
            label1.Text = "Modify Product";
            // 
            // ModifyProductScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 535);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(minTextBox);
            Controls.Add(maxTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(inventoryTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModifyProductScreen";
            Text = "Product";
            Shown += ModifyProductScreen_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button saveButton;
        private Button deleteButton;
        private Button addButton;
        private TextBox searchTextBox;
        private Button searchButton;
        private Label label9;
        private Label label8;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private TextBox minTextBox;
        private TextBox maxTextBox;
        private TextBox priceTextBox;
        private TextBox inventoryTextBox;
        private TextBox nameTextBox;
        private TextBox idTextBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn PartID2;
        private DataGridViewTextBoxColumn PartName2;
        private DataGridViewTextBoxColumn PartInventory2;
        private DataGridViewTextBoxColumn PartPrice2;
        private DataGridViewTextBoxColumn PartMin2;
        private DataGridViewTextBoxColumn PartMax2;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn PartName;
        private DataGridViewTextBoxColumn PartInventory;
        private DataGridViewTextBoxColumn PartPrice;
        private DataGridViewTextBoxColumn PartMin;
        private DataGridViewTextBoxColumn PartMax;
    }
}