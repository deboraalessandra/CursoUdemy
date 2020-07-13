using System;
using System.Globalization;
using System.Threading.Channels;

namespace TopicosEspeciais
{
    class Program
    {
        static void Main(string[] args)

        {
            
            
            int x = 1;
            int y = 0;
            int z = 0;
            Console.WriteLine("==================");
            Console.WriteLine("Digite os intervalos: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("==================");
            Console.WriteLine("A sequência Fibonacci é: ");

            for (int i = 0; i < n; i++)
            {  
                z = x + y;
                Console.WriteLine(z);
               
                y = x;

               
              
                x = z;
                
                

            }
           Console.WriteLine("==========***===========");

            /*                            // SWITH CASE
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Friday";
                    break;
                 default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine("Day: " + day);*/
            /////////////////////////////
            // EXPRESSÃO CONDICIONAL TERNÁRIA
            /*  double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              double desconto = (preco > 20) ? preco * 0.1
                  : preco * 0.05;
              Console.WriteLine(desconto);*/
            /////////////////////////////


        }
    }
}
