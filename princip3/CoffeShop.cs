using princip3.Coffes;
using princip3.Service;
using princip3.Toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace princip3
{
    public class CoffeShop
    {
        public List<Order> Orders { get; set; }
        public double TotalIncome { get; set; }


        public CoffeShop() {
            Orders = new List<Order>();
            TotalIncome = 0;
        } 

        public void Menu()
        {
            int counter = 0;
            while (true)
            {
                Console.WriteLine();
                string answer = ChoosingAction();
                if (answer == "1")
                {
                    counter++;
                    Order order = new Order(counter);
                    OrderingCoffe(order);

                }
                else if (answer == "2")
                {
                    DisplayingAllOrders();
                }
                else if (answer == "3")
                {
                    Console.WriteLine("Exiting program");
                    return;
                }
                else
                {
                    Console.WriteLine($"There is no option {answer} in menu , try again");
                }
            }
        }

        private void TopingChoosing(OrderItem newOrderItem)
        {
            while (true)
            {
                Console.WriteLine("-----CHOSE TOPPINGS-----");
                Console.WriteLine("1. Milk");
                Console.WriteLine("2. Brown sugar");
                Console.WriteLine("3. Cinnamon");
                Console.WriteLine("4. End");
                string toppingChoice = Console.ReadLine();

                if (toppingChoice == "1")
                {
                    newOrderItem.AddTopping(new MilkTopping());
                }
                else if (toppingChoice == "2")
                {
                    newOrderItem.AddTopping(new BrownSugarTopping());
                }
                else if (toppingChoice == "3")
                {
                    newOrderItem.AddTopping(new Cinnamon());
                }
                else if (toppingChoice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You didnt enter something properly , try again");
                }

            }
        }

        private string ChoosingSize()
        {
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine("Chose size: ");
            Console.WriteLine("1. Regular");
            Console.WriteLine("2. Large");
            string size = Console.ReadLine();
            return size;
        }

        private string ChoosingItems()
        {
            Console.WriteLine("---CHOSE ITEMS---");
            Console.WriteLine("1. Espresso");
            Console.WriteLine("2. Cappucino");
            Console.WriteLine("3. Latte Machiato");
            Console.WriteLine("4. End order");
            string choice = Console.ReadLine();
            return choice;
        }
        
        private string ChoosingAction()
        {
            Console.WriteLine("---------COFFE SHOP----------");
            Console.WriteLine("1. Take order");
            Console.WriteLine("2. List all orders");
            Console.WriteLine("3. Exit application");
            string answer = Console.ReadLine();
            return answer;
        }

        private void AddingItemInOrder(Order order,OrderItem newOrderItem)
        {
            Console.WriteLine("Write quantity: ");
            int quantity = int.Parse((Console.ReadLine()));
            if (quantity > 0)
            {
                newOrderItem.SetQauntity(quantity);
            }
            else
            {
                Console.WriteLine("You enter unipropient quantity, try again");
                return;
            }
            order.AddOrderItem(newOrderItem);
        }

        private void AddingOrderService(Order order)
        {
            while (true)
            {

                Console.WriteLine();
                Console.WriteLine($"------CHOSE SERVICE FOR ORDER: {order.OrderNum}------");
                Console.WriteLine("1. In home");
                Console.WriteLine("2. Take away");
                Console.WriteLine("3. Coupon");
                string choice = Console.ReadLine();

                if(choice == "1")
                {
                    order.AddServiceType(new InHome());
                    break;
                }
                else if(choice == "2")
                {
                    order.AddServiceType(new TakeAway());
                    break;
                }
                else if(choice == "3")
                {
                    order.AddServiceType(new Coupon());
                    break;
                }
                else
                {
                    Console.WriteLine($"There is no option {choice} , Try again");
                }
            }
        }

        private void OrderingCoffe(Order order)
        {
            while (true)
            {
                Console.WriteLine();
                string choice = ChoosingItems();
                if (choice == "1")
                {
                    string size = ChoosingSize();
                    Console.WriteLine();
                    if (size == "1")
                    {
                        OrderItem newOrderItem = new OrderItem(new Espresso("R"));
                        TopingChoosing(newOrderItem);
                        AddingItemInOrder(order, newOrderItem);
                    }
                    else if (size == "2")
                    {
                        OrderItem newOrderItem = new OrderItem(new Espresso("L"));
                        TopingChoosing(newOrderItem);
                        AddingItemInOrder(order, newOrderItem);
                    }
                    else
                    {
                        Console.WriteLine("You didnt enter something properly , try again");
                    }

                }
                else if (choice == "2")
                {
                    string size = ChoosingSize();
                    Console.WriteLine();
                    if (size == "1")
                    {
                        OrderItem newOrderItem = new OrderItem(new Cappuccino("R"));
                        TopingChoosing(newOrderItem);
                        AddingItemInOrder(order, newOrderItem);
                    }
                    else if (size == "2")
                    {
                        OrderItem newOrderItem = new OrderItem(new Cappuccino("L"));
                        TopingChoosing(newOrderItem);
                        AddingItemInOrder(order, newOrderItem);
                    }
                    else
                    {
                        Console.WriteLine("You didnt enter something properly , try again");
                    }
                }
                else if (choice == "3")
                {
                    string size = ChoosingSize();
                    Console.WriteLine();
                    if (size == "1")
                    {
                        OrderItem newOrderItem = new OrderItem(new LatteMachiato("R"));
                        TopingChoosing(newOrderItem);
                        AddingItemInOrder(order, newOrderItem);
                    }
                    else if (size == "2")
                    {
                        OrderItem newOrderItem = new OrderItem(new LatteMachiato("L"));
                        TopingChoosing(newOrderItem);
                        AddingItemInOrder(order, newOrderItem);
                    }
                    else
                    {
                        Console.WriteLine("You didnt enter something properly , try again");
                    }
                }
                else if (choice == "4")
                {
                    AddingOrderService(order);
                    Console.WriteLine("Your order is: ");
                    order.DisplayOrder();
                    Orders.Add(order);
                    TotalIncome += order.TotalOrderPrice();
                    break;
                }
                else
                {
                    Console.WriteLine($"There is no option {choice} in menu , try again");
                }
            }
        }
        private void DisplayingAllOrders()
        {
            Console.WriteLine("---------ALL ORDERS--------");
            
            if(Orders.Count == 0) {
                Console.WriteLine("There is none order yet in coffe shop");
            }

            foreach (var order in Orders)
            {
                order.DisplayOrder();
            }
            Console.WriteLine();
            Console.WriteLine($"Total income: {TotalIncome}");
        }

        
    }
}
