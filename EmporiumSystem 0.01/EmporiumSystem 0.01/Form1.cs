using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MetroFramework;
using Transitions;
using Modelos;



namespace EmporiumSystem_0._01
{
    public partial class FormLogin : MetroForm
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
       {
            Transition t1 = new Transition(new TransitionType_Linear(1000));
            t1.add(pictureBox1, "Top", 80);
            Transition.runChain(t1);

            metroToolTip1.SetToolTip(txtBoxUsuario, "Digite seu nome de usuário");             
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Usuario novoUsuario = new Usuario();

            if(novoUsuario.VerificarLogin(txtBoxUsuario.Text, txtBoxSenha.Text) == 1)
            {
                this.Hide();
            }
            else if (novoUsuario.VerificarLogin(txtBoxUsuario.Text, txtBoxSenha.Text) == 2)
            {
                this.Hide();
                Caixa CX = new Caixa();
                CX.ShowDialog();
            }
            else if (txtBoxUsuario.Text == "" && txtBoxSenha.Text == "")
                MetroMessageBox.Show(this, "Informe o campo Usuário e Senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtBoxUsuario.Text == "")
                MetroMessageBox.Show(this, "Informe o campo Usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtBoxSenha.Text == "")
                MetroMessageBox.Show(this, "Informe o campo Senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MetroMessageBox.Show(this, "Usuário ou Senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
