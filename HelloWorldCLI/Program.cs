using System;


namespace firstcode
{
     
    {
        static void Main(string[] args)
        {
            int attempts = 3;
            bool loggedin = false;


            while (attempts > 0 && !loggedin)
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (username == "Admin" && password == "Admin1234!")
                {
                    Console.WriteLine("Login successful!");
                    loggedin = true;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password. ");
                    attempts--;
                }

                if (attempts > 0)
                {
                    Console.WriteLine($"You have {attempts} attempts.");
                }
            }
        }
    }

}
