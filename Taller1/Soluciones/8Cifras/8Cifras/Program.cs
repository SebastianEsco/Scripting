namespace _8Cifras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            numero = RevisarSiDouble();
            Console.WriteLine("Digito final = " + SumaDeDigitos(numero));
        }
        static int SumaDeDigitos(double numero)
        {
            int sumaActual;
            
            while (true)
            {
                sumaActual = 0;
                char[] caracteres = Convert.ToString(numero).ToCharArray();
                
                foreach (char c in caracteres)
                { 
                    sumaActual += Convert.ToInt32(c) - 48;
                }
                numero = sumaActual;
                if (sumaActual < 9)
                {
                    return sumaActual;
                }
            }
        }

        static double RevisarSiDouble()
        {
            Console.WriteLine("Escriba un número de maximo 8 cifras");

            while (true)
            {
                string temp = Console.ReadLine();

                try
                {
                    Convert.ToDouble(temp);
                    if (Convert.ToDouble(temp) <= 99999999)
                    {
                        return Convert.ToDouble(temp);
                    }
                    
                }
                catch
                {
                    Console.WriteLine("No escribió un número o escribió un numero de más de 8 cifras");

                }
            }


        }
    }
}