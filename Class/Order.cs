using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
3.	Chef
-	Manage (add/remove/edit) menu details which include the pricing
-	Update status of menu item if its available or not
-	View orders placed by customers.
-	Update orders as "In Progress" or "Completed.”
-	Update own profile.

4.	Customer
-	Browse menu and order item and pay to confirm. Customer can only order available items and if their price is less or equal the e-wallet balance.
-	View order status.
-	Cancel order, request refund 
-	Send feedback.
-	Check refund status
-	Update own profile.

*/



namespace SedapMakanApp.Class
{
    // Order class to manage order details
    public class Order
    {
        // Constructor for order class
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public List<string> FoodIds { get; set; }
        public bool Completed { get; set; }
        public DateTime OrderDate { get; set; }



        public Order(string id, string customerId, List<string> foodIds, bool completed)
        {
            Id = id;
            CustomerId = customerId;
            FoodIds = foodIds;
            Completed = completed;
            OrderDate = DateTime.Now; // set order date to now
        }

        // Method to update order status
        public void UpdateOrderStatus(bool isCompleted)
        {
            Completed = isCompleted;
        }

        // Method to get order details
        public string GetOrderDetails()
        {
            // get food details
            string foodDetails = "";
            foreach (string foodId in FoodIds)
            {
                // find the food by id with loop
                foreach (Food food in FoodMenu.GetMenu())
                {
                    if (food.Id == foodId)
                    {
                        foodDetails += $"{food.Name} - RM{food.Price}\n";
                        break; // exit the loop once found
                    }
                }
            }
            
            string orderDetails = $"Order ID: {Id}\nCustomer ID: {CustomerId}\nFood Detail:\n{foodDetails}\nStatus: {(Completed ? "Completed" : "In Progress")}\nOrder Date: {OrderDate}";
            return orderDetails;
        }

        // calculate order price
        public double CalculateOrderPrice()
        {
            double totalPrice = 0;
            foreach (string foodId in FoodIds)
            {
                // find the food by id with loop
                foreach (Food food in FoodMenu.GetMenu())
                {
                    if (food.Id == foodId)
                    {
                        totalPrice += food.Price;
                        break; // exit the loop once found
                    }
                }
            }
            return totalPrice;
        }
    }

    public class OrderList
    {
        // Initialization of order list
        public static List<Order> orders = new List<Order>();

        // initialize orderlist with some orders
        static OrderList()
        {
            orders.Add(new Order("O01", "C01", new List<string> { "F01", "F02" }, false));
            orders.Add(new Order("O02", "C02", new List<string> { "F03", "F04" }, true));
            orders.Add(new Order("O03", "C03", new List<string> { "F05" }, false));
        }


        // Method to add order to the list
        public static void AddOrder(Order order)
        {
            orders.Add(order);
        }

        // Method to get all orders
        public static List<Order> GetOrders()
        {
            return orders;
        }

        // Method to get order by order id
        public static Order GetOrderById(string id)
        {
            // find the order by id with loop
            foreach (Order order in orders)
            {
                if (order.Id == id)
                {
                    return order;
                }
            }
            return null; // return null if not found
        }

        // calculate totol orer list price
        public static double CalculateOrderListPrice()
        {
            double totalPrice = 0;
            foreach (Order order in orders)
            {
                totalPrice += order.CalculateOrderPrice();
            }
            return totalPrice;
        }


    }
}
