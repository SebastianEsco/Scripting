namespace SumaImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1;
                Menú();
                if (num1 > 1000 || num1 < 0)
                {
                    Console.WriteLine("Ha ingresado un valor no válido. Por favor, ingrese un número entre 0 y 1000");

                }
                else
                {
                    Console.WriteLine("El resultado de sumar todos los impares hasta " + num1 + " es: " + Suma(num1));
                    break;

                }

                void Menú()
                {
                    Console.WriteLine("Bienvenido. Este programa crea una lista de los impares positivos hasta un número que usted ingrese. Luego, suma dichos impares");
                    Console.WriteLine("Tenga en cuenta que este programa únicamente permite números menores a 1000");
                    Console.WriteLine("Por favor, ingrese un número hasta dónde generar la lista de impares");
                    num1 = RevisarSiDouble();
                }
                double Suma(double numero)
                {
                    double suma = -1;
                    double conteo = 0;
                    if (numero % 2 == 0)
                    {
                        while (suma != (numero - 1))
                        {
                            suma = suma + 2;
                            conteo = conteo + suma;
                        }
                        return conteo;

                    }
                    else
                    {

                        while (suma != (numero))
                        {
                            suma = suma + 2;
                            conteo = conteo + suma;
                        }
                        return conteo;
                    }


                }
            }
            while (true);

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
                    Console.WriteLine("No escribió un número o escribió un numero vàlido, vuelva a intentarlo");

                }
            }


        }
    } 

}
