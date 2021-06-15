using System;
using System.Collections.Generic;
using System.Text;

namespace Perceptron
{
    class Neurona
    {
        double w1, w2, x1, x2, umbral;
        // Constructor para iniciar la neurona
        public Neurona(double x1, double x2, double w1, double w2, double umbral)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.w1 = w1;
            this.w2 = w2;
            this.umbral = umbral;
        }

        // Método para devolver el valor de la neurona
        public double Valor()
        {
            return umbral + x1 * w1 + x2 * w2;
        }
    }
}
