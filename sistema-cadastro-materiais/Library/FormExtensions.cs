using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_cadastro_materiais.Library
{
    public static class FormExtensions
    {
        public static void OpenFormInPanel(this Form parentForm, Form newForm, string panelName)
        {
            //procura o painel pela string panelName            
            var panel = parentForm.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == panelName);


            //checa se o painel foi encontrado
            if (panel == null)
            {
                MessageBox.Show("Nome do painel não encontrado no codigo");
            }

            //apaga forms anteriores limpando o painel
            foreach(Control ctr in panel.Controls)
            {
                if(ctr is Form form)
                {
                    form.Close();
                    form.Dispose();
                }
            }
            panel.Controls.Clear();

            //configura o form novo que sera inserido no painel
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            panel.Controls.Add(newForm);
            newForm.Show();
        }
        public static void CleanBoxesInForm(this Form form)
        {
            foreach (Control control in form.Controls)
            {
                if(control is TextBox || control is ComboBox || control is MaskedTextBox)
                {
                    control.Text = "";
                }
                else if(control is GroupBox)
                {
                    foreach(Control control1 in control.Controls)
                    {
                        if (control1 is TextBox || control1 is ComboBox || control1 is MaskedTextBox)
                        {
                            control1.Text = "";
                        }
                    }
                }
            }
        }
    }
}
