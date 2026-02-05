using MaterialSkin.Controls;
using sistema_cadastro_materiais.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_cadastro_materiais
{
    public partial class ConferenciaPainelForm: MaterialForm
    {

        public string btnClick = "";

        public ConferenciaPainelForm()
        {
            InitializeComponent();
        }

        private void ConferenciaPainelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadMaterial_Click(object sender, EventArgs e)
        {
            btnClick = "btnCadMaterial";

            this.OpenFormInPanel(new CadMaterialComprasForm(), "painelPrincipal");
        }
        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            btnClick = "btnCadUsuario";

            this.OpenFormInPanel(new RegistrarUsuarioForm(), "painelPrincipal");
        }

        //private void AtivarBotao(Button frmAtivo)
        //{
        //    foreach (Control ctrl in painelPrincipal.Controls)
        //    {
        //        ctrl.ForeColor = Color.White;
        //    }
        //
        //    Color myRgbColor = new Color();
        //    myRgbColor = Color.FromArgb(54, 71, 79);
        //
        //    frmAtivo.ForeColor = Color.Black;
        //}

        
    }
}
