using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display Output \\ Console.WriteLine("Hello World!");
            //  Console.Write("Hello World!");
            //  Console.WriteLine("Hello World!");          //A CWL után új sor lesz
            //  Console.WriteLine("Hey");          

            // Display Output 2. \\int x = 89;
            //Console.WriteLine(x);

            // Display Output 3. \\ int x = 10;
            //double y = 20;
            //Console.WriteLine("x={0};y={1}",x,y);

            // Display Output 4. \\int a = 4;
            //int b = 2;                                    //WriteLine-val külön sorban lenne
            //Console.Write(a);
            //Console.Write(b);  

            // User Input 1. \\ string yourName;
            //Console.WriteLine("What is your name?");
            //yourName = Console.ReadLine();
            //Console.WriteLine("Hello {0}, how are you", yourName);

            // User Input 2. \\Console.WriteLine("Please enter your age!");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You are {0} years old", age);

            // Comments 1. \\ //Prints Hello
            //Console.WriteLine("Hello");

            // Comemnts 2. \\/*Some long 
            // * comment*/
            //int x = 42;
            //Console.WriteLine(x);

            // The var Keyword 1. \\ //var num  = 15;
            //Console.ReadLine();                             //Ilynekor automatikusan szám lesz
            //Console.WriteLine("{0}", num);

            // The var Keyword 2. \\ //var num = 42;             //Ez az oldalon hibás volt, de így kijavítottam
            //Console.WriteLine(num);

            // The var Keyword 2 \\ //var n1;                   //Ez error lesz
            //n1 = true;                                                
            //Console.WriteLine(n1);

            // Constants 1. \\ //const double Pi = 3.14;
            // error \\ Pi = 8;
            //Console.WriteLine(Pi);

            // Arithmetic Operators 1. \\ //int x = 10;
            //int y = 4;
            //Console.WriteLine(x-y);

            // Arithmetic Operators 2. \\int x = 101;
            //int y = 4;                          //Itt 1 lesz, hiszen 100- ban megvan 25X, de 101-ben 1 a maradék 
            //Console.WriteLine(x%y);

            // Division 1. \\ //var x = 10 / 4;
            //Console.WriteLine(x);

            // Division 2. \\ //int x = 1550;
            //int y = 4;                          //Ez csak próbálgatás
            //double z = x / y;
            //Console.WriteLine(z);

            // Modulus 1. \\ //int x = 25 % 7;      7+7+7=21 -->25-24 = 4
            //Console.WriteLine(x);

            // Operator Precedence 1.\\ //int x = 4 + 3 * 2;0                 //Itt is előnyt élvez a magasabb szintű alapművelet
            //Console.WriteLine(x);

            // Operator Precedence 2.\\ //int x = (4 + 3) * 2; //Természetesen a zárójel itt is működik
            //Console.WriteLine(x);

            Console.WriteLine("Ez egy próba");
                
       
            Console.ReadKey();

        }
    }
}
