using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Pressao pressao = new Pressao();
            dgvPressao.DataSource = pressao.listarPressao();
            lblSistole.Text = pressao.MediaSis().ToString();
            lblDiastole.Text = pressao.MediaDias().ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSistole.Text) || string.IsNullOrEmpty(txtDiastole.Text))
            {
                MessageBox.Show("Por favor Preencha os campos!", "Campos Vazios!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Pressao pressao = new Pressao();
            int sistole = Convert.ToInt32(txtSistole.Text);
            int diastole = Convert.ToInt32(txtDiastole.Text);
            pressao.Inserir(sistole,diastole);
            dgvPressao.DataSource = pressao.listarPressao();
            lblSistole.Text = pressao.MediaSis().ToString();
            lblDiastole.Text = pressao.MediaDias().ToString();

        }
    }
}
