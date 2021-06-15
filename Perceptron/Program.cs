using System;

namespace Perceptron
{
    class Program
    {
        static void Main(string[] args)
        {
            // Weights de la ANN
            double w1, w2;
            double umbral;

            Random r = new Random();
            bool state = false;
            // Comprobar los weights
            while (!state)
            {
                state = true;

                w1 = r.NextDouble() - r.NextDouble();
                w2 = r.NextDouble() - r.NextDouble();
                umbral = r.NextDouble() - r.NextDouble();

                // Resultados
                Console.WriteLine("\n ###################");
                Console.WriteLine("W1 = {0}", w1);
                Console.WriteLine("W2 = {0}", w2);
                Console.WriteLine("Umbral = {0}", umbral);
                Console.WriteLine("X. Valor = 1 | 1 = {0}", sigmoide(Neurona.NeuronaValor(1, 1, w1, w2, umbral)));
                Console.WriteLine("X. Valor = 1 | 0 = {0}", sigmoide(Neurona.NeuronaValor(1, 0, w1, w2, umbral)));
                Console.WriteLine("X. Valor = 0 | 1 = {0}", sigmoide(Neurona.NeuronaValor(0, 1, w1, w2, umbral)));
                Console.WriteLine("X. Valor = 0 | 0 = {0}", sigmoide(Neurona.NeuronaValor(0, 0, w1, w2, umbral)));

                // Primera comprobación AND 1 | 1 = 1
                if (sigmoide(Neurona.NeuronaValor(1, 1, w1, w2, umbral)) != 1)
                {
                    state = false;
                }

                // Segunda comprobación AND 1 | 0 = 0
                if (sigmoide(Neurona.NeuronaValor(1, 0, w1, w2, umbral)) != 0)
                {
                    state = false;
                }

                // Tercera comprobación AND 0 | 1 = 0
                if (sigmoide(Neurona.NeuronaValor(0, 1, w1, w2, umbral)) != 0)
                {
                    state = false;
                }

                // Cuarta comprobación AND 0 | 0 = 0
                if (sigmoide(Neurona.NeuronaValor(0, 0, w1, w2, umbral)) != 0)
                {
                    state = false;
                }

            }
        }

        public static double sigmoide(double rl)
        {
            return rl > 0 ? 1 : 0;
        }

    }
}
