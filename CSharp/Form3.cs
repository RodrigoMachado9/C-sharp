using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            int idade;
            string nome_usuario;
            idade = int.Parse(txtIdade.Text);
            nome_usuario = txtUsuario.Text;

            bool bool_usuario = idade > 18 ? true : false;
            if (bool_usuario)
            {
                MessageBox.Show($"Entrada liberada para o sr. {nome_usuario}");
            }
            else {
                MessageBox.Show($"Entrada bloqueada\nUsuario: {nome_usuario} menor de idade.");

            
            }

        }
    }
}
