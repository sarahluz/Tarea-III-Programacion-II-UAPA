using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Por Sarah del Rosario
//201908650
//Ing. en Software
//Programacion II tarea III
namespace THISONE
{
    public partial class frmVentana : Form
    {
        public frmVentana()
        {
            InitializeComponent();
        }

        public frmVentana(string text)
        {
            Text = text;
        }

        public  void btnGuardar_Click(object sender, EventArgs e)
  
        {
            string username = txtUsuario.Text;
            string password = txtpassword.Text;
            string errorx = string.Format("Ningun campo puede estar vacio");
            if (txtpassword.TextLength == 0)
            {
                frmError frmerror = new frmError(errorx);
                frmerror.Visible = true;

            }

            if (txtUsuario.TextLength == 0)
            {
                frmError frmError = new frmError(errorx);
                frmError.Visible = true;
                
            }

            
            //{
                //frmdashboard.Visible = false;
            //}

            else

                this.Hide();
           frmDashboard frmDashboard = new frmDashboard(Text);
            frmDashboard.Visible = true;

           
            
           

            //frmDashboard frmDashboard = new frmDashboard();
            // Not Close()!
            // frmDashboard frmDashboard = new frmDashboard(Text);
            //frmDashboard.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

            //Final de la aplicacion
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Run();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        { }  
    }
}
