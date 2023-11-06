using System.Collections.ObjectModel;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Category[] categories;
        private ObservableCollection<Product> products;

        public decimal TotalToPay
        {
            get
            {
                return CartProductsListBox.Items.OfType<Product>().Sum(e => e.Price);
            }
        }
        public Form1()
        {
            InitializeComponent();

            categories = new Category[]
            {
                new Category{ Name = "Laptops"},
                new Category{ Name = "Headphones"},
                new Category{ Name = "Smartphones"}
            };

            products = new ObservableCollection<Product>
            {
                new Product{ Name = "Asus Vx18", Category = categories[0], Price = 899, Quantity = 70},
                new Product{ Name = "Lenovo P45", Category = categories[0], Price = 699, Quantity = 21},
                new Product{ Name = "Sony WH-CH720", Category = categories[1], Price = 169, Quantity = 120},
                new Product{ Name = "Google Pixel A6", Category = categories[2], Price = 570, Quantity = 54}
            };

            CategoryComboBox.DataSource = categories;
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "Id";

            ProductsListBox.SelectionMode = SelectionMode.MultiExtended;

            FillListBox();
        }

        private void FillListBox()
        {
            ProductsListBox.DataSource = products.Where(e => e.Category.Id.Equals(CategoryComboBox.SelectedValue)).ToList();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            var selectedProducts = ProductsListBox.SelectedItems.OfType<Product>().ToArray();
            if (selectedProducts != null)
            {
                CartProductsListBox.Items.AddRange(selectedProducts);
                TotalToPayTextBox.Text = $"Total to pay: {TotalToPay.ToString()}";
            }
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            var selectedProducts = ProductsListBox.SelectedItems.OfType<Product>().ToArray();
            if (selectedProducts != null)
            {
                DetailForm detailForm = new DetailForm(selectedProducts);
                var result = detailForm.ShowDialog();
                FillListBox();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int index = CartProductsListBox.SelectedIndex;
            if (index != -1)
            {
                CartProductsListBox.Items.RemoveAt(index);
                TotalToPayTextBox.Text = $"Total to pay: {TotalToPay.ToString()}";
            }
        }

        private void FinishOrderButton_Click(object sender, EventArgs e)
        {
            if (TotalToPay > 0)
            {
                MessageBox.Show($"Order is finished.\nTotal to pay: {TotalToPay}","Pay Method");
            }
        }
    }
}