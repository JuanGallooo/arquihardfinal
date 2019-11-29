using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalArquiHard.model
{
    class LBP
    {
        public long LBPTransformation8_1_GLocality(byte[,] grayScale)
        {
            int width = grayScale.GetLength(0);
            int height = grayScale.GetLength(1);
            byte[,] nMatrix = new byte[width, height];
            byte temp = 0;
            Stopwatch wacth = new Stopwatch();
            wacth.Restart();
            wacth.Start();
            for (int i = 1; i < width - 1; i++)
            {
                for (int j = 1; j < height - 1; j++)
                {
                    byte x = grayScale[i, j];
                    byte result = 0;
                    temp = grayScale[(i - 1), (j - 1)];
                    if (x >= temp) result += 128;

                    temp = grayScale[(i - 1), (j)];
                    if (x >= temp) result += 64;

                    temp = grayScale[(i - 1), (j + 1)];
                    if (x >= temp) result += 32;

                    temp = grayScale[(i), (j + 1)];
                    if (x >= temp) result += 16;

                    temp = grayScale[(i + 1), (j + 1)];
                    if (x >= temp) result += 8;

                    temp = grayScale[(i + 1), (j)];
                    if (x >= temp) result += 4;

                    temp = grayScale[(i + 1), (j - 1)];
                    if (x >= temp) result += 2;

                    temp = grayScale[(i), (j - 1)];
                    if (x >= temp) result += 1;

                    nMatrix[i, j] = result;
                }
            }
            wacth.Stop();
           
            return (long)(wacth.Elapsed.TotalMilliseconds * 1000000);

        }
        public long LBPTransformation8_2GLocality(byte[,] grayScale)
        {
            int width = grayScale.GetLength(0);
            int height = grayScale.GetLength(1);
            byte temp = 0;
            byte[,] nMatrix = new byte[width, height];
            Stopwatch wacth = new Stopwatch();
            wacth.Restart();
            wacth.Start();
            for (int i = 2; i < width - 2; i++)
            {
                for (int j = 2; j < height - 2; j++)
                {

                    byte x = grayScale[i, j];
                    byte result = 0;

                    temp = grayScale[(i - 2), (j - 2)];
                    if (x >= temp) result += 128;

                    temp = grayScale[(i - 2), (j)];
                    if (x >= temp) result += 64;

                    temp = grayScale[(i - 2), (j + 2)];
                    if (x >= temp) result += 32;

                    temp = grayScale[(i), (j + 2)];
                    if (x >= temp) result += 16;

                    temp = grayScale[(i + 2), (j + 2)];
                    if (x >= temp) result += 8;

                    temp = grayScale[(i + 2), (j)];
                    if (x >= temp) result += 4;

                    temp = grayScale[(i + 2), (j - 2)];
                    if (x >= temp) result += 2;

                    temp = grayScale[(i), (j - 2)];
                    if (x >= temp) result += 1;

                    nMatrix[i, j] = result;
                }
            }
            wacth.Stop();
            return (long)(wacth.Elapsed.TotalMilliseconds * 1000000);

        }
        public long LBPTransformation16_2GLocality(byte[,] grayScale)
        {
            int width = grayScale.GetLength(0);
            int height = grayScale.GetLength(1);
            byte temp = 0;

            int[,] nMatrix = new int[width, height];
            Stopwatch wacth = new Stopwatch();
            wacth.Restart();
            wacth.Start();
            for (int i = 2; i < width - 2; i++)
            {
                for (int j = 2; j < height - 2; j++)
                {   
                    byte x = grayScale[i, j];
                    int result = 0;
                    temp = grayScale[(i - 2), (j - 2)];
                    if (x >= temp) result += 32768;

                    temp = grayScale[(i - 2), (j - 1)];
                    if (x >= temp) result += 16384;

                    temp = grayScale[(i - 2), (j)];
                    if (x >= temp) result += 8192;

                    temp = grayScale[(i - 2), (j + 1)];
                    if (x >= temp) result += 4096;

                    temp = grayScale[(i - 2), (j + 2)];
                    if (x >= temp) result += 2048;

                    temp = grayScale[(i - 1), (j + 2)];
                    if (x >= temp) result += 1024;

                    temp = grayScale[(i), (j + 2)];
                    if (x >= temp) result += 512;

                    temp = grayScale[(i + 1), (j + 2)];
                    if (x >= temp) result += 256;

                    temp = grayScale[(i + 2), (j + 2)];
                    if (x >= temp) result += 128;
                    
                    temp = grayScale[(i + 2), (j + 1)];
                    if (x >= temp) result += 64;

                    temp = grayScale[(i + 2), (j)];
                    if (x >= temp) result += 32;

                    temp = grayScale[(i + 2), (j - 1)];
                    if (x >= temp) result += 16;

                    temp = grayScale[(i + 2), (j - 2)];
                    if (x >= temp) result += 8;

                    temp = grayScale[(i + 1), (j - 2)];
                    if (x >= temp) result += 4;

                    temp = grayScale[(i), (j - 2)];
                    if (x >= temp) result += 2;

                    temp = grayScale[(i - 1), (j - 2)];
                    if (x >= temp) result += 1;

                    nMatrix[i, j] = result;
                }
            }
            wacth.Stop();
            return (long)(wacth.Elapsed.TotalMilliseconds * 1000000);

        }
        public long LBPTransformation8_1_BLocality(byte[,] grayScale)
        {
            int width = grayScale.GetLength(0);
            int height = grayScale.GetLength(1);
            byte temp = 0;
            byte[,] nMatrix = new byte[width, height];
            Stopwatch wacth = new Stopwatch();
            wacth.Restart();
            wacth.Start();
            for (int j = 1; j < height - 1; j++)
            {
                for (int i = 1; i < width - 1; i++)
                {
                    byte x = grayScale[i, j];
                    byte result = 0;
                    temp = grayScale[(i - 1), (j - 1)];
                    if (x >= temp) result += 128;

                    temp = grayScale[(i - 1), (j)];
                    if (x >= temp) result += 64;

                    temp = grayScale[(i - 1), (j + 1)];
                    if (x >= temp) result += 32;

                    temp = grayScale[(i), (j + 1)];
                    if (x >= temp) result += 16;

                    temp = grayScale[(i + 1), (j + 1)];
                    if (x >= temp) result += 8;

                    temp = grayScale[(i + 1), (j)];
                    if (x >= temp) result += 4;

                    temp = grayScale[(i + 1), (j - 1)];
                    if (x >= temp) result += 2;

                    temp = grayScale[(i), (j - 1)];
                    if (x >= temp) result += 1;

                    nMatrix[i, j] = result;
                }
            }
            wacth.Stop();
            return (long)(wacth.Elapsed.TotalMilliseconds * 1000000);

        }
        public long LBPTransformation8_2BLocality(byte[,] grayScale)
        {
            int width = grayScale.GetLength(0);
            int height = grayScale.GetLength(1);
            byte temp = 0;
            byte[,] nMatrix = new byte[width, height];
            Stopwatch wacth = new Stopwatch();
            wacth.Restart();
            wacth.Start();
            for (int j = 2; j < height - 2; j++)
            {
                for (int i = 2; i < width - 2; i++)
                {
                    byte x = grayScale[i, j];
                    byte result = 0;

                    temp = grayScale[(i - 2), (j - 2)];
                    if (x >= temp) result += 128;

                    temp = grayScale[(i - 2), (j)];
                    if (x >= temp) result += 64;

                    temp = grayScale[(i - 2), (j + 2)];
                    if (x >= temp) result += 32;

                    temp = grayScale[(i), (j + 2)];
                    if (x >= temp) result += 16;

                    temp = grayScale[(i + 2), (j + 2)];
                    if (x >= temp) result += 8;

                    temp = grayScale[(i + 2), (j)];
                    if (x >= temp) result += 4;

                    temp = grayScale[(i + 2), (j - 2)];
                    if (x >= temp) result += 2;

                    temp = grayScale[(i), (j - 2)];
                    if (x >= temp) result += 1;

                    nMatrix[i, j] = result;
                }
            }
            wacth.Stop();
            
            return (long)(wacth.Elapsed.TotalMilliseconds * 1000000);

        }
        public long LBPTransformation16_2BLocality(byte[,] grayScale)
        {
            int width = grayScale.GetLength(0);
            int height = grayScale.GetLength(1);
            byte temp = 0;

            int[,] nMatrix = new int[width, height];
            Stopwatch wacth = new Stopwatch();
            wacth.Restart();
            wacth.Start();
            for (int j = 2; j < height - 2; j++)
            {
                for (int i = 2; i < width - 2; i++)
                {
                    byte x = grayScale[i, j];
                    int result = 0;
                    temp = grayScale[(i - 2), (j - 2)];
                    if (x >= temp) result += 32768;

                    temp = grayScale[(i - 2), (j - 1)];
                    if (x >= temp) result += 16384;

                    temp = grayScale[(i - 2), (j)];
                    if (x >= temp) result += 8192;

                    temp = grayScale[(i - 2), (j + 1)];
                    if (x >= temp) result += 4096;

                    temp = grayScale[(i - 2), (j + 2)];
                    if (x >= temp) result += 2048;

                    temp = grayScale[(i - 1), (j + 2)];
                    if (x >= temp) result += 1024;

                    temp = grayScale[(i), (j + 2)];
                    if (x >= temp) result += 512;

                    temp = grayScale[(i + 1), (j + 2)];
                    if (x >= temp) result += 256;

                    temp = grayScale[(i + 2), (j + 2)];
                    if (x >= temp) result += 128;

                    temp = grayScale[(i + 2), (j + 1)];
                    if (x >= temp) result += 64;

                    temp = grayScale[(i + 2), (j)];
                    if (x >= temp) result += 32;

                    temp = grayScale[(i + 2), (j - 1)];
                    if (x >= temp) result += 16;

                    temp = grayScale[(i + 2), (j - 2)];
                    if (x >= temp) result += 8;

                    temp = grayScale[(i + 1), (j - 2)];
                    if (x >= temp) result += 4;

                    temp = grayScale[(i), (j - 2)];
                    if (x >= temp) result += 2;

                    temp = grayScale[(i - 1), (j - 2)];
                    if (x >= temp) result += 1;

                    nMatrix[i, j] = result;
                }
            }
            wacth.Stop();
            
            return (long)(wacth.Elapsed.TotalMilliseconds * 1000000);

        }

    }
}
