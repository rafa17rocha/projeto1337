using EY.Reinf.Object.Model;
using EY.Reinf.Validation;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EY.Reinf.Interface
{
    public partial class SoftHouseForm : Form
    {
        public SoftHouseModel model { get; set; }

        public SoftHouseForm()
        {
            InitializeComponent();
        }

        public SoftHouseForm(SoftHouseModel model)
        {
            InitializeComponent();

            softCttCNPJ_textbox.Text = model.cnpjSoftHouse;
            softCttRazaoSocial_textbox.Text = model.nmRazao;
            softCttNome_textbox.Text = model.nmCont;
            softCttTelFixo_textbox.Text = model.telefone;
            softCttEmail_textbox.Text = model.email;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SoftHouseModel model = new SoftHouseModel();
            model.cnpjSoftHouse = maskedRaw(softCttCNPJ_textbox);
            model.nmRazao = softCttRazaoSocial_textbox.Text;
            model.nmCont = softCttNome_textbox.Text;
            model.telefone = maskedRaw(softCttTelFixo_textbox);
            model.email = softCttEmail_textbox.Text;

            ValidaSoftHouse valida = new ValidaSoftHouse();
            List<string> erros = valida.Validar(model);

            if(erros.Count == 0)
            {
                this.model = model;
                this.Close();
            }
            else
            {
                string msg = "CORRIJA OS SEGUINTES CAMPOS:\n\n";

                foreach(string erro in erros)
                    msg += erro + "\n";

                MessageBox.Show(msg);
            }
        }

        private string maskedRaw(MaskedTextBox mtb)
        {
            mtb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string saida = mtb.Text;
            mtb.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return saida;
        }
    }
}
