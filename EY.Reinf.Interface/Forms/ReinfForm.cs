using EY.Reinf.Facede;
using EY.Reinf.Interface.Forms;
using EY.Reinf.Object.Enumeracoes;
using EY.Reinf.Object.Model;
using EY.Reinf.Validation;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EY.Reinf.Interface
{
    public partial class ReinfForm : Form
    {

        public ReinfForm()
        {
            InitializeComponent();
        }

        bool situacaoPJObrigatorio = false;
        bool cnpjErfObrigatorio = false;

        public static List<string> ErrorMessages = new List<string>();

        private void TipoInscricao_Changed(object sender, EventArgs e)
        {
            switch(tpInsc_comboBox.SelectedIndex)
            {
                case 0:
                    numInsc_textBox.Text = "CNPJ";
                    nrInsc_textBox.Mask = "00.000.000/0000-00";
                    indSitPJ_comboBox.Enabled = true;
                    situacaoPJObrigatorio = true;
                    break;
                case 1:
                    numInsc_textBox.Text = "CPF";
                    nrInsc_textBox.Mask = "000.000.000-00";
                    indSitPJ_comboBox.SelectedIndex = -1;
                    indSitPJ_comboBox.Enabled = false;
                    situacaoPJObrigatorio = false;
                    break;
            }
        }

        private void ideEFR_Changed(object sender, EventArgs e)
        {
            switch(efr_combobox.SelectedIndex)
            {
                case 0:
                    efrCnpj_textbox.Enabled = false;
                    cnpjErfObrigatorio = false;
                    break;
                case 1:
                    efrCnpj_textbox.Enabled = true;
                    cnpjErfObrigatorio = true;
                    break;
            }
        }

        private void ReinfForm_Load(object sender, EventArgs e)
        {
            List<UfModel> ufs = new List<UfModel>
            {
                new UfModel("AC", 12),
                new UfModel("AL", 27),
                new UfModel("AP", 16),
                new UfModel("AM", 13),
                new UfModel("BA", 29),
                new UfModel("CE", 23),
                new UfModel("DF", 53),
                new UfModel("ES", 32),
                new UfModel("GO", 52),
                new UfModel("MA", 21),
                new UfModel("MT", 51),
                new UfModel("MS", 50),
                new UfModel("MG", 31),
                new UfModel("PA", 15),
                new UfModel("PB", 25),
                new UfModel("PR", 41),
                new UfModel("PE", 26),
                new UfModel("PI", 22),
                new UfModel("RJ", 33),
                new UfModel("RN", 24),
                new UfModel("RS", 43),
                new UfModel("RO", 11),
                new UfModel("RR", 14),
                new UfModel("SC", 42),
                new UfModel("SP", 35),
                new UfModel("SE", 28),
                new UfModel("TO", 17),
                new UfModel("EX", 99)
            };

            ufVara_comboBox.DisplayMember = "sigla";
            ufVara_comboBox.ValueMember = "codigo";

            ufVara_comboBox.Items.AddRange(ufs.ToArray());

            // DATA GRID VIEW - SOFTHOUSE
            SoftHouseGridView.ColumnCount = 5;
            SoftHouseGridView.Columns[0].Name = "CNPJ";
            SoftHouseGridView.Columns[1].Name = "Razão Social";
            SoftHouseGridView.Columns[2].Name = "Contato";
            SoftHouseGridView.Columns[3].Name = "Telefone";
            SoftHouseGridView.Columns[4].Name = "Email";
            SoftHouseGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // DATA GRID VIEW - INFO SUSP
            InfoSuspGridView.ColumnCount = 4;
            InfoSuspGridView.Columns[0].Name = "Código";
            InfoSuspGridView.Columns[1].Name = "Indicativo";
            InfoSuspGridView.Columns[2].Name = "Data";
            InfoSuspGridView.Columns[3].Name = "Depósito";
            InfoSuspGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SoftHouseGridView_add(SoftHouseModel model)
        {
            SoftHouseGridView.Rows.Add(model.cnpjSoftHouse, model.nmRazao, model.nmCont, model.telefone, model.email);
        }

        private void InfoSuspGridView_add(InfoSuspModel model)
        {
            InfoSuspGridView.Rows.Add(model.codSusp, model.indSusp, model.dtDecisao, model.indDeposito);
        }

        private void UFmudou(object sender, EventArgs e)
        {
            codMunic_comboBox.Items.Clear();

            ComboBox combo = (ComboBox) sender;
            UfModel uf = (UfModel) combo.SelectedItem;

            MunicipioFacede facede = new MunicipioFacede();
            List<MunicipioModel> municipios = facede.RetornaDadosMunicipiosFacede(uf.codigo);

            codMunic_comboBox.DisplayMember = "nome";
            codMunic_comboBox.ValueMember = "codigo";

            object[] x = municipios.ToArray();

            codMunic_comboBox.Items.AddRange(x);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Enum.Parse(typeof(EventosReinf), tabControl1.SelectedTab.Name))
                {
                    case EventosReinf.R1000: SalvaR1000(); break;
                    case EventosReinf.R1070: SalvaR1070(); break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao converter o nome da tab para enum");
            }
        }

        //private void EventoR1000()
        //{
        //    //R1000 r = new R1000();
        //    R1000Model r1000 = new R1000Model();
        //    r1000.contato = new ContatoModel();
        //    r1000.softwareHouse = new List<SoftHouseModel>();

        //    PegaR1000(r1000);

        //    ValidaR1000 validarR1000 = new ValidaR1000();
        //    List<string> erros = validarR1000.Validar(r1000);

        //    string msg = "";

        //    foreach(string erro in erros)
        //    {
        //        msg += erro + "\n";
        //    }

        //    if(!string.IsNullOrEmpty(msg))
        //        MessageBox.Show("CORRIJA OS SEGUINTES CAMPOS:\n\n" + msg);
        //    else
        //    {
        //        R1000Facede facede = new R1000Facede();
        //        facede.AdicionarR1000Facede(r1000);
        //        MessageBox.Show("Registro salvo com sucesso!");
        //    }
        //}

        private void SalvaR1000() // SIMULACAO
        {
            //R1000 r = new R1000();
            R1000Model r1000 = new R1000Model();

            r1000.contato = new ContatoModel();
            r1000.softwareHouse = new List<SoftHouseModel>();

            r1000.tpAmb = "1";
            r1000.classTrib = "1";
            r1000.indEscrituracao = "1";
            r1000.indDesoneracao = "0";
            r1000.indAcordoIsenMulta = "0";
            r1000.procEmi = "2";
            r1000.verProc = "1.3";
            r1000.tpInsc = "1";
            r1000.nrInsc = "12312312312312";
            r1000.iniValid = DateTime.Now;
            r1000.fimValid = DateTime.Now;

            r1000.indSitPJ = "3";
            r1000.ideEFR = "S";
            r1000.cnpjEFR = "12312312312312";

            r1000.TipoOperacao = "1";
            r1000.DataHoraGeracaoEvento = DateTime.Now;

            r1000.contato.cpfCtt = "12332112312";
            r1000.contato.email = "fu@lano.com";
            r1000.contato.nmCtt = "Fu Lano";
            r1000.contato.foneFixo = "1199999999";
            r1000.contato.foneCel = "11999999999";


            r1000.softwareHouse = SoftHouseGridViewToList();

            r1000.IdentificacaoUnica = "0";

            //ValidaR1000 validarR1000 = new ValidaR1000();
            List<string> erros = null; // validarR1000.Validar(r1000);

            string msg = "";

            //foreach(string erro in erros)
            //{
            //    msg += erro + "\n";
            //}

            if(!string.IsNullOrEmpty(msg))
                MessageBox.Show("CORRIJA OS SEGUINTES CAMPOS:\n\n" + msg);
            else
            {
                R1000Facede facede = new R1000Facede();
                facede.AdicionarR1000Facede(r1000);
                MessageBox.Show("Registro salvo com sucesso!");
            }
        }

        private void SalvaR1070()
        {
            //R1070 r = new R1070();
            R1070Model r1070 = new R1070Model();
            r1070.infoSusp = new List<InfoSuspModel>();

            PegaR1070(r1070);

            r1070.infoSusp = InfoSuspGridViewToList();

            ValidaR1070 validarR1070 = new ValidaR1070();
            List<string> erros = validarR1070.Validar(r1070);

            string msg = "";

            foreach(string erro in erros)
            {
                msg += erro + "\n";
            }

            if(!string.IsNullOrEmpty(msg))
                MessageBox.Show("CORRIJA OS SEGUINTES CAMPOS:\n\n" + msg);
            else
            {
                R1070Facede facede = new R1070Facede();
                facede.AdicionarR1070Facede(r1070);
                MessageBox.Show("Registro salvo com sucesso!");
            }
        }

        private void PegaR1000(R1000Model r1000)
        {
            r1000.tpAmb = tpAmb_comboBox.Text;
            r1000.classTrib = classTrib_comboBox.Text;
            r1000.indEscrituracao = indEscrituracao_comboBox.Text;
            r1000.indDesoneracao = indDesoneracao_comboBox.Text;
            r1000.indAcordoIsenMulta = indAcordoIsenMulta_comboBox.Text;
            r1000.procEmi = procEmi_comboBox.Text;
            r1000.verProc = verProc_textBox.Text;
            r1000.tpInsc = tpInsc_comboBox.Text;
            r1000.nrInsc = maskedRaw(nrInsc_textBox);
            r1000.iniValid = iniValid_dateTimePicker.Value.Date;
            r1000.fimValid = fimValid_dateTimePicker.Value.Date;

            r1000.indSitPJ = indSitPJ_comboBox.Text;
            r1000.ideEFR = efr_combobox.Text;
            r1000.cnpjEFR = maskedRaw(efrCnpj_textbox);

            r1000.TipoOperacao = tipOper_comboBox.Text;
            r1000.DataHoraGeracaoEvento = DateTime.Now;

            r1000.contato.cpfCtt = maskedRaw(cpfCtt_textBox);
            r1000.contato.email = email_Ctt_textBox.Text;
            r1000.contato.nmCtt = nmCtt_textBox.Text;
            r1000.contato.foneFixo = maskedRaw(foneFixo_Ctt_textBox);
            r1000.contato.foneCel = maskedRaw(foneCel_Ctt_textBox);

            //r1000.softwareHouse.cnpjSoftHouse = maskedRaw(softCttCNPJ_textbox);
            //r1000.softwareHouse.email = softCttEmail_textbox.Text;
            //r1000.softwareHouse.nmCont = softCttNome_textbox.Text;
            //r1000.softwareHouse.nmRazao = softCttRazaoSocial_textbox.Text;
            //r1000.softwareHouse.telefone = maskedRaw(softCttTelFixo_textbox);

            //r1000.IdContato = 0;
            //r1000.IdSoftwareHouse = 0;
            r1000.IdentificacaoUnica = "0";
        }

        private void PegaR1070(R1070Model r1070)
        {
            r1070.tpAmb = tpAmb_comboBox.Text;
            r1070.procEmi = procEmi_comboBox.Text;
            r1070.verProc = verProc_textBox.Text;
            r1070.tpInsc = tpInsc_comboBox.Text;

            r1070.nrInsc = maskedRaw(nrInsc_textBox);
            r1070.tpProc = tpProc_comboBox.Text;
            r1070.nrProc = nrProc_textBox.Text;
            r1070.iniValid = iniValidProc_dtp.Value.Date;
            r1070.fimValid = fimValidProc_dtp.Value.Date;
            r1070.indAutoria = indAutoria_comboBox.Text;
            //r1070.codSusp = codSusp_textBox.Text;
            //r1070.indSusp = indSusp_comboBox.Text;
            //r1070.dtDecisao = dtDecisao_dtp.Value.Date;
            //r1070.indDeposito = indDeposito_checkbox.Text;
            r1070.ufVara = ufVara_comboBox.Text;

            MunicipioModel mu = (MunicipioModel) codMunic_comboBox.SelectedItem;

            if(mu != null)
                r1070.codMunic = mu.codigo;

            r1070.idVara = idVara_textBox.Text;
            r1070.TipoOperacao = tipOper_comboBox.Text;

            r1070.DataHoraGeracaoEvento = DateTime.Now;
            r1070.IdentificacaoUnica = "0";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                EventosReinf evento = (EventosReinf) Enum.Parse(typeof(EventosReinf), tabControl1.SelectedTab.Name);

                PesquisarForm pesquisar = new PesquisarForm(evento);
                pesquisar.ShowDialog(this);

                if (string.IsNullOrEmpty(pesquisar.IdEvento))
                    return;

                int id = Convert.ToInt32(pesquisar.IdEvento);

                switch (evento)
                {
                    case EventosReinf.R1000: PesquisarR1000(id); break;
                    case EventosReinf.R1070: PesquisarR1070(id); break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao converter o nome da tab para enum");
            }

            //btnTransmitirProcesso.Enabled = true;

        }

        private void PesquisarR1000(int id)
        {
            R1000Facede facede = new R1000Facede();
            R1000Model model = facede.RetornaDadosR1000Facede(id);

            PopularR1000(model);
        }

        private void PesquisarR1070(int id)
        {
            R1070Facede facede = new R1070Facede();
            R1070Model model = facede.RetornaDadosR1070Facede(id);

            PopularR1070(model);
        }

        private void PopularR1000(R1000Model r1000)
        {
            tpAmb_comboBox.SelectedIndex = ProcuraIndiceComboBox(tpAmb_comboBox, r1000.tpAmb);
            classTrib_comboBox.SelectedIndex = ProcuraIndiceComboBox(classTrib_comboBox, r1000.classTrib);
            indEscrituracao_comboBox.SelectedIndex = ProcuraIndiceComboBox(indEscrituracao_comboBox, r1000.indEscrituracao);
            indDesoneracao_comboBox.SelectedIndex = ProcuraIndiceComboBox(indDesoneracao_comboBox, r1000.indDesoneracao);
            indAcordoIsenMulta_comboBox.SelectedIndex = ProcuraIndiceComboBox(indAcordoIsenMulta_comboBox, r1000.indAcordoIsenMulta);
            procEmi_comboBox.SelectedIndex = ProcuraIndiceComboBox(procEmi_comboBox, r1000.procEmi);
            verProc_textBox.Text = r1000.verProc;
            tpInsc_comboBox.SelectedIndex = ProcuraIndiceComboBox(tpInsc_comboBox, r1000.tpInsc);
            nrInsc_textBox.Text = r1000.nrInsc;

            iniValid_dateTimePicker.Value = r1000.iniValid;
            fimValid_dateTimePicker.Value = r1000.fimValid;

            indSitPJ_comboBox.SelectedIndex = ProcuraIndiceComboBox(indSitPJ_comboBox, r1000.indSitPJ);
            efr_combobox.SelectedIndex = ProcuraIndiceComboBox(efr_combobox, r1000.ideEFR);
            efrCnpj_textbox.Text = r1000.cnpjEFR;
            tipOper_comboBox.SelectedIndex = ProcuraIndiceComboBox(tipOper_comboBox, r1000.TipoOperacao);

            cpfCtt_textBox.Text = r1000.contato.cpfCtt;
            email_Ctt_textBox.Text = r1000.contato.email;
            nmCtt_textBox.Text = r1000.contato.nmCtt;
            foneFixo_Ctt_textBox.Text = r1000.contato.foneFixo;
            foneCel_Ctt_textBox.Text = r1000.contato.foneCel;

            ListToSoftHouseGridView(r1000.softwareHouse);

            //softCttCNPJ_textbox.Text = r1000.softwareHouse[0].cnpjSoftHouse;
            //softCttEmail_textbox.Text = r1000.softwareHouse[0].email;
            //softCttNome_textbox.Text = r1000.softwareHouse[0].nmCont;
            //softCttRazaoSocial_textbox.Text = r1000.softwareHouse[0].nmRazao;
            //softCttTelFixo_textbox.Text = r1000.softwareHouse[0].telefone;

            //softCttCNPJ_textbox.Text = r1000.softwareHouse.cnpjSoftHouse;
            //softCttEmail_textbox.Text = r1000.softwareHouse.email;
            //softCttNome_textbox.Text = r1000.softwareHouse.nmCont;
            //softCttRazaoSocial_textbox.Text = r1000.softwareHouse.nmRazao;
            //softCttTelFixo_textbox.Text = r1000.softwareHouse.telefone;
        }

        private void PopularR1070(R1070Model r1070)
        {
            tpAmb_comboBox.SelectedIndex = ProcuraIndiceComboBox(tpAmb_comboBox, r1070.tpAmb);
            procEmi_comboBox.SelectedIndex = ProcuraIndiceComboBox(procEmi_comboBox, r1070.procEmi);
            verProc_textBox.Text = r1070.verProc;
            tpInsc_comboBox.SelectedIndex = ProcuraIndiceComboBox(tpInsc_comboBox, r1070.tpInsc);
            nrInsc_textBox.Text = r1070.nrInsc;

            tipOper_comboBox.SelectedIndex = ProcuraIndiceComboBox(tipOper_comboBox, r1070.TipoOperacao);

            iniValid_dateTimePicker.Value = r1070.iniValid;
            fimValid_dateTimePicker.Value = r1070.fimValid;

            tpProc_comboBox.SelectedIndex = ProcuraIndiceComboBox(tpProc_comboBox, r1070.tpProc);

            nrProc_textBox.Text = r1070.nrProc;

            indAutoria_comboBox.SelectedIndex = ProcuraIndiceComboBox(indAutoria_comboBox, r1070.indAutoria);

            ufVara_comboBox.SelectedIndex = ProcuraIndiceComboBox(ufVara_comboBox, r1070.ufVara);
            codMunic_comboBox.SelectedIndex = ProcuraIndiceMunicipioComboBox(codMunic_comboBox, r1070.codMunic);
            idVara_textBox.Text = r1070.idVara;

            ListToInfoSuspGridView(r1070.infoSusp);
        }

        private int ProcuraIndiceComboBox(ComboBox cb, string valor)
        {
            int tamanho = -1;

            try
            {
                int v = Convert.ToInt32(valor);



                bool tamanhoEncontrado = false;


                for (int i = 0; i < cb.Items.Count; i++)
                {
                    // LOCALIZA NOS VALORES DO COMBOBOX, ATÉ ONDE VAI OS NUMEROS
                    if (!tamanhoEncontrado)
                    {
                        string s = cb.GetItemText(cb.Items[i]);

                        try
                        {
                            for (int x = 1; x < s.Length; x++)
                            {
                                string k = s.Substring(0, x);
                                Convert.ToInt32(k);
                                tamanho = x;
                            }
                        }
                        catch (Exception)
                        {
                            tamanhoEncontrado = true;
                        }
                    }

                    string item = cb.GetItemText(cb.Items[i]).Substring(0, tamanho);
                    int itemInt = Convert.ToInt32(item);

                    if (v == itemInt)
                        return i;
                }
            }
            catch (Exception) { }

            // SE TAMANHO = -1, SIGNIFICA QUE:
            // OU NAO ENCONTROU CORRESPONDENCIA,
            // OU OS VALORES DO COMBOBOX NAO COMECA COM NUMERO
            // LOGO, TENTAR PESQUISAR POR CHAR:

            if (tamanho == -1)
            {
                try
                {
                    for (int i = 0; i < cb.Items.Count; i++)
                    {
                        string s = cb.GetItemText(cb.Items[i]);

                        string item = cb.GetItemText(cb.Items[i]).Substring(0, 1);

                        if (valor.Equals(item))
                            return i;
                    }
                }
                catch (Exception) { }
            }

            // SE TAMANHO = -1, SIGNIFICA QUE:
            // NÃO ENCONTROU COM 1 CHAR, LOGO TENTAR COM 2 CHARS

            if (tamanho == -1)
            {
                try
                {
                    for (int i = 0; i < cb.Items.Count; i++)
                    {
                        string s = cb.GetItemText(cb.Items[i]);

                        string item = cb.GetItemText(cb.Items[i]).Substring(0, 2);

                        if (valor.Equals(item))
                            return i;
                    }
                }
                catch (Exception) { }
            }

            return tamanho;
        }

        private int ProcuraIndiceMunicipioComboBox(ComboBox cb, string valor)
        {
            try
            {
                for (int i = 0; i < cb.Items.Count; i++)
                {
                    if (((MunicipioModel)cb.Items[i]).codigo.Equals(valor))
                        return i;
                }
            }
            catch (Exception)
            {
            }

            return -1;
        }

        private string maskedRaw(MaskedTextBox mtb)
        {
            mtb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string saida = mtb.Text;
            mtb.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return saida;
        }

        private void btnAdicionarSoftHouse_Click(object sender, EventArgs e)
        {
            SoftHouseForm softHouseForm = new SoftHouseForm();
            softHouseForm.ShowDialog(this);

            SoftHouseModel softHouseModel = softHouseForm.model;

            if(softHouseModel != null)
                SoftHouseGridView_add(softHouseModel);
        }

        private void btnAtualizarSoftHouse_Click(object sender, EventArgs e)
        {
            int index = -1;

            if (SoftHouseGridView.CurrentCell != null)
                index = SoftHouseGridView.CurrentCell.RowIndex;

            if (index != -1)
            {
                SoftHouseModel model = new SoftHouseModel();

                model.cnpjSoftHouse = SoftHouseGridView.Rows[index].Cells[0].Value.ToString();
                model.nmRazao = SoftHouseGridView.Rows[index].Cells[1].Value.ToString();
                model.nmCont = SoftHouseGridView.Rows[index].Cells[2].Value.ToString();
                model.telefone = SoftHouseGridView.Rows[index].Cells[3].Value.ToString();
                model.email = SoftHouseGridView.Rows[index].Cells[4].Value.ToString();

                SoftHouseForm form = new SoftHouseForm(model);
                form.ShowDialog(this);

                if(form.model != null)
                {
                    model = form.model;
                    SoftHouseGridView.Rows[index].Cells[0].Value = model.cnpjSoftHouse;
                    SoftHouseGridView.Rows[index].Cells[1].Value = model.nmRazao;
                    SoftHouseGridView.Rows[index].Cells[2].Value = model.nmCont;
                    SoftHouseGridView.Rows[index].Cells[3].Value = model.telefone;
                    SoftHouseGridView.Rows[index].Cells[4].Value = model.email;
                }
            }
        }

        private void btnExlcuirSoftHouse_Click(object sender, EventArgs e)
        {
            int index = -1;

            if(SoftHouseGridView.CurrentCell != null)
                index = SoftHouseGridView.CurrentCell.RowIndex;

            if (index != -1)
            {
                if (MessageBox.Show("Deseja excluir esta linha?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SoftHouseGridView.Rows.RemoveAt(index);
                }
            }
        }

        private List<SoftHouseModel> SoftHouseGridViewToList()
        {
            List<SoftHouseModel> lista = new List<SoftHouseModel>();

            foreach (DataGridViewRow row in SoftHouseGridView.Rows)
            {
                SoftHouseModel model = new SoftHouseModel();

                if (row.Cells[0].Value != null)
                {
                    model.cnpjSoftHouse = row.Cells[0].Value.ToString();
                    model.nmRazao = row.Cells[1].Value.ToString();
                    model.nmCont = row.Cells[2].Value.ToString();
                    model.telefone = row.Cells[3].Value.ToString();
                    model.email = row.Cells[4].Value.ToString();

                    lista.Add(model);
                }
            }

            return lista;
        }

        private List<InfoSuspModel> InfoSuspGridViewToList()
        {
            List<InfoSuspModel> lista = new List<InfoSuspModel>();

            foreach (DataGridViewRow row in InfoSuspGridView.Rows)
            {
                InfoSuspModel model = new InfoSuspModel();

                if (row.Cells[0].Value != null)
                {
                    model.codSusp = row.Cells[0].Value.ToString();
                    model.indSusp = row.Cells[1].Value.ToString();
                    model.dtDecisao = Convert.ToDateTime(row.Cells[2].Value);
                    model.indDeposito = row.Cells[3].Value.ToString();
                    lista.Add(model);
                }
            }

            return lista;
        }

        private void ListToSoftHouseGridView(List<SoftHouseModel> lista)
        {
            foreach (SoftHouseModel soft in lista)
                SoftHouseGridView_add(soft);
        }

        private void ListToInfoSuspGridView(List<InfoSuspModel> lista)
        {
            foreach (InfoSuspModel info in lista)
                InfoSuspGridView_add(info);
        }

        private void btnAdicionarInfoSusp_Click(object sender, EventArgs e)
        {
            InfoSuspForm infoSuspForm = new InfoSuspForm();
            infoSuspForm.ShowDialog(this);

            InfoSuspModel infoSuspModel = infoSuspForm.model;

            if (infoSuspModel != null)
                InfoSuspGridView_add(infoSuspModel);
        }

        private void btnAtualizarInfoSusp_Click(object sender, EventArgs e)
        {
            int index = -1;

            if (InfoSuspGridView.CurrentCell != null)
                index = InfoSuspGridView.CurrentCell.RowIndex;

            if (index != -1)
            {
                InfoSuspModel model = new InfoSuspModel();

                model.codSusp = InfoSuspGridView.Rows[index].Cells[0].Value.ToString();
                model.indSusp = InfoSuspGridView.Rows[index].Cells[1].Value.ToString();
                model.dtDecisao = Convert.ToDateTime(InfoSuspGridView.Rows[index].Cells[2].Value);
                model.indDeposito = InfoSuspGridView.Rows[index].Cells[3].Value.ToString();

                InfoSuspForm form = new InfoSuspForm(model);
                form.ShowDialog(this);

                if (form.model != null)
                {
                    model = form.model;
                    InfoSuspGridView.Rows[index].Cells[0].Value = model.codSusp;
                    InfoSuspGridView.Rows[index].Cells[1].Value = model.indSusp;
                    InfoSuspGridView.Rows[index].Cells[2].Value = model.dtDecisao;
                    InfoSuspGridView.Rows[index].Cells[3].Value = model.indDeposito;
                }
            }
        }

        private void btnExcluirInfoSusp_Click(object sender, EventArgs e)
        {
            int index = -1;

            if (InfoSuspGridView.CurrentCell != null)
                index = InfoSuspGridView.CurrentCell.RowIndex;

            if (index != -1)
            {
                if (MessageBox.Show("Deseja excluir esta linha?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    InfoSuspGridView.Rows.RemoveAt(index);
                }
            }
        }
    }
}