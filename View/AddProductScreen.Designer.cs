namespace sbInventory
{
    partial class AddProductScreen
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            PartID = new DataGridViewTextBoxColumn();
            PartName = new DataGridViewTextBoxColumn();
            PartInventory = new DataGridViewTextBoxColumn();
            PartPrice = new DataGridViewTextBoxColumn();
            PartMin = new DataGridViewTextBoxColumn();
            PartMax = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            PartID2 = new DataGridViewTextBoxColumn();
            PartName2 = new DataGridViewTextBoxColumn();
            PartInventory2 = new DataGridViewTextBoxColumn();
            PartPrice2 = new DataGridViewTextBoxColumn();
            PartMin2 = new DataGridViewTextBoxColumn();
            PartMax2 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            textBox7 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 173);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 202);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 231);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 260);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 289);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 5;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(126, 289);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 6;
            label7.Text = "Min";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(70, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(70, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(70, 257);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(70, 286);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(50, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(160, 286);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(50, 23);
            textBox6.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PartID, PartName, PartInventory, PartPrice, PartMin, PartMax });
            dataGridView1.Location = new Point(257, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(381, 150);
            dataGridView1.TabIndex = 13;
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
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { PartID2, PartName2, PartInventory2, PartPrice2, PartMin2, PartMax2 });
            dataGridView2.Location = new Point(257, 283);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.ScrollBars = ScrollBars.Vertical;
            dataGridView2.Size = new Size(381, 150);
            dataGridView2.TabIndex = 14;
            // 
            // PartID2
            // 
            PartID2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartID2.HeaderText = "Part ID";
            PartID2.Name = "PartID2";
            PartID2.Width = 67;
            // 
            // PartName2
            // 
            PartName2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartName2.HeaderText = "Name";
            PartName2.Name = "PartName2";
            PartName2.Width = 64;
            // 
            // PartInventory2
            // 
            PartInventory2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartInventory2.HeaderText = "Inventory";
            PartInventory2.Name = "PartInventory2";
            PartInventory2.Width = 82;
            // 
            // PartPrice2
            // 
            PartPrice2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartPrice2.HeaderText = "Price";
            PartPrice2.Name = "PartPrice2";
            PartPrice2.Width = 58;
            // 
            // PartMin2
            // 
            PartMin2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartMin2.HeaderText = "Min";
            PartMin2.Name = "PartMin2";
            PartMin2.Width = 53;
            // 
            // PartMax2
            // 
            PartMax2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PartMax2.HeaderText = "Max";
            PartMax2.Name = "PartMax2";
            PartMax2.Width = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(257, 33);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 15;
            label8.Text = "All candidate Parts";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(257, 265);
            label9.Name = "label9";
            label9.Size = new Size(186, 15);
            label9.TabIndex = 16;
            label9.Text = "Parts Associated with this Product";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(437, 22);
            button1.Name = "button1";
            button1.Size = new Size(52, 25);
            button1.TabIndex = 17;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(495, 22);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(143, 23);
            textBox7.TabIndex = 18;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.Location = new Point(599, 207);
            button2.Name = "button2";
            button2.Size = new Size(39, 25);
            button2.TabIndex = 19;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.Location = new Point(579, 439);
            button3.Name = "button3";
            button3.Size = new Size(50, 25);
            button3.TabIndex = 20;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.Location = new Point(529, 492);
            button4.Name = "button4";
            button4.Size = new Size(41, 25);
            button4.TabIndex = 21;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.Location = new Point(576, 492);
            button5.Name = "button5";
            button5.Size = new Size(53, 25);
            button5.TabIndex = 22;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = true;
            // 
            // AddProductScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(646, 525);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox7);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddProductScreen";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label8;
        private Label label9;
        private Button button1;
        private TextBox textBox7;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn PartName;
        private DataGridViewTextBoxColumn PartInventory;
        private DataGridViewTextBoxColumn PartPrice;
        private DataGridViewTextBoxColumn PartMin;
        private DataGridViewTextBoxColumn PartMax;
        private DataGridViewTextBoxColumn PartID2;
        private DataGridViewTextBoxColumn PartName2;
        private DataGridViewTextBoxColumn PartInventory2;
        private DataGridViewTextBoxColumn PartPrice2;
        private DataGridViewTextBoxColumn PartMin2;
        private DataGridViewTextBoxColumn PartMax2;
    }
}