﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetApp
{
    public partial class frmNewPet : Form
    {
        public frmNewPet()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtén los valores ingresados en los campos de texto y controles de fecha.
            string alias = txtAlias.Text;
            string especie = txtespecie.Text;
            string raza = txtRaza.Text;
            string color = txtColor.Text;
            DateTime fechaNacimiento = dtFechaNacimiento.Value;

            // Verifica si alguno de los campos obligatorios está vacío.
            if (string.IsNullOrEmpty(alias) || string.IsNullOrEmpty(especie) || string.IsNullOrEmpty(raza)
                || string.IsNullOrEmpty(color) || CmbNombre.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios y seleccione un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si faltan campos obligatorios.
            }

            using (var db = new PetAppContext())
            {
                // Obtén el ID del cliente seleccionado en el ComboBox
                int IdCliente = (int)CmbNombre.SelectedValue;

                var nuevaMascota = new Mascota()
                {
                    Alias = alias,
                    Especie = especie,
                    Raza = raza,
                    ColorPelo = color,
                    FechaNacimiento = fechaNacimiento,
                    IdCliente = IdCliente // Asigna el ID del cliente seleccionado
                };

                db.Mascota.Add(nuevaMascota);
                db.SaveChanges();

                MessageBox.Show("Nueva mascota registrada exitosamente.");
            }

            // Limpia los campos de texto después de guardar la mascota.
            txtAlias.Clear();
            txtespecie.Clear();
            txtRaza.Clear();
            txtColor.Clear();
            dtFechaNacimiento.Value = DateTime.Now;
        }

    }
}
