// See https://aka.ms/new-console-template for more information




Console.WriteLine("Enter your age: ");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isageNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isageNumber}. User is {userAgeNum} years old");

if (isageNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to instagram.");
    }
    else
    {
        Console.WriteLine("You are too young to use instagram.");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}

