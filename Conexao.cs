using System;

public class Conexao
{
    SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["projeto_reinf"].ConnectionString
                );


    public DataTable ListarUnidadesPorDepartamento(int departamentoId)
    {
        var table = new DataTable();

        try
        {
            using(var adaptador = new SqlDataAdapter("unidadesPorDepartamento", cn))
            {
                adaptador.SelectCommand.Parameters.AddWithValue("@DeptoID", departamentoId);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.Fill(table);
            }
        }
        catch(SqlException e)
        {
            MessageBox.Show(e.Message);
            return table;
        }

        return table;
    }
}
