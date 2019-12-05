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

            int arriba2 = 0;
            int frente2 = 0;
            int izquierda2 = 0;

            int sumaCaras = 0;

            Console.WriteLine("              Dado en C#\n-------------------------------------------\nPresione enter para una nueva visualización\n-------------------------------------------");

            void rand()
            {
                Random random = new Random();
                arriba = random.Next(1, 7);
                frente = random.Next(1, 7);
                if ((frente == arriba) || (frente == 7 - arriba))
                {
                    while ((frente == arriba) || (frente == 7 - arriba))
                    {
                        frente = random.Next(1, 7);
                    }
                }

                izquierda = random.Next(1, 7);
                if ((izquierda == arriba) || (izquierda == frente) || (izquierda == 7 - arriba) || (izquierda == 7 - frente))
                {
                    while ((izquierda == arriba) || (izquierda == frente) || (izquierda == 7 - arriba) || (izquierda == 7 - frente))
                    {
                        izquierda = random.Next(1, 7);
                    }
                }


            }
            void rand2()
            {
                Random random = new Random();
                frente2 = random.Next(1, 7);
                while (frente2 == frente)
                {
                    frente2 = random.Next(1, 7);
                }

                arriba2 = random.Next(1, 7);
                if ((arriba2 == frente2) || (7 - arriba2 == frente2))
                {
                    while ((arriba2 == frente2) || (7 - arriba2 == frente2))
                    {
                        arriba2 = random.Next(1, 7);
                    }
                }

                izquierda2 = random.Next(1, 7);
                if ((izquierda2 == arriba2) || (izquierda2 == frente2) || (izquierda2 == 7 - arriba2) || (izquierda2 == 7 - frente2))
                {
                    while ((izquierda2 == arriba2) || (izquierda2 == frente2) || (izquierda2 == 7 - arriba2) || (izquierda2 == 7 - frente2))
                    {
                        izquierda2 = random.Next(1, 7);
                    }
                }
            }
            void dibujar()
            {
                Console.WriteLine("-------------- Dado 1 ---------------");
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
            void dibujar2()
            {
                Console.WriteLine("-------------- Dado 2 ---------------");
                Console.WriteLine("                    ########");
                Console.WriteLine("                    #      #");
                Console.WriteLine("                    #   {0}  #", arriba2);
                Console.WriteLine("                    #      #");
                Console.WriteLine("####################        ########");
                Console.WriteLine("#         #         #      #       #");
                Console.WriteLine("#  {0}      #   {1}     #  {2}   #   {3}   #", 7 - frente2, izquierda2, frente2, 7 - izquierda2);
                Console.WriteLine("#         #         #      #       #");
                Console.WriteLine("####################        ########");
                Console.WriteLine("                    #      #");
                Console.WriteLine("                    #   {0}  #", 7 - arriba2);
                Console.WriteLine("                    #      #");
                Console.WriteLine("                    ########");
            }
            int suma(int cara1, int cara2)
            {
                sumaCaras = cara1 + cara2;
                return sumaCaras;
            }
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                rand();
                dibujar();
                rand2();
                dibujar2();
                Console.WriteLine("La suma de las caras frontales es: {0}", suma(frente, frente2));
                Console.WriteLine("              Dado en C#\n-------------------------------------------\nPresione enter para una nueva visualización\n-------------------------------------------");

            }
            Console.ReadLine();

        }
    }
}
