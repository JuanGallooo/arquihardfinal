using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalArquiHard.model
{
    class LBP
    {
        public byte[,] LBPTransformation8_1_GLocal(byte[,] grayScale)
        {
            int width = grayScale.GetLength(0);
            int height = grayScale.GetLength(1);
            byte uno = 0;
            byte dos = 0;
            byte tres = 0;
            byte cuatro = 0;
            byte cinco = 0;
            byte seis = 0;
            byte siete = 0;
            byte ocho = 0;
            byte[,] nMatrix = new byte[width, height];
            for (int i = 1; i < width - 1; i++)
            {
                for (int j = 1; j < height - 1; j++)
                {
                    uno = grayScale[(i - 1), (j - 1)];
                    dos = grayScale[(i - 1), (j)];
                    tres = grayScale[(i - 1), (j + 1)];
                    cuatro = grayScale[(i), (j + 1)];
                    cinco = grayScale[(i + 1), (j + 1)];
                    seis = grayScale[(i + 1), (j)];
                    siete = grayScale[(i + 1), (j - 1)];
                    ocho = grayScale[(i), (j - 1)];

                    byte x = grayScale[i, j];
                    byte result = 0;
                    if (x >= uno) result += 128;
                    if (x >= dos) result += 64;
                    if (x >= tres) result += 32;
                    if (x >= cuatro) result += 16;
                    if (x >= cinco) result += 8;
                    if (x >= seis) result += 4;
                    if (x >= siete) result += 2;
                    if (x >= ocho) result += 1;

                    nMatrix[i, j] = result;
                }
            }

            return nMatrix;

        }
        public byte[,] LBPTransformation8_2(byte[,] grayScale)
        {
            int width = grayScale.GetLength(0);
            int height = grayScale.GetLength(1);
            for (int i = 2; i < width - 2; i++)
            {
                for (int j = 2; j < height - 2; j++)
                {

                }
            }

        }
        public byte[,] LBPTransformation16_2(byte[,] grayScale)
        {
            int width = grayScale.GetLength(0);
            int height = grayScale.GetLength(1);
            for (int i = 2; i < width - 2; i++)
            {
                for (int j = 2; j < height - 2; j++)
                {

                }
            }

        }

    }
}
