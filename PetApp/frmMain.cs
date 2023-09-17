using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNewUser = new frmNewUser();
            frmNewUser.MdiParent = this;
            frmNewUser.Show();
        }

        private void mascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNewPet = new frmNewPet();
            frmNewPet.MdiParent = this;
            frmNewPet.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMantoUsuarios = new frmMantoUsuarios();
            frmMantoUsuarios.MdiParent = this;
            frmMantoUsuarios.Show();
        }


        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmClientes = new frmClientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();

        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDePesoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
