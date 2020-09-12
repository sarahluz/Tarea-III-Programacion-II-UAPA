using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THISONE
{
    public partial class frmError : Form
    {
        public frmError(string textx)

           

        {
            InitializeComponent();

            lblError.Text = textx;
        }

        private void frmError_Load(object sender, EventArgs e)
        {
            Console.Read(); 
            while (this.Visible==true)
                {
                frmDashboard frmDashboard = new frmDashboard(Text);
                frmDashboard.Visible = false;

            }
        }
        

    private void LblError_Click(object sender, EventArgs e)
        {
            Console.Read();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmVentana frmVentana = new frmVentana(Text);
            Application.Run(mainForm:frmVentana);
        }
    }
}
