using EY.Reinf.Object.Model;
using EY.Reinf.Validation;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EY.Reinf.Interface
{
    public partial class InfoSuspForm : Form
    {
        public InfoSuspModel model { get; set; }

        public InfoSuspForm()
        {
            InitializeComponent();
        }

        public InfoSuspForm(InfoSuspModel model)
        {
            InitializeComponent();

            codSusp_textBox.Text = model.codSusp;
            indSusp_comboBox.SelectedIndex = indSuspIndex(model.indSusp);
            dtDecisao_dtp.Value = model.dtDecisao;

            indDeposito_checkbox.SelectedIndex = indDepositoIndex(model.indDeposito);
        }

        private int indSuspIndex(string value)
        {
            List<string> tpProc = new List<string>
            {
                "01", "02", "03", "04", "05", "08", "09", "10", "11", "12", "13", "90", "92"
            };

            bool achou = false;

            try
            {
                value = value.Substring(0, 2);

                int count = -1;

                while (!achou)
                {
                    count++;
                    string temp = tpProc[count];

                    if (temp.Equals(value))
                        achou = true;
                }

                return count;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private int indDepositoIndex(string value)
        {
            try
            {
                value = value.Substring(0, 1);

                if (value.Equals("S"))
                    return 0;

                if (value.Equals("N"))
                    return 1;

                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            InfoSuspModel model = new InfoSuspModel();
            model.codSusp = codSusp_textBox.Text;
            model.indSusp = indSusp_comboBox.Text;
            model.dtDecisao = dtDecisao_dtp.Value.Date;
            model.indDeposito = indDeposito_checkbox.Text;

            ValidaInfoSusp valida = new ValidaInfoSusp();
            List<string> erros = valida.Validar(model);

            if (erros.Count == 0)
            {
                this.model = model;
                this.Close();
            }
            else
            {
                string msg = "CORRIJA OS SEGUINTES CAMPOS:\n\n";

                foreach (string erro in erros)
                    msg += erro + "\n";

                MessageBox.Show(msg);
            }
        }        
    }
}
