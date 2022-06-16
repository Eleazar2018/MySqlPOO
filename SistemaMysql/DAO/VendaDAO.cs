using MySql.Data.MySqlClient;
using SistemaMysql.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMysql.DAO
{
    class VendaDAO
    {
        MySqlCommand sql;
        Conexao con = new Conexao();

        public void Salvar(Vendas dados)
        {           
            try
            {    
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO vendas(data, valor, id_cliente) VALUES(@data, @valor, @cliente)", con.con);
                sql.Parameters.AddWithValue("@data", dados.Data);
                sql.Parameters.AddWithValue("@valor", dados.Valor);
                sql.Parameters.AddWithValue("@cliente", dados.Id_cliente);

                sql.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar" + ex);
                con.FecharConexao();
            }
        }


        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                //con = new MySqlConnection(conexao);
                sql = new MySqlCommand("SELECT * FROM vendas order by id desc", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();//exibir em uma tabela
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable Buscar(Vendas dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM vendas WHERE id_cliente = @nome", con.con);
                sql.Parameters.AddWithValue("@cliente", dado.Id_cliente);//tudo o que for semelhante a primeira letra que eu digitar
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();//exibir em uma tabela
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Editar(Vendas dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE clientes SET data = @data, valor = @valor, id_cliente = @cliente WHERE id = @id", con.con);
                sql.Parameters.AddWithValue("@data", dado.Data);
                sql.Parameters.AddWithValue("@valor", dado.Valor);
                sql.Parameters.AddWithValue("@cliente", dado.Id_cliente);
                sql.Parameters.AddWithValue("@id", dado.Id);

                sql.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar" + ex);
            }
        }


        public void Excluir(Vendas dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM vendas WHERE id = @id", con.con);
                sql.Parameters.AddWithValue("@id", dado.Id);

                sql.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir" + ex);
            }
        }
    }
}
