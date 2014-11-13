using MetroFramework;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;


namespace EmporiumSystem_0._01
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Transition t1 = new Transition(new TransitionType_Linear(1000));
            t1.add(pictureBox1, "Top", 80);
            Transition.runChain(t1);

            metroToolTip1.SetToolTip(metroTextBox1, "Digite seu nome de usuário");             
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "" && metroTextBox2.Text == "")
                MetroMessageBox.Show(this, "Informe o campo Usuário e Senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (metroTextBox1.Text == "")
                MetroMessageBox.Show(this, "Informe o campo Usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (metroTextBox2.Text == "")
                MetroMessageBox.Show(this, "Informe o campo Senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
