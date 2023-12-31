﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoTierraMedia
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            solicitarPrestamo.Enabled = false;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close(); //Application.Exit() sería una mejor opción, porque evita que el proceso siga corriendo aunque la ventana se haya cerrado.
        }

        private void solicitarPrestamo_Click(object sender, EventArgs e)
        {
            using (Prestamos ventanaPrestamos = new Prestamos(nombre.Text))
                ventanaPrestamos.ShowDialog();
        }




        private void controlBotones()
        {
            if (nombre.Text.Trim() != string.Empty && nombre.Text.All(Char.IsLetter))
            {
                solicitarPrestamo.Enabled = true;
                errorProvider1.SetError(nombre, "");
            }
            else
            {
                if (!(nombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(nombre, "El nombre sólo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(nombre, "Debe introducir su nombre");
                }
                solicitarPrestamo.Enabled = false;
                nombre.Focus();
            }
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
    }
}