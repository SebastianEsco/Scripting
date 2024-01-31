namespace ConcatenarMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz;
            int n, m;


            n = RevisarSiInt("ancho");
            m = RevisarSiInt("largo");

            matriz = new string[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Escriba la letra para la posición " + i + " , " + j + " de la matriz");
                    matriz[i, j] = RevisarSiString();
                }
            } //Rellenar la matriz

            Console.WriteLine("\n\nMatriz: \n");
            MostrarMatriz(matriz, n, m);

            Console.WriteLine("\n\nMatriz Concatenada: " + ConcatenarMatriz(matriz, n, m));


        }

        static int RevisarSiInt(string opcion)
        {
            Console.WriteLine("Escriba el " + opcion + " de la matriz (numero entero mayor a 0)");

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
                        Console.WriteLine("No escribió un número o escribió un numero menor o igual a 0, vuelva a intentarlo");
                    }

                }
                catch
                {
                    Console.WriteLine("No escribió un número o escribió un numero menor o igual a 0, vuelva a intentarlo");

                }
            }


        }

        static string RevisarSiString()
        {
            while (true)
            {
                string temp = Console.ReadLine();

                try
                {
                    Convert.ToInt32(temp);
                    Console.WriteLine("No escribió una letra sino un número, vuelva a intentarlo");
                }
                catch
                {
                    return temp;

                }
            }


        }

        static void MostrarMatriz(string[,] matriz, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static string ConcatenarMatriz(string[,] matriz, int n, int m)
        {
            string matrizConcatenada = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrizConcatenada += matriz[i, j];
                }

            }
            return matrizConcatenada;
        }
    }
}
