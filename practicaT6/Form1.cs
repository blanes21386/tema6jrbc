﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaT6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, apellidos, telefono;

            nombre = tNombre.Text;
            apellidos = tApellidos.Text;
            telefono = tTelefono.Text;

            tListaSocios.Text = tListaSocios.Text + nombre + " " + apellidos + " " + telefono + " " + "\r\n";

        }
    }
}
