using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2___Guía5_MM200149
{
    public partial class NotasEstudiante : Form
    {
        public NotasEstudiante()
        {
            InitializeComponent();
            label15.Text = mascaraForm.Text;
        }

        private void NotasEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtnota1.Text == label15.Text || txtnota2.Text == label15.Text || txtnota3.Text == label15.Text) 
            {
                MessageBox.Show("No debe de dejar ninguna nota vacía, si el estudiante se saco 0 coloquelo de igual manera", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                if (txtnota1.Text.Contains(" ") || txtnota2.Text.Contains(" ") || txtnota3.Text.Contains(" "))
                {
                    MessageBox.Show("El promedio de las notas se desarrollara pero los espacios en blanco se tomarán como ceros", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                double nota1 = Convert.ToDouble(txtnota1.Text);
                double nota2 = Convert.ToDouble(txtnota2.Text);
                double nota3 = Convert.ToDouble(txtnota3.Text);


                double notafinal = (nota1 + nota2 + nota3) / 3;
                txtnotaFinal.Text = Convert.ToString(notafinal);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmincial = new FrmPrincipal();
            this.Hide();
            frmincial.Show();

        }
    }
}
