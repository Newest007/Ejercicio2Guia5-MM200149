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
        }

        private void NotasEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtnota1.Text);
            double nota2 = Convert.ToDouble(txtnota2.Text);
            double periodo1 = (nota1 + nota2) / 2;
            txtperiodo1.Text = Convert.ToString(periodo1);
            double nota3 = Convert.ToDouble(txtnota3.Text);
            double nota4 = Convert.ToDouble(txtnota4.Text);
            double periodo2 = (nota3 + nota4) / 2;
            txtperiodo2.Text = Convert.ToString(periodo2);
            double nota5 = Convert.ToDouble(txtnota5.Text);
            double nota6 = Convert.ToDouble(txtnota6.Text);
            double nota7 = Convert.ToDouble(txtnota7.Text);
            double periodo3 = (nota5 + nota6 + nota7) / 3;
            txtperiodo3.Text = Convert.ToString(periodo3);

        }
    }
}
