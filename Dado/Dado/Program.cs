using System;

namespace Dado
{
    class Program
    {
        static void Main(string[] args)
        {
            int arriba = 0;
            int frente = 0;
            int izquierda = 0;

            Console.WriteLine("              Dado en C#\n-------------------------------------------\nPresione enter para una nueva visualización\n-------------------------------------------");

            void rand()
            {
                Random random = new Random();
                arriba = random.Next(1, 7);
                frente = random.Next(1, 7);
                if((frente == arriba) || (frente == 7-arriba))
                {
                    while ((frente == arriba) || (frente == 7 - arriba))
                    {
                        frente = random.Next(1, 7);
                    }
                }
                
                izquierda = random.Next(1, 7);
                if((izquierda == arriba) || (izquierda == frente) || (izquierda == 7-arriba) || (izquierda == 7 - frente))
                {
                    while ((izquierda == arriba) || (izquierda == frente) || (izquierda == 7 - arriba) || (izquierda == 7 - frente))
                    {
                        izquierda = random.Next(1, 7);
                    }
                }
                
                
            }
            void dibujar()
            {
                Console.WriteLine("                    ########");
                Console.WriteLine("                    #      #");
                Console.WriteLine("                    #   {0}  #", arriba);
                Console.WriteLine("                    #      #");
                Console.WriteLine("####################        ########");
                Console.WriteLine("#         #         #      #       #");
                Console.WriteLine("#  {0}      #   {1}     #  {2}   #   {3}   #", 7 - frente, izquierda, frente, 7 - izquierda);
                Console.WriteLine("#         #         #      #       #");
                Console.WriteLine("####################        ########");
                Console.WriteLine("                    #      #");
                Console.WriteLine("                    #   {0}  #", 7 - arriba);
                Console.WriteLine("                    #      #");
                Console.WriteLine("                    ########");

            }
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                rand();
                dibujar();

            }

            Console.ReadLine();
        }
    }
}
