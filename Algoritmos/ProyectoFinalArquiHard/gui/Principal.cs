using ProyectoFinalArquiHard.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalArquiHard
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            FaceRecognition main = new FaceRecognition();
            main.loadData();
            this.pictureLocal.Image = main.Imagen;
            this.pictureGrises.Image = main.GrayImage;
        }
    }
}
