﻿using System;
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
            FaceRecognition main = new FaceRecognition();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
