using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ModernUISample.metro;

namespace EmporiumSystem_0._01
{
    public partial class Caixa : MetroForm
    {
        public Caixa()
        {
            InitializeComponent();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.BorderStyle = MetroFormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
