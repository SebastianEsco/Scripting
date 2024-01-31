namespace SumaImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                bool confirmo = true;
                double num1;
                Menú();
                if (num1 > 1000 || num1 < 0)
                {
                    Console.WriteLine("Ha ingresado un valor no válido. Por favor, ingrese un número entre 0 y 1000");

                }
                else
                {
                    Console.WriteLine("El resultado de sumar todos los impares hasta " + num1 + " es: " + Suma(num1));

                }

                void Menú()
                {
                    Console.WriteLine("Bienvenido. Este programa crea una lista de los impares positivos hasta un número que usted ingrese. Luego, suma dichos impares");
                    Console.WriteLine("Tenga en cuenta que este programa únicamente permite números menores a 1000");
                    Console.WriteLine("Por favor, ingrese un número hasta dónde generar la lista de impares");
                    num1 = Convert.ToDouble(Console.ReadLine());
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
    } // Colocar una condición para el ciclo infinito que no sea un bool que siempre está en true
      // La vaina con el TryPhase 

}
