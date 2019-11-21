using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;

namespace ProyectoFinalArquiHard.model
{
    class FaceRecognition
    {

        public FaceRecognition()
        {
            //imagen = (Bitmap)_imageConverter.ConvertFrom(File.ReadAllBytes("..\\..\\data\\imgs\\boy.jpeg"));
        }

        private Bitmap imagen;
        private Bitmap grayImage;

        public Bitmap Imagen { get => imagen; set => imagen = value; }
        public Bitmap GrayImage { get => grayImage; set => grayImage = value; }

        private readonly ImageConverter _imageConverter = new ImageConverter();
        public void loadData()
        {
            Console.WriteLine("Obteniendo valores...");
            try
            {

                imagen = new Bitmap("..\\..\\data\\imgs\\girl.jpeg");
                //OBTENER BITMAP PARA MOSTRAR EN WINDOWS FORM,ESCALA DE GRISES

                grayImage = createGrayScaleBitmap(imagen);
                // ARREGLO DE BYTES , MATRIX A UTILIZAR
                byte[,] imageBytes = createMatrix(imagen);

                int[,] binary = LBPTransformation16_2GLocality(imageBytes);

                //for (int i = 0; i < imageBytes.GetLength(0); i++)
                //{
                //    for (int j = 0; j < imageBytes.GetLength(1); j++)
                //    {
                //       // Console.WriteLine("matrix[{0},{1}] = {2}", i, j, imageBytes[i, j]);
                //    }
                //}
                StreamWriter sw = new StreamWriter("..\\..\\data\\imagen.txt");
                //for (int i = 0; i < imageBytes.GetLength(0); i++)
                //{
                //    for (int j = 0; j < imageBytes.GetLength(1); j++)
                //    {
                //        //Console.WriteLine("matrix[{0},{1}] = {2}", i, j, imageBytes[i, j]);
                //        sw.Write(imageBytes[i, j]+ " ");

                //        if ((j + 1) == imageBytes.GetLength(1))
                //        {
                //            sw.Write("\n");
                //            Console.WriteLine("Entro");
                //        }
                //    }
                //}
                for (int i = 0; i < binary.GetLength(0); i++)
                {
                    for (int j = 0; j < binary.GetLength(1); j++)
                    {
                        //Console.WriteLine("matrix[{0},{1}] = {2}", i, j, imageBytes[i, j]);
                        sw.Write(binary[i, j] + " ");

                        if ((j + 1) == binary.GetLength(1))
                        {
                            sw.Write("\n");
                        }
                    }
                }


            }
            catch (Exception e) 
            {
                Console.WriteLine("Error "+ e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("Terminado");
        }

        private byte[] getImageBytes(Bitmap image, ImageLockMode lockMode, out BitmapData bmpData)
        {
            bmpData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                     lockMode, image.PixelFormat);
            byte[] imageBytes = new byte[bmpData.Stride * image.Height];
            Marshal.Copy(bmpData.Scan0, imageBytes, 0, imageBytes.Length);

            return imageBytes;
        }

        private Bitmap createGrayScaleBitmap(Bitmap source)
        {
            Bitmap target = new Bitmap(source.Width, source.Height, source.PixelFormat);
            BitmapData targetData, sourceData;

            byte[] sourceBytes = getImageBytes(source, ImageLockMode.ReadOnly, out sourceData);
            byte[] targetBytes = getImageBytes(target, ImageLockMode.ReadWrite, out targetData);
            //recorrer los pixeles
            for (int i = 0; i < sourceBytes.Length; i += 3)
            {
                //ignorar el padding, es decir solo procesar los bytes necesarios
                if ((i + 3) % (source.Width * 3) > 0)
                {
                    //Hallar tono gris
                    byte y = (byte)(sourceBytes[i + 2] * 0.3f
                                 + sourceBytes[i + 1] * 0.59f
                                 + sourceBytes[i] * 0.11f);
                    //Asignar tono gris a cada byte del pixel
                    targetBytes[i + 2] = targetBytes[i + 1] = targetBytes[i] = y;

                }
            }

            Marshal.Copy(targetBytes, 0, targetData.Scan0, targetBytes.Length);

            source.UnlockBits(sourceData);
            target.UnlockBits(targetData);

            return target;
        }
        private byte[,] createMatrix(Bitmap source)
        {
            BitmapData sourceData;

            byte[,] ret = new byte[source.Width,source.Height];

            byte[] sourceBytes = getImageBytes(source, ImageLockMode.ReadOnly, out sourceData);

            int n = 0;
            int m = 0;
            Console.WriteLine(ret.GetLength(1));
            Console.WriteLine(sourceBytes.Length/3);
            for (int i = 0; i < sourceBytes.Length; i += 3)
            {
                if ((i + 3) % (source.Width * 3) > 0)
                {
                    byte y = (byte)(sourceBytes[i + 2] * 0.3f
                                 + sourceBytes[i + 1] * 0.59f
                                 + sourceBytes[i] * 0.11f);
                        ret[n, m] = y;
                        m += 1;
                        if (m == ret.GetLength(1) - 1)
                        {
                            m = 0;
                            n += 1;
                        }
                    
                }
            }
            source.UnlockBits(sourceData);


            return ret;
        }
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
