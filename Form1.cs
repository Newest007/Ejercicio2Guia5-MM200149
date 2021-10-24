using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ejercicio2___Guía5_MM200149
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            DateTime fechanacimiento = dateTimePicker1.Value;
            int años = System.DateTime.Now.Year - fechanacimiento.Year;

            if (años <= 0) 
            {
                MessageBox.Show("Debe de colocar una fecha de nacimiento válida","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Los datos se han ingresado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*txtcarnet.Clear();
                txtcorreo.Clear();
                txtnombre.Clear();
                txtresponsables.Clear();
                */
                NotasEstudiante notasestudiante = new NotasEstudiante();
                this.Hide();
                notasestudiante.Show();
                notasestudiante.label2.Text = txtnombre.Text;
            }

            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }


            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }


            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }


            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtnombre, "Debe de ingresar el nombre del estudiante");
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtresponsables_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }


            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }


            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            

            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtresponsables, "Debe de ingresar el nombre del responsable");
            }
        }


        /*public static bool validarEmail(string email)
        {
            string expresion = "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$";

            if(Regex.IsMatch(email,expresion))
            {
                if(Regex.Replace(email,expresion,string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        */


        //Otra manera y da el mismo resultado
        static bool validarEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }

            catch
            {
                return false;
            }

        }

        private void BorrarMensajesError()
        {
            errorProvider1.SetError(txtnombre, "");
            errorProvider1.SetError(txtcorreo, "");
            errorProvider1.SetError(txtresponsables, "");
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if (validarEmail(txtcorreo.Text)) { }
            
            else
            {
                errorProvider1.SetError(txtcorreo, "Dirección de correo no válido");
                txtcorreo.SelectAll();
                txtcorreo.Focus();
            }


        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
