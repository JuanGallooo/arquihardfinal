using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalArquiHard.model
{
    class DistanciaChi
    {

        public void DistanciaChiCuadrado(byte[,] imagen1, byte[,] imagen2)
        {
            int width = imagen1.GetLength(0);
            int length = imagen2.GetLength(1);
            double result = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    int x = imagen1[i, j];
                    int y = imagen2[i, j];

                    double dist = ((x - y) ^ 2) / (x + y);

                    result += dist;

                }
            }
        }
    }
}
