using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaMysql.Entidades;
using SistemaMysql.DAO;


namespace SistemaMysql.DAO
{
    public class ClienteDAO
    {
        //string conexao = "SERVER=localhost; DATABASE=sistema_clientes; UID=root; PWD=;";
        //MySqlConnection con = null;
        MySqlCommand sql;
        Conexao con = new Conexao();


        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                //con = new MySqlConnection(conexao);
                sql = new MySqlCommand("SELECT * FROM clientes order by id desc", con.con);
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


        public void Salvar(Clientes dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO clientes(nome, sexo, data) VALUES(@nome, @sexo, @data)", con.con);
                sql.Parameters.AddWithValue("@nome", dados.Nome);
                sql.Parameters.AddWithValue("@sexo", dados.Sexo);
                sql.Parameters.AddWithValue("@data", dados.Data);

                sql.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar" + ex);
                con.FecharConexao();
            }
        }


        public void Editar(Clientes dado)
        {
                try
                {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE clientes SET nome = @nome, sexo = @sexo, data = @data WHERE id = @id", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@sexo", dado.Sexo);
                sql.Parameters.AddWithValue("@data", dado.Data);
                sql.Parameters.AddWithValue("@id", dado.Id);

                sql.ExecuteNonQuery();
                con.FecharConexao();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao Editar" + ex);
                }         
        }
        public void Excluir(Clientes dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM clientes WHERE id = @id", con.con);   
                sql.Parameters.AddWithValue("@id", dado.Id);

                sql.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir" + ex);
            }
        }

        public DataTable Buscar(Clientes dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM clientes WHERE nome LIKE @nome", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome + "%");//tudo o que for semelhante a primeira letra que eu digitar
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

    }
}
