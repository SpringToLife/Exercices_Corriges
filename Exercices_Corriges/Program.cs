using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_Corriges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jeu de test
            //exercices 1
            Exercice1 n = new Exercice1();
            n.Message = "Hello";
            n.Nom = "Alexandra Abramov!";
            System.Console.WriteLine("Exercice1");
            System.Console.WriteLine(n.Message);
            System.Console.WriteLine(n.Nom);
            

           //exercices 2
           Exercice2 n2 = new Exercice2();
            n2.Number = 3;
            n2.Number2 = 4;
            System.Console.WriteLine("Exercice2");
            System.Console.WriteLine(n2.Number+n2.Number2);

            //exercices 3
            Exercice2 n3 = new Exercice2();
            n3.Number = 8;
            n3.Number2 = 4;
            System.Console.WriteLine("Exercice3");
            System.Console.WriteLine(n3.Number / n3.Number2);

            //exercices 4
            Exercice2 n4 = new Exercice2();
            n4.Number = -1;
            n4.Number2 = 4;
            n4.Number3 = 6;
            System.Console.WriteLine("Exercice3");
            System.Console.WriteLine((n4.Number2 * n4.Number3)+(n4.Number));
            n4.Number = 35;
            n4.Number2 = 5;
            n4.Number3 = 7;
            System.Console.WriteLine((n4.Number + n4.Number2) /(n4.Number3));

            //Exercice 5
            int number1, number2, temp;
            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
   

            int number3, number4, number5;
            Console.Write("\nInput the First Number : ");
            number3 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number4 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Third Number : ");
            number5 = int.Parse(Console.ReadLine());
            int result = number3 * number4 * number5;
            Console.WriteLine(result);
     
            Console.Read();




            System.Console.ReadLine();
        }
    }
}
