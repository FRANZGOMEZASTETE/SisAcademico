﻿using SisAcademico.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisAcademico.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EstudianteNegocio objNegocio = new EstudianteNegocio();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objNegocio.ListarEstudiantes();
        }
    }
}
