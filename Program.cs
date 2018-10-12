using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresa primer numero
            Console.WriteLine("Ingresame un numerito pa' sumar");
            int NUM1= int.Parse(Console.ReadLine());
            //Ingresa segundo numero
            Console.WriteLine("Ingresame otro numerito pa' sumar");
            int NUM2 =int.Parse(Console.ReadLine()); //Transforma int a Objeto
            //Llama a la funcion suma
            Console.WriteLine(SumaNum (NUM1, NUM2));
            RestaNum (NUM1, NUM2);
            MultNum (NUM1, NUM2);
            Console.WriteLine(DivNum (NUM1, NUM2));

        }

        private static int SumaNum(int VAR1 , int VAR2)
        {
            int SUMA;
            SUMA = VAR1 + VAR2;
            return SUMA;
        }
        private static void RestaNum(int VAR1 , int VAR2)
        {
            int RESTA;
            RESTA = VAR1 - VAR2;
            Console.WriteLine($"La resta de los numeros es {RESTA}");
        }
        private static void MultNum(int VAR1 , int VAR2){
            int MULT;
            MULT = VAR1 * VAR2;
            Console.WriteLine("La multiplicacion de los numeros es : " + MULT);
        }
        private static float DivNum(int VAR1 , int VAR2){
            if (VAR2 != 0)
            {
                float DIV;
                DIV = VAR1/VAR2;
                Console.WriteLine($"La division de los numeros es: ");
                return DIV;
            } else{
                Console.WriteLine("No es posible realizar la division");
                return 0;
            }

        }
        
    }
}
