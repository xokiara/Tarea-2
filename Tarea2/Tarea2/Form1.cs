using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            //Validación 
            if (Nota1TextBox.Text == "")
            {
                errorProvider1.SetError(Nota1TextBox, "Ingrese calificación");
                return;
            }

            if (Nota2TextBox.Text == "")
            {
                errorProvider1.SetError(Nota2TextBox, "Ingrese calificación");
                return;
            }

            if (Nota3TextBox.Text == "")
            {
                errorProvider1.SetError(Nota3TextBox, "Ingrese calificación");
                return;
            }

            if (Nota4TextBox.Text == "")
            {
                errorProvider1.SetError(Nota4TextBox, "Ingrese calificación");
                return;
            }

            //Limpiar errores 
            errorProvider1.Clear();

            //Variables
            decimal nota1 = Convert.ToDecimal(Nota1TextBox.Text);
            decimal nota2 = Convert.ToDecimal(Nota2TextBox.Text);
            decimal nota3 = Convert.ToDecimal(Nota3TextBox.Text);
            decimal nota4 = Convert.ToDecimal(Nota4TextBox.Text);

            decimal total = await PromedioFinalAsync(nota1, nota2, nota3, nota4);

            //Mostrar resultado del promedio final
            MessageBox.Show($"El Promedio Final es: {total}");

        }

        //Función Asíncrona Promedio Final
        private async Task<decimal> PromedioFinalAsync(decimal n1, decimal n2, decimal n3, decimal n4) 
        {
            decimal promedio = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;
            });
            return promedio;
        }
    }
}
