string setName = "";
string setPassword = "";
bool create = true;
while (create)
{
    Console.Write("Enter desired username: ");
    setName = Console.ReadLine();
    Console.Write("Enter password: ");
    setPassword = Console.ReadLine();
    if (setPassword.Length < 8 || setPassword.Length > 16)
    {
        Console.WriteLine("Password must be 8 - 16 characters");
        Console.ReadLine();
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Account created");
        create = false;
        Console.ReadLine();
        Console.Clear();
    }


}
bool login = true;
string getName = "";
string getPassword = "";

while (login)
{
    Console.Write("Enter your username: ");
    getName = Console.ReadLine();
    if (getName == setName)
    {
        Console.Write("Enter password: ");
        getPassword = Console.ReadLine();
        if (getPassword == setPassword)
        {
            Console.WriteLine("Login Successfully");
            Console.ReadLine();
            Console.Clear();
            login = false;
        }
        else
        {
            Console.WriteLine("Login Failed");
            Console.WriteLine("Your email or password is incorrect");
            Console.WriteLine("Please try again");
            // login = false;
            Console.ReadLine();
            Console.Clear();
        }
    }
}
