using System;
using System.Collections.Generic;
namespace UsuarioCadastro
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("--System to Register Users--");

            string name;
            string email;
            int age;
            string cpf;

            List<User> UserList = new List<User>();

            bool exit = false;
            //bool returning = false;
            int option;

            while (exit == false)
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1 - Register New User.");
                Console.WriteLine("2 - Acess List of Registered Users");
                Console.WriteLine("3 - Delete User.");
                Console.WriteLine("4 - Update User.");
                Console.WriteLine("5 - Exit and Save.");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Username: ");
                        name = Console.ReadLine();
                        Console.WriteLine("User Email");
                        email = Console.ReadLine();
                        Console.WriteLine("User CPF");
                        cpf = Console.ReadLine();
                        Console.WriteLine("User Age");
                        age = Convert.ToInt32(Console.ReadLine());

                        UserList.Add(new User(name, age, email, cpf));
                        break;
                    case 2:
                        foreach (User user in UserList)
                        {
                            user.GetInformation();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Check the List and type the CPF of the User you want to delete: ");
                        cpf = Console.ReadLine();
                        bool sucessRemoving = false;
                        foreach (User user in UserList)
                        {
                            if (user.GetCpf() == cpf)
                            {
                                UserList.Remove(user);
                                sucessRemoving = true;
                                break;
                            }
                        }
                        if (sucessRemoving == true)
                        {
                            Console.WriteLine("User Deleted.");
                        }
                        else
                        {
                            Console.WriteLine("User not found, try again");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Please, type the CPF of the User you want to update: ");
                        cpf = Console.ReadLine();
                        foreach (User user in UserList)
                        {
                            if (cpf == user.GetCpf())
                            {
                                Console.WriteLine("User found!");
                                user.GetInformation();
                                Console.WriteLine("What do you want to change?");
                                int change;
                                Console.WriteLine("1 - Name");
                                Console.WriteLine("2 - Age");
                                Console.WriteLine("3 - Email");
                                Console.WriteLine("4 - CPF");
                                Console.WriteLine("5 - Go back to the Main Menu");
                                change = Convert.ToInt32(Console.ReadLine());
                                switch (change)
                                {
                                    case 1:
                                        Console.WriteLine("Type the new name: ");
                                        user.SetName(Console.ReadLine());
                                        break;
                                    case 2:
                                        Console.WriteLine("Type the new age: ");
                                        user.SetAge(Convert.ToInt32(Console.ReadLine()));
                                        break;
                                    case 3:
                                        Console.WriteLine("Type the new Email: ");
                                        user.SetEmail(Console.ReadLine());
                                        break;
                                    case 4:
                                        Console.WriteLine("Type the new CPF: ");
                                        user.SetCpf(Console.ReadLine());
                                        break;
                                    case 5:
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Option");
                                        break;
                                }
                            }
                        }
                        break;
                    case 5:
                        //Exit and save.
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}
