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
using MetroFramework;
using ModernUISample.metro;

namespace EmporiumSystem_0._01
{
    public partial class FormPrincipal : MetroForm
    {
        FormLogin frmLogin = new FormLogin();
        public FormPrincipal()
        {
            InitializeComponent();
            
            if (MetroUI.DesignMode == false)
            {
                MetroUI.Style.PropertyChanged += Style_PropertyChanged;
                MetroUI.Style.DarkStyle = true;                
            }
        }
        void Style_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "DarkStyle")
            {
                BackColor = MetroUI.Style.BackColor;
                Refresh();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.ShowDialog(this);
            this.Show();

         
        }  

      
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var rectangle = e.CellBounds;
            rectangle.Inflate(-1, -1);
            ControlPaint.DrawBorder3D(e.Graphics, rectangle, Border3DStyle.Flat);
            ControlPaint.DrawBorder(e.Graphics, rectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            MetroUI.Style.DarkStyle = !(MetroUI.Style.DarkStyle);
        }

        private void ribbonButtonPDV_Click(object sender, EventArgs e)
        {
            Caixa CX = new Caixa();
            CX.ShowDialog();
        } 
    
    }
}
