Console.Write("Please enter your age: ");
string? input = Console.ReadLine();

if (!int.TryParse(input, out int age))
{
    Console.WriteLine("That's not a valid number. Please run the program again and enter a whole number.");
    return;
}

string result = age switch
{
    < 0 => "Invalid age",
    < 5 => "Free entry",
    < 18 => "Child ticket",
    < 65 => "Adult ticket",
    _ => "Senior ticket"
};

Console.WriteLine(result);