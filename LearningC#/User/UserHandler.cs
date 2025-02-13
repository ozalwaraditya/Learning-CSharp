using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.User
{
    public class UserHandler
    {
        List<User> users = new List<User>();

        //Add new user 
        public void AddUser(User user)
        {
            users.Add(user);
        }

        //Print all user
        public void printAllUsers()
        {
            int i = 0;
            foreach (User user in users)
            {
                Console.WriteLine($"User {i + 1} : {user.Id}, {user.Username}, {user.Email}");
                i++;
            }
        }

        // Method - Find user by Id
        public User findUserById(int id)
        {
            if(users.Count != 0)
            {
                return users.Where(i => i.Id == id).Single();
            }
            return null;
        }

        // Method - Find user by substring
        public List<User> getUsersBySubstring(string str)
        {
            //List<User> searchList = new List<User>();
            //foreach (var item in users)
            //{
            //    if (item.Email.Contains(str))
            //    {
            //        searchList.Add(item);
            //    }
            //}
            //return searchList;
            //if (searchList.Count > 0)
            //{
            //    return searchList;
            //}
            //else
            //{
            //    return null;
            //}

            // By using IEnumerable

            IEnumerable<User> searchList = this.users.Where(user => user.Email.Contains(str));

            return searchList.ToList();

        }

        // Method - Return complete list of user.
        public List<User> getCompleteUserList()
        {
            return this.users;
        }


        //Method - Update User By Id
        public User updateById(int id)
        {
            // Check whether the user exists or not.
            if(this.users.Where(i => i.Id == id) != null)
            {
                int choice = 0;
                do
                {
                    Console.WriteLine("\t---Update by options.....");
                    Console.WriteLine("\t1. Update Name.");
                    Console.WriteLine("\t2. Update Email.");
                    Console.Write("\tEnter your choice: ");
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
                            Console.Write("\tInvalid input. Please enter a valid integer:");
                        }
                    }

                    switch (choice) {
                        case 1:
                            Console.Write("\t Enter new name : ");
                            var newName = Console.ReadLine();

                            //Returns single user from the list.

                            var user = this.users.Where(user => user.Id == id).Single();
                            //var user = this.users.Where(user => user.Id == id).FirstOrDefault();     //Alternate to get the same output

                            user.Username = newName;
                            Console.WriteLine("Username Updated Successfully!!!\n");
                            return user;
                            break;
                        case 2:
                            Console.WriteLine("\t Enter new Email : ");
                            var newEmail = Console.ReadLine();

                            //Returns single user from the list.

                            var newUser = this.users.Where(i =>i.Id == id).Single();
                            newUser.Email = newEmail;
                            return newUser;
                            break;

                        default:
                            Console.WriteLine("\tInvalid Option.");
                            break;
                    }


                } while(choice!=0);
            }
            // User not found after iterating through the entire list
            Console.WriteLine("\tUser not found with the given ID.");
            return null;
        }

        // Method - Delete User By Id
        public void deleteById(int id)
        {
            var user = this.users.SingleOrDefault(user => user.Id == id);
            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine("User deleted Successfully");
            }
            else
            {
                Console.WriteLine("User does not exists!!!");
            }
        }
        
        // Method - LoginUser
        public (User , string) Login(string email)
        {
            var loginnedUser = users.SingleOrDefault(user => user.Email == email);
            if( loginnedUser != null)
            {

                Console.Write("Enter your password : ");
                var password = Console.ReadLine();
                if (loginnedUser.verifyPassword(password))
                {
                    return (loginnedUser, "LoggedIn");
                }
                else
                {
                    return (loginnedUser, "Unauthenticated");
                }
            }
            else
            {
                return (null, "UserNotFound");
            }
        }


        //Method authentication and then update.
        //public (User, string) AuthenticateAndUpdate(string email) {
            
        //}



        //public User
    }
}
