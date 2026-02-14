namespace Account
{
    public class Class1
    {
        static void main(String[] args)
        {
            Console.WriteLine("ACCOUNT MANAGEMENT SYSTEM");
            string username="Naige123";
            string password="Amarantheia123";

            Console.WriteLine("Username: ");
            string usernameINP = Console.ReadLine();
            Console.WriteLine("Password: ");
            string passwordINP = Console.ReadLine();

            if(usernameINP ==username && passwordINP == password)
            {
                Console.WriteLine("Login Succesful");
            }
            else
            {
                Console.WriteLine("Incorrect Credentials");
                Console.WriteLine("Test");
            }

        }
    }
}
