using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(CargaArticulo)) 
                    return;
                
            }
            CargaArticulo ventana = new CargaArticulo();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Baja))
                    return;

            }
            Baja ventana = new Baja();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
