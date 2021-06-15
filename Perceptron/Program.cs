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

                w1 = r.NextDouble();
                w2 = r.NextDouble();
                umbral = r.NextDouble();

            }

        }

        public static double sigmoide(float rl)
        {
            return rl > 0 ? 1 : 0;
        }


    }
}
