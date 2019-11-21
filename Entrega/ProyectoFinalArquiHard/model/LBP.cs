using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalArquiHard.model
{
    class LBP
    {
        public byte[,] LBPTransformation8_1_GLocality(byte[,] grayScale)
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
        public byte[,] LBPTransformation8_2GLocality(byte[,] grayScale)
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
            for (int i = 2; i < width - 2; i++)
            {
                for (int j = 2; j < height - 2; j++)
                {
                    uno = grayScale[(i - 2), (j - 2)];
                    dos = grayScale[(i - 2), (j)];
                    tres = grayScale[(i - 2), (j + 2)];
                    cuatro = grayScale[(i), (j + 2)];
                    cinco = grayScale[(i + 2), (j + 2)];
                    seis = grayScale[(i + 2), (j)];
                    siete = grayScale[(i + 2), (j - 2)];
                    ocho = grayScale[(i), (j - 2)];

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
        public int[,] LBPTransformation16_2GLocality(byte[,] grayScale)
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
            byte nueve = 0;
            byte diez = 0;
            byte once = 0;
            byte doce = 0;
            byte trece = 0;
            byte catorce = 0;
            byte quince = 0;
            byte dieciseis = 0;

            int[,] nMatrix = new int[width, height];
            for (int i = 2; i < width - 2; i++)
            {
                for (int j = 2; j < height - 2; j++)
                {
                    uno = grayScale[(i - 2), (j - 2)];
                    dos = grayScale[(i - 2), (j-1)];
                    tres = grayScale[(i - 2), (j)];
                    cuatro = grayScale[(i - 2), (j + 1)];
                    cinco = grayScale[(i - 2), (j + 2)];
                    seis = grayScale[(i - 1), (j + 2)];
                    siete = grayScale[(i), (j + 2)];
                    ocho = grayScale[(i + 1), (j + 2)];
                    nueve = grayScale[(i + 2), (j + 2)];
                    diez = grayScale[(i + 2), (j + 1)];
                    once = grayScale[(i + 2), (j)];
                    doce = grayScale[(i + 2), (j -1)];
                    trece = grayScale[(i + 2), (j - 2)];
                    catorce = grayScale[(i + 1), (j - 2)];
                    quince = grayScale[(i), (j - 2)];
                    dieciseis = grayScale[(i - 1), (j - 2)];

                    byte x = grayScale[i, j];
                    int result = 0;
                    if (x >= uno) result += 32768;
                    if (x >= dos) result += 16384;
                    if (x >= tres) result += 8192;
                    if (x >= cuatro) result += 4096;
                    if (x >= cinco) result += 2048;
                    if (x >= seis) result += 1024;
                    if (x >= siete) result += 512;
                    if (x >= ocho) result += 256;
                    if (x >= nueve) result += 128;
                    if (x >= diez) result += 64;
                    if (x >= once) result += 32;
                    if (x >= doce) result += 16;
                    if (x >= trece) result += 8;
                    if (x >= catorce) result += 4;
                    if (x >= quince) result += 2;
                    if (x >= dieciseis) result += 1;

                    nMatrix[i, j] = result;
                }
            }

            return nMatrix;

        }
        public byte[,] LBPTransformation8_1_BLocality(byte[,] grayScale)
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
            for (int j = 1; j < height - 1; j++)
            {
                for (int i = 1; i < width - 1; i++)
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
        public byte[,] LBPTransformation8_2BLocality(byte[,] grayScale)
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
            for (int j = 2; j < height - 2; j++)
            {
                for (int i = 2; i < width - 2; i++)
                {
                    uno = grayScale[(i - 2), (j - 2)];
                    dos = grayScale[(i - 2), (j)];
                    tres = grayScale[(i - 2), (j + 2)];
                    cuatro = grayScale[(i), (j + 2)];
                    cinco = grayScale[(i + 2), (j + 2)];
                    seis = grayScale[(i + 2), (j)];
                    siete = grayScale[(i + 2), (j - 2)];
                    ocho = grayScale[(i), (j - 2)];

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
        public int[,] LBPTransformation16_2BLocality(byte[,] grayScale)
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
            byte nueve = 0;
            byte diez = 0;
            byte once = 0;
            byte doce = 0;
            byte trece = 0;
            byte catorce = 0;
            byte quince = 0;
            byte dieciseis = 0;

            int[,] nMatrix = new int[width, height];
            for (int j = 2; j < height - 2; j++)
            {
                for (int i = 2; i < width - 2; i++)
                {
                    uno = grayScale[(i - 2), (j - 2)];
                    dos = grayScale[(i - 2), (j - 1)];
                    tres = grayScale[(i - 2), (j)];
                    cuatro = grayScale[(i - 2), (j + 1)];
                    cinco = grayScale[(i - 2), (j + 2)];
                    seis = grayScale[(i - 1), (j + 2)];
                    siete = grayScale[(i), (j + 2)];
                    ocho = grayScale[(i + 1), (j + 2)];
                    nueve = grayScale[(i + 2), (j + 2)];
                    diez = grayScale[(i + 2), (j + 1)];
                    once = grayScale[(i + 2), (j)];
                    doce = grayScale[(i + 2), (j - 1)];
                    trece = grayScale[(i + 2), (j - 2)];
                    catorce = grayScale[(i + 1), (j - 2)];
                    quince = grayScale[(i), (j - 2)];
                    dieciseis = grayScale[(i - 1), (j - 2)];

                    byte x = grayScale[i, j];
                    int result = 0;
                    if (x >= uno) result += 32768;
                    if (x >= dos) result += 16384;
                    if (x >= tres) result += 8192;
                    if (x >= cuatro) result += 4096;
                    if (x >= cinco) result += 2048;
                    if (x >= seis) result += 1024;
                    if (x >= siete) result += 512;
                    if (x >= ocho) result += 256;
                    if (x >= nueve) result += 128;
                    if (x >= diez) result += 64;
                    if (x >= once) result += 32;
                    if (x >= doce) result += 16;
                    if (x >= trece) result += 8;
                    if (x >= catorce) result += 4;
                    if (x >= quince) result += 2;
                    if (x >= dieciseis) result += 1;

                    nMatrix[i, j] = result;
                }
            }

            return nMatrix;

        }

    }
}
