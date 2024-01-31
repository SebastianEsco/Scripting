namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opción; double número1; double número2;
            do
            {
                Menú();

                switch (opción)
                {
                    case 1:
                        Console.WriteLine("Ingrese un primer número");
                        número1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese un segundo número que dividirá al primero");
                        número2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El resultado de la operación es: " + División(número1, número2));

                        break;
                    case 2:
                        Console.WriteLine("Ingrese un número");
                        número1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El resultado de la operación es: " + Módulo(número1));

                        break;
                    case 3:
                        Console.WriteLine("Ingrese un número");
                        número1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El resultado de la operación es: " + Cuadrado(número1));

                        break;
                    case -1:
                        Console.WriteLine("Ha escogido cerrar el programa. Hasta luego");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta. Por favor escoja una opción válida");

                        break;

                }
                void Menú()
                {
                    Console.WriteLine("Bienvenido a la calculadora virtual; ¿Qué desea hacer?");
                    Console.WriteLine("División (oprima 1)");
                    Console.WriteLine("Módulo (oprima 2)");
                    Console.WriteLine("Cuadrado (oprima 3)");
                    Console.WriteLine("Salir (Ingrese -1 en el teclado para salir)");
                    opción = Convert.ToInt32(Console.ReadLine());
                }
                double División(double num1, double num2)
                {
                    double resultado;
                    resultado = num1 / num2;
                    return resultado;
                }
                double Módulo(double num1)
                {
                    if (num1 < 0)
                    {
                        num1 = num1 * -1;

                    }
                    return num1;
                }
                double Cuadrado(double num1)
                {
                    num1 = num1 * num1;
                    return num1;
                }
            }
            while (opción != -1);

        }

    }
}