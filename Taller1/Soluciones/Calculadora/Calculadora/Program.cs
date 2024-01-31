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
                        número1 = RevisarSiDouble();
                        Console.WriteLine("Ingrese un segundo número que dividirá al primero");
                        número2 = RevisarSiDouble();
                        Console.WriteLine("El resultado de la operación es: " + División(número1, número2));

                        break;
                    case 2:
                        Console.WriteLine("Ingrese un número");
                        número1 = RevisarSiDouble();
                        Console.WriteLine("El resultado de la operación es: " + Módulo(número1));

                        break;
                    case 3:
                        Console.WriteLine("Ingrese un número");
                        número1 = RevisarSiDouble();
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
                    opción = RevisarSiInt();
                }
                double División(double num1, double num2)
                {
                    if(num2 != 0)
                    {
                        double resultado;
                        resultado = num1 / num2;
                        return resultado;
                    }
                    else
                    {
                        Console.WriteLine("División por 0 no es valida.");
                        return 0;
                    }
                    
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

        static int RevisarSiInt()
        {
            while (true)
            {
                string temp = Console.ReadLine();

                try
                {
                    Convert.ToInt32(temp);
                    if (Convert.ToInt32(temp) != 0)
                    {
                        return Convert.ToInt32(temp);
                    }
                    else
                    {
                        Console.WriteLine("No escribió un número o escribió una opción no válida");
                    }

                }
                catch
                {
                    Console.WriteLine("No escribió un número o escribió escribió una opción no válida");

                }
            }


        }


        static double RevisarSiDouble()
        {
            while (true)
            {
                string temp = Console.ReadLine();

                try
                {
                    Convert.ToDouble(temp);
                    return Convert.ToDouble(temp);
                }
                catch
                {
                    Console.WriteLine("No escribió un número o escribió un numero menor o igual a 0, vuelva a intentarlo");

                }
            }


        }

    }
}