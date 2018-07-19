using EY.Reinf.Object.Enumeracoes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EY.Reinf.Interface.Forms
{
    public partial class PesquisarForm : Form
    {
        string evento;

        public PesquisarForm(EventosReinf eventoReinf)
        {
            InitializeComponent();

            // EventosReinf evento = (EventosReinf) Enum.Parse(typeof(EventosReinf), tabControl1.SelectedTab.Name);
            evento = eventoReinf.ToString();
        }

        public string IdEvento;

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=BR2296206W1\SQLEXPRESS;Initial Catalog=dbReinf;Integrated Security=True;";
            string cnpj = maskedRaw(cnpjTextBox);

            if (cnpj.Length == 14)
            {
                BuscarPorCnpj(cnpj, connectionString, evento);
            }
            else
            {
                MessageBox.Show("Informe o CNPJ.");
            }
        }
        
        public void BuscarPorCnpj(string cnpj, string connectionString, string tableName)
        {
            string sql = "SELECT * FROM " + tableName + " WHERE nrInsc = " + cnpj;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, tableName);
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = tableName;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente analisar este item?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                IdEvento = dataGridView1[0, e.RowIndex].Value.ToString();

                this.Close();
            }
            else
            {

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
