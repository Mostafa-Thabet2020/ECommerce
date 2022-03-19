using ECommerce.Consts;
using ECommerce.Models;
using ECommerce.Repository;
using ECommerce.Services;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.ConsoleServices
{
    public static class OrderConsoleService
    {
        public static void HandleOrder(User user)
        {
            if (user.userRole.Name == Admin.AdminRole)
            {
                HandleOrderByAdmin(user);
            }
            else
            {
                HandleOrderByGeneral(user);
            }
        }

        private static void HandleOrderByGeneral(User user)
        {
            
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("Please choose action:\n" +
                    "1.Add to card\n" +
                    "2.show card\n" +
                    "3.track orders\n" +
                    "4.Manged order\n" +
                    "5.Close\n\n");
                Console.Beep();
                int Action =Convert.ToInt16( Console.ReadLine());
                switch (Action)
                {
                    case 1:
                        AddToCard(user);
                        break;
                    case 2:
                        ShowCard(user);
                        break;
                    case 3:
                        TrackOrders(user);
                        break;
                    case 4:
                        MangeOrder(user);
                        break;
                    default:
                        break;
                }
                if (Action>5)
                {
                    break;
                }
            }

        }

        private static void MangeOrder(User user)
        {
            OrderConsoleService.HandleOrder(user);
        }

        private static void TrackOrders(User user)
        {
            throw new NotImplementedException();
        }

        private static void ShowCard(User user)
        {
            throw new NotImplementedException();
        }

        private static void AddToCard(User user)
        {
            IOrderRepository orderService = new OrderService(user);
            Order NewOrder = new Order();
            NewOrder.UserID = user.Id;
            List<OrderDetails> orderDetails = new List<OrderDetails>();

            for(; ; )
            {
                IProductRepository productService = new ProductService();
                OrderDetails orderDetail = new OrderDetails();
                Console.WriteLine("Insert Product Id");
                orderDetail.productId = Convert.ToInt16(Console.ReadLine());
                Product product = productService.Get(orderDetail.productId);
                orderDetail.Price = product.Price;
                Console.WriteLine("Insert Quantity");
                orderDetail.Quantity = Convert.ToInt16(Console.ReadLine());
                orderDetails.Add(orderDetail);
                Console.WriteLine("Insert new product ? true or false");
                bool IsNewProduct = Convert.ToBoolean(Console.ReadLine());
                if (!IsNewProduct)
                {
                    break;
                }
            }
            NewOrder.orderDetails=orderDetails;
            Console.WriteLine("Insert descriptation");
            NewOrder.Descripation = Console.ReadLine();
            orderService.Add(NewOrder);

        }

        private static void HandleOrderByAdmin(User user)
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("Please choose action\n" +
                    "1.show all orders\n" +
                    "2.show total orders\n" +
                    "3.show count orders\n" +
                    "4.Get orders of client\n" +
                    "5.Is order shipped?\n" +
                    "6.Make order shippe\n" +
                    "7.Get shipped total\n" +
                    "8.Get unshipped total\n" +
                    "9.Get shipped count\n" +
                    "10.Get unshipped count\n");
                Console.Beep();
            }
        }

    }
}
