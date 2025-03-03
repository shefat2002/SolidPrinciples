using SRP;

UserService userService = new(); 

Console.Write("Please enter username: ");
string name = Console.ReadLine();
Console.Write("Please enter email: ");
string email = Console.ReadLine();

userService.UserRegistration(name, email);