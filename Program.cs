while (true) //while command - keep doing this forever until smth tells it to stop
{
    Console.WriteLine("Please enter your age (or 'quit' to exit): ");
    string ? input = Console.ReadLine(); //? means input can be null

    if (input == "quit") //let the user exit, == checks if two values are equal
    {
        Console.WriteLine("Goodbye!");
        break; //exits the loop
    }
    //TryParse tries to convert text input into int, returns true if worked, false if not - never crashes
    //if succesfull the coverted number is stored in age via the out keyword, ! (not)to check if failed, if it failed, ask again
    if (!int.TryParse(input, out int age)) 
    {
        Console.WriteLine("That's not a valid number. Try again.");
        continue;  //skip the rest of this iteration and start the next one - invalid input
    }

    //switch expression: matches age against a series of condition in order
    //the first condition that matches wins the rest are skipped
    // '=>' if this matches, produce this value
    // _ default, anything not caught above 
    string result = age switch
    {
        < 0 => "Invalid age",
        < 5 => "Free entry",
        < 18 => "Child ticket",
        < 65 => "Adult ticket",
        _ => "Senior ticket"
    };

    Console.WriteLine(result);
    Console.WriteLine();  
}