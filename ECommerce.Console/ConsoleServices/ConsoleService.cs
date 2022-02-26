using ECommerce.Console.Consts;
using ECommerce.Console.Models;
using ECommerce.Console.Repository;
using ECommerce.Console.Services;
using Models;
using Services;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServices
{
    public static class ConsoleService
    {

        public static void UserDealing(UserType userType)
        {
            if (userType == UserType.GeneralUser)
            {
                GeneralUserDealing();
            }
            else
            {
                AdminUserDealing();
            }
        }
        private static void GeneralUserDealing()
        {
            UserService userService = new UserService();
            User user = new User(); // to identify current user

            for (; ; )//infinity loop
            {
                Console.WriteLine("Are you current user? true or false");
                bool IsCurrent = Convert.ToBoolean(Console.ReadLine());
                if (IsCurrent)
                {
                    Console.WriteLine("Insert your username");
                    string Username = Console.ReadLine();
                    Console.WriteLine("Insert your password");
                    string Password = Console.ReadLine();

                    user = userService.LogIn(Username, Password);
                    if (user == null)
                    {

                    }
                    else
                    {
                        Console.WriteLine($"Hello {user.FirstName}\n");
                        Console.WriteLine("Please insert number of action\n" +
                            "1. view products\n" +
                            "2. update profile\n" +
                            "3. view card");
                        int ActionNumber = Convert.ToInt32(Console.ReadLine());
                        switch (ActionNumber)
                        {
                            case 1:
                                ViewProducts();
                                break;
                            case 2:
                                UpdateProfile(user);
                                break;
                            case 3:
                                ViewCard();
                                break;
                            default:
                                break;
                        }

                    }
                }
                else
                {
                    RegisterUser();
                }

            }
        }

        private static void ViewCard()
        {
            throw new NotImplementedException();
        }

        private static void UpdateProfile(User user)
        {
            ViewProfile(user);
        }

        private static void ViewProfile(User user)
        {
            Console.WriteLine($"first name {user.FirstName}\n" +
                $"last name {user.LastName}" +
                $"user name {user.UserName}" +
                $"birthday {user.BirthDay}" +
                $"Email {user.Email}");
        }

        private static void ViewProducts()
        {
            ProductService productService = new ProductService();
            List<Product> products = productService.Get();
            foreach (var product in products)
            {
                DisplayProduct(product);
            }
        }

        private static User RegisterUser()
        {
            UserService userService = new UserService();
            User user = new User();
            for (; ; )
            {
                Console.WriteLine("please fill register form\n");

                #region Register form
                Console.WriteLine("Insert your first name");
                user.FirstName = Console.ReadLine();
                Console.WriteLine("Insert your last name");
                user.LastName = Console.ReadLine();
                Console.WriteLine("Insert your email");
                user.Email = Console.ReadLine();
                Console.WriteLine("Insert your username");
                user.UserName = Console.ReadLine();
                Console.WriteLine("Insert your password");
                user.Password = Console.ReadLine();
                Console.WriteLine("Please Confirm password");
                user.ConfirmPassword = Console.ReadLine();
                #endregion
                userService.Add(user);
                user = userService.LogIn(user.UserName, user.Password);
                if (user == null)
                {
                    Console.WriteLine("Some thing is wrong please try again");
                }
                else
                {
                    Console.WriteLine($"you has been registered successfuly{user.FullName}");
                    break;
                }
            }
            return user;
        }
        private static void AdminUserDealing()
        {
            //make sure admin account is exist
            UserService userService = new UserService();
            User user = new User();
            if (!userService.IsExist(Admin.AdminName, Admin.AdminPassword))
            {
                user.UserName = Admin.AdminName;
                user.FirstName = Admin.AdminName;
                user.LastName = Admin.AdminName;
                user.Password = Admin.AdminPassword;
                user.ConfirmPassword = Admin.AdminPassword;
                user.Email = Admin.AdminEmail;

                userService.Add(user);
            }
            for (; ; )
            {
                Console.WriteLine("Insert your username");
                string Username = Console.ReadLine();
                Console.WriteLine("Insert your password");
                string Password = Console.ReadLine();
                user = userService.LogIn(Username, Password);
                if (user == null)
                {
                    Console.WriteLine("your username or password is wrong please try again");

                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Wellcome {user.UserName}!");
            for (; ; )
            {
                Console.WriteLine("Please choose number of action\n-----\n" +
                    "1.Display all product\n" +
                    "2.Insert new product\n" +
                    "3.Active Product\n" +
                    "4.Dective Product\n" +
                    "5.Close actions");
                int Action = Convert.ToInt16(Console.ReadLine());

                switch (Action)
                {
                    case 1:
                        GetAllProduct();
                        break;
                    case 2:
                        AddProduct();
                        break;
                    case 3:
                        ActiveProduct();
                        break;
                    case 4:
                        DectiveProduct();
                        break;
                    default:
                        break;
                }
                if (Action == 5)
                {
                    break;
                }
            }
        }

        private static void DectiveProduct()
        {
            Console.WriteLine("Insert product id ");
            int id = Convert.ToInt16(Console.ReadLine());
            IProductRepository productService = new ProductService();
            productService.Dective(id);
        }

        private static void ActiveProduct()
        {
            Console.WriteLine("Insert product id ");
            int id = Convert.ToInt16(Console.ReadLine());
            IProductRepository productService = new ProductService();
            productService.Active(id);
        }

        private static void AddProduct()
        {
            Product product = ProductForm();
            ProductService productService = new ProductService();
            productService.Add(product);

        }

        private static Product ProductForm()
        {
            Product product = new Product();
            Console.WriteLine("Isert name of product");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Isert name of cost");
            product.Cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Isert name of Price");
            product.Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Isert name of Production date");
            product.ProductionDate = Convert.ToDateTime(Console.ReadLine());
            return product;
        }

        private static void GetAllProduct()
        {
            ProductService productService = new ProductService();
            List<Product> products = productService.GetAll();
            Console.WriteLine("All product\n_______________\n");
            foreach (var product in products)
            {
                DisplayProduct(product,true);
            }
        }

        private static void DisplayProduct(Product product, bool IsAdmin = false)
        {
            if (IsAdmin)
            {
                Console.WriteLine($"id.{product.Id}\n" +
                    $"product name {product.ProductName}\n" +
                    $"cost {product.Cost}\n" +
                    $"price {product.Price}\n" +
                    $"display {product.IsDisplay}\n" +
                    $"profit {product.Profit}\n \n");
            }
            else
            {
                Console.WriteLine($"id.{product.Id}\n" +
                   $"product name {product.ProductName}\n" +
                   $"price {product.Price}\n\n");
            }
        }
    }
}
