using System;

namespace TrianguloApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float X = 0;
            float Y = 0;
            float Z = 0;

            string opção;
            string continuar;

            Console.WriteLine("Digite 1 para validar o triangulo");
            Console.WriteLine("Digite s para sair");

            opção = Console.ReadLine();

            while(opção=="1") {
                if (opção == "s")
                {
                    break;
                }

                Console.WriteLine("Escreva o lado X");
                X = float.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o lado Y");
                Y = float.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o lado Z");
                Z = float.Parse(Console.ReadLine());



                if (X < Y + Z && Y < X + Z && Z < X + Y)
                {
                    if (X == Z && Z == Y)
                    {
                        Console.WriteLine("O Triangulo é Eqüilátero");
                        
                    }
                    else if (X != Z && Z != Y && Y != X)
                    {
                        Console.WriteLine("O Triangulo é Escaleno");
                        
                    }
                    else
                    {
                        Console.WriteLine("O Triangulo é Isósceles");                  
                    }
                }
                else
                {
                    Console.WriteLine("A medida de qualquer um dos lados tem que ser menor que a soma dos outros dois lados");    
                }
                Console.WriteLine("Digite 2 para continuar");
                Console.WriteLine("Digite s para sair");
                continuar = Console.ReadLine();
                if (continuar == "2")
                {
                    Console.Clear();
                    continue;
                }
            }

        }
    }
}
