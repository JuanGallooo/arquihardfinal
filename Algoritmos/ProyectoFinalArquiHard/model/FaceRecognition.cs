﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
        private Bitmap imagen2;
        private Bitmap grayImage2;
        public Bitmap Imagen { get => imagen; set => imagen = value; }
        public Bitmap GrayImage { get => grayImage; set => grayImage = value; }
        public Bitmap Imagen2 { get => imagen2; set => imagen2 = value; }
        public Bitmap GrayImage2 { get => grayImage2; set => grayImage2 = value; }
        private readonly ImageConverter _imageConverter = new ImageConverter();
        public void loadData()
        {
            Console.WriteLine("Obteniendo valores...");
            try
            {
             
                    StreamWriter sw = new StreamWriter("C:\\Users\\danie\\Desktop\\Imagens1a.txt");

                 
                    //Console.WriteLine("Imagen: " + 1);
                    imagen = new Bitmap("..\\..\\data\\imgs\\s1A.jpeg");
                imagen2 = new Bitmap("..\\..\\data\\imgs\\s1B.jpeg");
                //OBTENER BITMAP PARA MOSTRAR EN WINDOWS FORM,ESCALA DE GRISES
                grayImage = createGrayScaleBitmap(imagen);
                grayImage2 = createGrayScaleBitmap(imagen2);
                // ARREGLO DE BYTES , MATRIX A UTILIZAR
                byte[,] imageBytes = createMatrix(imagen);
                byte[,] imageBytes2 = createMatrix(imagen2);

                for (int j = 0; j < 1; j++)
                    {

                        Console.WriteLine("Metodo: " + j);
                       
                        int repetitions = 1;
                        if (j == 0)
                        {
                            LBP lbp = new LBP();
                                 DistanciaChi dc= new DistanciaChi();
                            for (int k = 0; k < repetitions; k++)
                            {
                                sw.WriteLine(dc.DistanciaChiCuadrado(lbp.LBPTransformation8_1_GLocality(imageBytes ), lbp.LBPTransformation8_1_GLocality(imageBytes2)));
                            }
                        }
                        else if (j == 1)
                        {
                            LBP lbp = new LBP();
                            for (int k = 0; k < repetitions; k++)
                            {

                            sw.WriteLine(lbp.LBPTransformation8_2GLocality(imageBytes));

                        }
                        }
                        else if (j == 2)
                        {
                            LBP lbp = new LBP();
                            for (int k = 0; k < repetitions; k++)
                            {

                            sw.WriteLine(lbp.LBPTransformation16_2GLocality(imageBytes));

                        }
                        }
                       
                        
                        //or tw.Flush();
                            
                        }

                    
                    sw.Close();
                    Console.WriteLine("\n");
                
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
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
            byte[,] ret = new byte[source.Width, source.Height];
            byte[] sourceBytes = getImageBytes(source, ImageLockMode.ReadOnly, out sourceData);
            int n = 0;
            int m = 0;
            try
            {
                for (int i = 0; i < sourceBytes.Length; i += 3)
                {
                    if ((i + 3) % (source.Width * 3) > 0)
                    {
                        byte y = (byte)(sourceBytes[i + 2] * 0.3f
                                     + sourceBytes[i + 1] * 0.59f
                                     + sourceBytes[i] * 0.11f);
                        if (n < ret.GetLength(0))
                        {
                            ret[n, m] = y;
                            m += 1;
                            if (m == ret.GetLength(1) - 1)
                            {
                                m = 0;
                                n += 1;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            source.UnlockBits(sourceData);
            return ret;
        }
    }
}
