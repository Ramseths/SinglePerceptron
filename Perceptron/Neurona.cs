using System;
using System.Collections.Generic;
using System.Text;

namespace Perceptron
{
    class Neurona
    {
        // Método para devolver el valor de la neurona
        public static double NeuronaValor(double x1, double x2, double w1, double w2, double umbral)
        {
            return umbral + x1 * w1 + x2 * w2;
        }
    }
}
