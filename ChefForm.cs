using SedapMakanApp.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SedapMakanApp
{
    public partial class ChefForm : Form
    {
        // Constructor for ChefForm
        public ChefForm()
        {
            InitializeComponent();
            this.menuListview.SelectedIndexChanged += new System.EventHandler(this.menuListview_SelectedIndexChanged);
            
            // Load menu items into the list view by retrieving from FoodMenu class
            menuListview.View = View.Details;
            menuListview.Columns.Add("Name", 120);
            menuListview.Columns.Add("Price", 80);
            menuListview.Columns.Add("Availability", 100);

            // Load order items into list view
            orderListview.View = View.Details;
            orderListview.Columns.Add("Order ID", 80);
            orderListview.Columns.Add("Customer ID", 80);
            orderListview.Columns.Add("Order Time", 100);
            orderListview.Columns.Add("Status", 80);
            
            UpdateOrderListView();
            UpdateMenuListView();
            menuListview.SelectedIndexChanged += menuListview_SelectedIndexChanged;
        }



        /*   Helper Functions   */
        // Method to check for valid editor input
        private bool IsValidEditorInput()

        {
            string id = targetEditId.Text;
            string name = targetEditName.Text;
            string description = targetEditDescription.Text;
            string price = targetEditPrice.Text;
            // convert price string to double
            double priceValue = 0;
            if (!double.TryParse(price, out priceValue))
            {
                MessageBox.Show("Invalid input of Price.");
                return false;
            }



            // check if empty
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Empty Field Found.");
                return false;
            }
            // checked if all input is a valid string with no other special characters
            if (!System.Text.RegularExpressions.Regex.IsMatch(id, @"^[a-zA-Z0-9]+$") || !System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show(" Invalid input of Special Character.");
                return false;
            }


            //checked if price is a valid double
            if (!double.TryParse(price, out double result) || priceValue <= 0)
            {
                MessageBox.Show("Invalid input of Price.");
                return false;
            }

            return true;
        }

        // Method to update listview
        private void UpdateMenuListView()
        {
            menuListview.Items.Clear();
            foreach (var food in Class.FoodMenu.GetMenu())
            {
                ListViewItem item = new ListViewItem(food.Name);
                item.SubItems.Add(food.Price.ToString("C"));
                item.SubItems.Add(food.IsAvailable ? "✔" : "✖");
                item.Tag = food;
                menuListview.Items.Add(item);
            }
        }

        // Method to update orderview
        private void UpdateOrderListView()
        {
            orderListview.Items.Clear();
            foreach (var order in Class.OrderList.GetOrders())
            {
                ListViewItem item = new ListViewItem(order.Id);
                item.SubItems.Add(order.CustomerId);
                // add order time with time component only
                item.SubItems.Add(order.OrderDate.ToString("HH:mm:ss"));

                // add either completed or in progress
                item.SubItems.Add(order.Completed ? "Completed" : "In Progress");
                
                orderListview.Items.Add(item);
            }
        }



        /*   Event Functions   */
        // Method to handle the selected index change event
        string selectedFoodId = "";
        private void menuListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuListview.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = menuListview.SelectedItems[0];
                var food = selectedItem.Tag as Class.Food;
                selectedFoodLabel.Text = $"Selected Food: {food.Name} - {food.Price:C} - {(food.IsAvailable ? "Available" : "Not Available")}";
                selectedFoodId = food.Id; 
            }
        }

        public string selectedOrderId = "";
        private void orderListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderListview.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = orderListview.SelectedItems[0];

                selectedOrderId = selectedItem.Text;
                Order selectedOrder = Class.OrderList.GetOrderById(selectedOrderId);
                selectedOrderLabel.Text = $"Selected Order: {selectedOrder.Id}";
            }
        }
        

        /*   Button Functions   */
        // Method to handle the remove button click event
        private void removeSelected_Click(object sender, EventArgs e)
        {

            if ( selectedFoodId == "")
            {
                MessageBox.Show("No item selected to remove.");
                return;
            }


            DialogResult result = MessageBox.Show($"Are you sure you want to remove {FoodMenu.GetFood(selectedFoodId).Name} From Menu?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            if (menuListview.SelectedItems.Count > 0)
            {
                Class.FoodMenu.RemoveFood(selectedFoodId);
            }
            UpdateMenuListView();
        }

        // Method to handle the edit button click event
        bool editorMode = false;
        string selectedTargetEditFoodId = "";
        private void editSelected_Click(object sender, EventArgs e)
        {
            selectedTargetEditFoodId = selectedFoodId;
            // display a shadow text for the text box of targetEditName, targetEditPrice, targetEditDescription and check the targetEditAvailability
            if (menuListview.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = menuListview.SelectedItems[0];
                var food = selectedItem.Tag as Class.Food;
                targetEditId.Text = food.Id;
                targetEditName.Text = food.Name;
                targetEditPrice.Text = food.Price.ToString();
                targetEditDescription.Text = food.Description;
                targetEditAvailability.Checked = food.IsAvailable;
                
                editorModeLabel.Text = "Mode: Edit";
                editorMode = true;
                
            }
        }

        // Method to handle the exit button click event
        private void exitChefBtn_Click(object sender, EventArgs e)
        {

        }

        // Method to handle the add food button click event
        private void addFoodBtn_Click(object sender, EventArgs e)
        {
            editorModeLabel.Text = "Mode: Add";
            editorMode = false;
        }

        // Method to handle the confirm edit/add button click event
        private void confirmEditBtn_Click(object sender, EventArgs e)
        {
            if (!IsValidEditorInput())
            {
                return;
            }
            // Ask for confirmation before adding/editing
            DialogResult result = MessageBox.Show($"Are you sure you want to {(editorMode ? "edit" : "add")} this food item?", "Confirm Edit/Add", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            if (editorMode)
            {
              
                    
                if (selectedFoodId == "")
                {
                    MessageBox.Show("No item were selected.");
                    return;
                }
                // Update Food Detail
                // Check if the targetEditFoodId is overlapping with existing food item
                foreach (var food in Class.FoodMenu.GetMenu())
                {
                    if (food.Id == targetEditId.Text && food.Id != selectedTargetEditFoodId)
                    {
                        MessageBox.Show("Food ID already exists. Please use a different ID.");
                        return;
                    }
                }

                Class.FoodMenu.UpdateFood(selectedTargetEditFoodId, targetEditName.Text, targetEditDescription.Text, double.Parse(targetEditPrice.Text), targetEditAvailability.Checked);
                UpdateMenuListView(); 
                MessageBox.Show("Food item updated successfully.");
            }
            else
            {
                // Add New Food
                // Check if the targetEditFoodId is overlapping with existing food item
                // check for variable needed for constructor are empty or not
                if (string.IsNullOrEmpty(targetEditId.Text) || string.IsNullOrEmpty(targetEditName.Text) || string.IsNullOrEmpty(targetEditDescription.Text) || string.IsNullOrEmpty(targetEditPrice.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }
                foreach (var food in Class.FoodMenu.GetMenu())
                {
                    if (food.Id == targetEditId.Text)
                    {
                        MessageBox.Show("Food ID already exists. Please use a different ID.");
                        return;
                    }
                }

                Class.FoodMenu.AddFood(targetEditId.Text, targetEditName.Text, targetEditDescription.Text, double.Parse(targetEditPrice.Text), targetEditAvailability.Checked);
                UpdateMenuListView();
                MessageBox.Show("Food item added successfully.");
            }
        }

        private void viewSelectedBtn_Click(object sender, EventArgs e)
        {
            //view selected order
            if (selectedOrderId == "")
            {
                MessageBox.Show("No order selected to view.");
                return;
            }
            if (orderListview.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = orderListview.SelectedItems[0];

                string selectedOderId = selectedItem.Text;
                Order selectedOrder = Class.OrderList.GetOrderById(selectedOderId);
                
            
                string orderDetails = selectedOrder.GetOrderDetails();
                MessageBox.Show(orderDetails, "Order Details");
            }
        }
    }
}
