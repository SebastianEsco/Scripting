namespace ArreglosDeNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo;
            int contador = 0;
            int n = RevisarSiInt();
            arreglo = new int[n];
            var rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arreglo[i] = rnd.Next(1, 100);
            }

            do
            {
                if (contador == 0)
                {
                    Console.Write("n = " + n + " [");
                }

                Console.Write(arreglo[contador]);

                if(contador < n - 1)
                {
                    Console.Write(", ");
                }


                contador++;

                if (contador == n)
                {
                    Console.Write("]");
                }
            }while (contador < n);
        }

        static int RevisarSiInt()
        {
            Console.WriteLine("Escriba un número entero");

            while (true)
            {
                string temp = Console.ReadLine();

                try
                {
                    Convert.ToInt32(temp);
                    return Convert.ToInt32(temp);

                }
                catch
                {
                    Console.WriteLine("No escribió un número entero");

                }
            }


        }
    }
}