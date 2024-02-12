namespace sbInventory
{
    partial class AddPartScreen
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
            inHouseRadioButton = new RadioButton();
            outsourcedRadioButton = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            idTextBox = new TextBox();
            nameTextBox = new TextBox();
            inventoryTextBox = new TextBox();
            priceCostTextBox = new TextBox();
            maxTextBox = new TextBox();
            minTextBox = new TextBox();
            machineIdCompanyNameTextBox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // inHouseRadioButton
            // 
            inHouseRadioButton.AutoSize = true;
            inHouseRadioButton.Location = new Point(71, 7);
            inHouseRadioButton.Name = "inHouseRadioButton";
            inHouseRadioButton.Size = new Size(74, 19);
            inHouseRadioButton.TabIndex = 1;
            inHouseRadioButton.TabStop = true;
            inHouseRadioButton.Text = "In-House";
            inHouseRadioButton.UseVisualStyleBackColor = true;
            inHouseRadioButton.Click += inHouseRadioButton_Click;
            // 
            // outsourcedRadioButton
            // 
            outsourcedRadioButton.AutoSize = true;
            outsourcedRadioButton.Location = new Point(151, 7);
            outsourcedRadioButton.Name = "outsourcedRadioButton";
            outsourcedRadioButton.Size = new Size(87, 19);
            outsourcedRadioButton.TabIndex = 2;
            outsourcedRadioButton.TabStop = true;
            outsourcedRadioButton.Text = "Outsourced";
            outsourcedRadioButton.UseVisualStyleBackColor = true;
            outsourcedRadioButton.Click += outsourcedRadioButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 29);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 58);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 87);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 116);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 6;
            label5.Text = "Price / Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 145);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 7;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(151, 145);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 8;
            label7.Text = "Min";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 174);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 9;
            label8.Text = "Machine ID";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(95, 26);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(95, 55);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 11;
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.Location = new Point(95, 84);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(100, 23);
            inventoryTextBox.TabIndex = 12;
            // 
            // priceCostTextBox
            // 
            priceCostTextBox.Location = new Point(95, 113);
            priceCostTextBox.Name = "priceCostTextBox";
            priceCostTextBox.Size = new Size(100, 23);
            priceCostTextBox.TabIndex = 13;
            // 
            // maxTextBox
            // 
            maxTextBox.Location = new Point(95, 142);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(50, 23);
            maxTextBox.TabIndex = 14;
            // 
            // minTextBox
            // 
            minTextBox.Location = new Point(185, 142);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(50, 23);
            minTextBox.TabIndex = 15;
            // 
            // machineIdCompanyNameTextBox
            // 
            machineIdCompanyNameTextBox.Location = new Point(104, 171);
            machineIdCompanyNameTextBox.Name = "machineIdCompanyNameTextBox";
            machineIdCompanyNameTextBox.Size = new Size(100, 23);
            machineIdCompanyNameTextBox.TabIndex = 16;
            // 
            // saveButton
            // 
            saveButton.AutoSize = true;
            saveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveButton.Location = new Point(135, 200);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(41, 25);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.AutoSize = true;
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Location = new Point(182, 200);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(53, 25);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddPartScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(252, 241);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(machineIdCompanyNameTextBox);
            Controls.Add(minTextBox);
            Controls.Add(maxTextBox);
            Controls.Add(priceCostTextBox);
            Controls.Add(inventoryTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(outsourcedRadioButton);
            Controls.Add(inHouseRadioButton);
            Controls.Add(label1);
            Name = "AddPartScreen";
            Text = "Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton inHouseRadioButton;
        private RadioButton outsourcedRadioButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox idTextBox;
        private TextBox nameTextBox;
        private TextBox inventoryTextBox;
        private TextBox priceCostTextBox;
        private TextBox maxTextBox;
        private TextBox minTextBox;
        private TextBox machineIdCompanyNameTextBox;
        private Button saveButton;
        private Button cancelButton;
    }
}