
//Console application?
//Ask user for their name?
//Welcome Tim and TIM as professor?
//Welcome anyone else as student?

string? firstName = null;

Console.WriteLine("Welcome to the application: WelcomeProfessor");
Console.WriteLine("This application was created by: Justin Spencer");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

Console.Write("What is your first name? ");
firstName = Console.ReadLine();
firstName = firstName?.ToLower();

switch (firstName)
{
    case "tim":
    case "timothy":
        Console.WriteLine("Welcome, Professor.");
        //(firstName == "Tim" || firstName == "TIM" || firstName == "tim")

        //    {
        //        Console.WriteLine("Welcome, Professor.");
        //    }
        //    default
        //    {
        //        Console.WriteLine("Welcome, student.");
        //    }
        break;
    default:
        Console.WriteLine("Welcome, student.");
        break;
}

//if (firstName == "Tim" || firstName == "TIM" || firstName == "tim")
//{
//    Console.WriteLine("Welcome, Professor.");
//}
//else
//{
//    Console.WriteLine("Welcome, student.");
//}
