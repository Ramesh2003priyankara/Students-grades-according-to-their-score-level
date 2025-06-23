using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Enter your marks:");
        int marks =Convert.ToInt32(Console.ReadLine());


        if (marks >= 75)
        {
            Console.WriteLine("Grade A");
        }
        else if (65 <= marks)
        {
            Console.WriteLine("Grade B");
        }
        else if (marks >= 55)
        {
            Console.WriteLine("Grade c");
        }
        else if (marks >= 35)
        {
            Console.WriteLine("Grade S");
        }
        else 
        {
            Console.WriteLine("Garde W");
        }


    }
}