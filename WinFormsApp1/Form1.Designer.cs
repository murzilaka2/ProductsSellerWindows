namespace WinFormsApp1
{
    partial class Form1
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
            CategoryComboBox = new ComboBox();
            ProductsListBox = new ListBox();
            CartProductsListBox = new ListBox();
            AddItemButton = new Button();
            DetailsButton = new Button();
            RemoveItemButton = new Button();
            TotalToPayTextBox = new TextBox();
            FinishOrderButton = new Button();
            SuspendLayout();
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(12, 12);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(155, 23);
            CategoryComboBox.TabIndex = 0;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // ProductsListBox
            // 
            ProductsListBox.FormattingEnabled = true;
            ProductsListBox.ItemHeight = 15;
            ProductsListBox.Location = new Point(181, 12);
            ProductsListBox.Name = "ProductsListBox";
            ProductsListBox.Size = new Size(353, 334);
            ProductsListBox.TabIndex = 1;
            // 
            // CartProductsListBox
            // 
            CartProductsListBox.FormattingEnabled = true;
            CartProductsListBox.ItemHeight = 15;
            CartProductsListBox.Location = new Point(549, 12);
            CartProductsListBox.Name = "CartProductsListBox";
            CartProductsListBox.Size = new Size(239, 304);
            CartProductsListBox.TabIndex = 2;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(181, 352);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(137, 23);
            AddItemButton.TabIndex = 3;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // DetailsButton
            // 
            DetailsButton.Location = new Point(397, 352);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.Size = new Size(137, 23);
            DetailsButton.TabIndex = 4;
            DetailsButton.Text = "Details";
            DetailsButton.UseVisualStyleBackColor = true;
            DetailsButton.Click += DetailsButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(549, 323);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(239, 23);
            RemoveItemButton.TabIndex = 5;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // TotalToPayTextBox
            // 
            TotalToPayTextBox.Location = new Point(549, 352);
            TotalToPayTextBox.Name = "TotalToPayTextBox";
            TotalToPayTextBox.ReadOnly = true;
            TotalToPayTextBox.Size = new Size(239, 23);
            TotalToPayTextBox.TabIndex = 6;
            // 
            // FinishOrderButton
            // 
            FinishOrderButton.Location = new Point(651, 405);
            FinishOrderButton.Name = "FinishOrderButton";
            FinishOrderButton.Size = new Size(137, 23);
            FinishOrderButton.TabIndex = 7;
            FinishOrderButton.Text = "Finish Order";
            FinishOrderButton.UseVisualStyleBackColor = true;
            FinishOrderButton.Click += FinishOrderButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FinishOrderButton);
            Controls.Add(TotalToPayTextBox);
            Controls.Add(RemoveItemButton);
            Controls.Add(DetailsButton);
            Controls.Add(AddItemButton);
            Controls.Add(CartProductsListBox);
            Controls.Add(ProductsListBox);
            Controls.Add(CategoryComboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CategoryComboBox;
        private ListBox ProductsListBox;
        private ListBox CartProductsListBox;
        private Button AddItemButton;
        private Button DetailsButton;
        private Button RemoveItemButton;
        private TextBox TotalToPayTextBox;
        private Button FinishOrderButton;
    }
}