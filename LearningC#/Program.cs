using System;
using LearningC_;
using LearningC_.User;

class Program
{
    public static void main()
    {
        UserHandler handler = new UserHandler();

        handler.AddUser(new User("aditya", "password", "aditya@gmail.com", 001));
        handler.AddUser(new User("raj", "pass02", "raj@gmail.com", 002));
        handler.AddUser(new User("user", "pass3", "user@gmail.com", 003));

        //handler.printAllUsers();

        var test = handler.findUserById(2);

        Console.WriteLine("-----User Handling------");


        int choice = 0;
        do
        {
            Console.WriteLine("***Options***");
            Console.WriteLine();
            Console.WriteLine("1. Add new user.");
            Console.WriteLine("2. Display all user.");
            Console.WriteLine("3. Search User By Id.");
            Console.WriteLine("4. Search User By Email - substring.");
            Console.WriteLine("5. Return complete User List");
            Console.WriteLine("6. Update User By Id : ");
            Console.WriteLine("7. Delete User By Id : ");
            Console.WriteLine("7. Login Into System : ");
            Console.WriteLine("0. Exit the program.");
            Console.WriteLine();
            Console.WriteLine("=====================================================================");

            //Taking Input from User 
            Console.Write("Enter your choice: ");
            string ch;

            while (true)
            {
                ch = Console.ReadLine();
                Console.WriteLine();

                if (int.TryParse(ch, out choice))
                {
                    break; // Exit the loop if input is valid
                }
                else
                {
                    Console.Write("Invalid input. Please enter a valid integer:");
                }
            }

            //Options
            switch (choice)
            {
                case 1:
                    //Taking user detials
                    AddNewUser(ref handler);
                    break;

                case 2:
                    //Displaying complete user.
                    DisplaAllUser(ref handler);
                    break;

                case 3:
                    SearchUserById(ref handler);
                    break;

                case 4:
                    SearchUserByEmailSubstring(ref handler);
                    break;

                case 5:
                    ReturnUserList(ref handler);
                    break;

                case 6:
                    UpdateUserById(ref handler);
                    break;

                case 7:
                    DeleteUserById(ref handler);
                    break;

                case 8:
                    Login(ref handler);
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Enter a valid option!");
                    break;

            }

            Console.WriteLine("=====================================================================");
        } while (choice != 0);

    }


    public static void AddNewUser(ref UserHandler handler)
    {
        Console.Write("Enter ID:");
        var id = Console.ReadLine();
        Console.Write("Enter usename:");
        var username = Console.ReadLine();
        Console.Write("Enter email : ");
        var email = Console.ReadLine();
        Console.Write("Enter password : ");
        var password = Console.ReadLine();

        //Printing Details.
        handler.AddUser(new User(username, password, email, int.Parse(id)));
        Console.WriteLine("User added successfully!!!");
    }

    public static void DisplaAllUser(ref UserHandler handler)
    {
        Console.WriteLine("Number of User : ");
        handler.printAllUsers();
    }

    public static void SearchUserById(ref UserHandler handler)
    {
        Console.Write("Enter the ID : ");
        var findId = Convert.ToInt32(Console.ReadLine());

        var user = handler.findUserById(findId);
        if (user != null)
        {
            user.toPrint();
        }
        else
        {
            Console.WriteLine("User not found!!");
        }
    }

    public static void SearchUserByEmailSubstring(ref UserHandler handler)
    {

        Console.Write("Enter email substring: ");
        var subString = Console.ReadLine();

        Console.WriteLine("Number of user Consists found :");
        var searchList = handler.getUsersBySubstring(subString);
        //if (searchList != null)
        //{
        //    foreach (var item in searchList)
        //    {
        //        item.toPrint();
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("O users found!!!");
        //}

        if(searchList.Count != 0)
        {
            foreach (var user in searchList) {
                user.toPrint(); 
            }
        }
        else
        {
            Console.Write("No user exists!!");
        }
    }

    public static void ReturnUserList(ref UserHandler handler)
    {
        var completeUser = handler.getCompleteUserList();
        if (completeUser.Count > 0)
        {
            foreach (var item in completeUser)
            {
                item.toPrint();
            }
        }
        else
        {
            Console.WriteLine("No user found!!!");
        }
    }

    public static void UpdateUserById(ref UserHandler handler)
    {
        int id = 0;

        Console.Write("Enter User Id: ");
        var ch = Console.ReadLine();
        
        if (int.TryParse(ch, out id))
        {
            handler.updateById(id);
        }
        else
        {
            Console.Write("Invalid input. Please enter a valid integer:");
        }
    }

    public static void DeleteUserById(ref UserHandler handler)
    {
        Console.Write("Enter the Id :");
        string r;
        int id;

        while (true)
        {
            r = Console.ReadLine();
            Console.WriteLine();

            if (int.TryParse(r, out id))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Please enter a valid integer:");
            }
        }

        handler.deleteById(id);

    }


    public static void Login(ref UserHandler handler)
    {
        Console.Write("Enter user email : ");
        var email = Console.ReadLine();

        (var user, var logginedStatuts) = handler.Login(email);

       if(logginedStatuts == "LoggedIn")
        {
            Console.WriteLine("User loggined successfully!!");
        }
        else if(logginedStatuts == "Unauthenticated")
        {
            Console.WriteLine("Invalid Credentials");
        }
        else
        {
            Console.WriteLine("User not Found");
        }

    }
    //Interface
    public static void sumOfparameter<Type>(ref Type item1, ref Type item2)
    {
        try
        {
            if (typeof(Type) == typeof(string))
            {
                string result = (string)(object)item1 + " " + (string)(object)item2;
                Console.WriteLine("Concatenated String: " + result);
            }
            else if (typeof(Type) == typeof(decimal))
            {
                decimal add = (decimal)(object)item1 + (decimal)(object)item2;
                Console.WriteLine("Addition of two decimal: " + add);
            }
            else if (typeof(Type) == typeof(int))
            {
                int sum = (int)(object)item1 + (int)(object)item2;
                Console.WriteLine("Addition of two integer : " + sum);
            }
            else
            {
                throw new InvalidOperationException("The parameter should be interger or string or decimal.");
            }
        }
        catch (InvalidOperationException error)
        {
            Console.WriteLine(error.Message);
        }

    }
}
