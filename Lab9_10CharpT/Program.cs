// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lab#9  or  Lab#10");

//menu for user what task to run
Console.WriteLine("What task do you want to run? (1, 2, 3)");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 1:
        Console.WriteLine("Task1");
        Program1.Task1();
        break;
    case 2:
        Console.WriteLine("Task2");
        Program2.Task2();
        break;
    case 3:
        Console.WriteLine("Task3");
        Console.WriteLine("Enter 1 for Task1 or 2 for Task2");
        int taskN = Convert.ToInt32(Console.ReadLine());
        if (taskN == 1)
            Program3.Task1();
        else if (taskN == 2)
            Program3.Task2();
        else
            Console.WriteLine("Invalid input");
        break;
    case 4:
        Console.WriteLine("Task4");
        Program4.Task4();
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}
