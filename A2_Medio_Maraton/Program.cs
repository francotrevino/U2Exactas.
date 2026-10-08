using System;

namespace A2_Medio_Maraton
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia = 0;
            int zancada = 0;

            while (distancia < 21000)
            {
                distancia += 0.63;
                zancada =+ 1;
            }
            Console.WriteLine($"Diana dio: {zancada} zancadas")
        }
    }
}
