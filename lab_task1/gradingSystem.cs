// See https://aka.ms/new-console-template for more information
Console.WriteLine("TASK 1");

// LAb task one- grading system
Console.Write("Enter your mark: ");

int mark;
mark = Convert.ToInt32(Console.ReadLine());

if(mark>=0 && mark<=100)
{
    if(mark<=50)
    {
        Console.WriteLine("You got F.");
        Console.Read();
    }
    else if (mark <= 55)
    {
        Console.WriteLine("You got D.");
        Console.Read();
    }
    else if (mark >= 56 && mark <= 60)
    {
        Console.WriteLine("You got D+.");
        Console.Read();
    }
    else if (mark >= 61 && mark <= 65)
    {
        Console.WriteLine("You got C.");
        Console.Read();
    }
    else if (mark >= 66 && mark <= 70)
    {
        Console.WriteLine("You got C+.");
        Console.Read();
    }
    else if (mark >= 71 && mark <= 75)
    {
        Console.WriteLine("You got B.");
        Console.Read();
    }
    else if (mark >= 76 && mark <= 80)
    {
        Console.WriteLine("You got B+.");
        Console.Read();
    }
    else if (mark >= 81 && mark <= 85)
    {
        Console.WriteLine("You got A.");
        Console.Read();
    }
    else if (mark >= 86 && mark <= 90)
    {
        Console.WriteLine("You got A+.");
        Console.Read();
    }
    else
    {
        Console.WriteLine("You got STAR A+.");
        Console.Read();
    }
}
else
{
    Console.WriteLine("You entered a invalid mark.");
    Console.Read();
}
