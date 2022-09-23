using System;
class Kalkulator
{
    static void Main(string[] args)
    {
        //Choose action
        Console.WriteLine("Enter the action to be performed");
        Console.WriteLine("Press 1 for Adition (+)");
        Console.WriteLine("Press 2 for Subtraction (-)");
        Console.WriteLine("Press 3 for Multiplication (*)");
        Console.WriteLine("Press 4 for Division (/)");
        Console.WriteLine("");
        int Action = Convert.ToInt32(Console.ReadLine());

        //Check input was right number
        if (Action >= 1 && Action <= 4){
            //Input first number and second number
            Console.WriteLine("Enter 1st Input");
            float First_number = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Input");
            float Second_number = float.Parse(Console.ReadLine());

            //run method
            Hitung(First_number,Second_number,Action);
        }
        else{
            Console.WriteLine("Wrong input");
        }
    }

    static void Hitung(float num1, float num2, int Action)
    {
        float hasil = 0;
        if (Action == 1){
            hasil = num1 + num2;
        }
        else if (Action == 2){
            hasil = num1 - num2;
        }
        else if (Action == 3){
            hasil = num1 * num2;
        }
        else if (Action == 4){
            hasil = num1 / num2;
        }

        if (Action >= 1 && Action <= 4){
            Console.WriteLine("The Result is "+hasil);
        }
    
    Console.ReadKey();
    }
}


