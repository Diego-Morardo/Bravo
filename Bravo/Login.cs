using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bravo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }       

        private void Login_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }

        public void cargarCombo()
        {
            comboRol.Items.Add("Encargado de Guardia");
            comboRol.Items.Add("Jefe de cuerpo Activo");
            comboRol.Items.Add("Bombero");
            comboRol.Items.Add("Encargado de Intervención");
            comboRol.SelectedIndex = 0;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            var rol = comboRol.SelectedItem.ToString();
            
            Home home = new Home(txtUser.Text, rol);            
            home.Show();

            this.Close();
        }
    }
}
