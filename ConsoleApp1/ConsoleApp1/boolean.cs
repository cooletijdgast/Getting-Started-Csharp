//int coinFlip = new Random().Next(0, 2);
//Console.WriteLine((coinFlip > 0 ? "Heads" : "Tails" ));


string permission = "Manager"; //Admin | Manager
int level = 23;

Boolean admin = permission.Contains("Admin");
Boolean manager = permission.Contains("Manager");
Boolean isHighestLevel = level > 55;
Boolean isLowestLevel = level >= 20;
Boolean isLowerThan55 = level <= 55;
Boolean isLowerThan20 = level < 20;

if (admin)
{
    if (isHighestLevel)
    {
        Console.WriteLine("Welcome, Super Admin User");
    }
    else if (isLowerThan55)
    {
        Console.WriteLine("Welcome, admin user");
    }
}
else if (manager)
{
    if (isLowestLevel)
    {
        Console.WriteLine("Contact an admin for access");
    }
    else if (isLowerThan20)
    {
        Console.WriteLine("You do not have suffiecient priviliges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}