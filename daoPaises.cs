using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class daoPaises : SysLojaInfo.dao
    {

        private MySqlConnection conn;
        public daoPaises()
        {
            this.conn = new Conexao().GetConnection();
        }

        public override void salvar(object obj)
        {
            base.salvar(obj);
            Paises oPais = (Paises)obj;
            string oSql = @"insert into Paises (nome, sigla, ddi, datCad, datAlt, idUser) 
                            values (@nome, @sigla, @ddi, @datCad, @datUltAlt, @id_user)";
            oPais.DatCad = DateTime.Now;
            oPais.DatUltAlt = DateTime.Now;
            oPais.QuemAlter = 0;
     
            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@nome", oPais.Pais);
                execCmd.Parameters.AddWithValue("@sigla", oPais.Sigla);
                execCmd.Parameters.AddWithValue("@ddi", oPais.DDI);
                execCmd.Parameters.AddWithValue("datCad", oPais.DatCad);
                execCmd.Parameters.AddWithValue("@datUltAlt", oPais.DatUltAlt);
                execCmd.Parameters.AddWithValue("@id_user", oPais.QuemAlter);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Pais Cadastrado com Sucesso");
                conn .Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o Pais:" + ex.Message);
            }
        }
        public override void editar(object obj)
        {
            Paises oPais = (Paises)obj;
            string oSql = @"update Paises set nome = '@nome', sigla = '@sigla', ddi = '@ddi', datAlt =  '@datAlt', 
                            idUser = @idUsu where idPais =  @Cod";
            oPais.DatUltAlt = DateTime.Now;
            oPais.QuemAlter = 0;

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
                execCmd.Parameters.AddWithValue("@nome", oPais.Pais);
                execCmd.Parameters.AddWithValue("@sigla", oPais.Sigla);
                execCmd.Parameters.AddWithValue("@ddi", oPais.DDI);
                execCmd.Parameters.AddWithValue("@datUltAlt", oPais.DatUltAlt);
                execCmd.Parameters.AddWithValue("@idUsu", oPais.QuemAlter);
                execCmd.Parameters.AddWithValue("@Cod", oPais.Codigo);
                MessageBox.Show(execCmd.Parameters["@sigla"].Value.ToString());
                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Pais Alterado com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar o Pais:" + ex.Message + "tam Str: " +  oPais.Sigla.Length);
                

            }

        }

        public override void deletar(object obj)
        {
            Paises oPais = (Paises)obj;
            string oSql = @"delete from Paises where idPais =  @Cod";

            try
            {
                MySqlCommand execCmd = new MySqlCommand(oSql, conn);
    
                execCmd.Parameters.AddWithValue("@Cod", oPais.Codigo);

                conn.Open();
                execCmd.ExecuteNonQuery();
                MessageBox.Show("Pais Excluido com Sucesso");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir o Pais:" + ex.Message);
            }
        }

        public override DataTable SelecionaDS()
        {
            string oSql = @"SELECT * FROM PAISES";
            MySqlCommand execCmd = new MySqlCommand(oSql, conn);
            execCmd.CommandType = CommandType.Text; 

            DataTable dt = new DataTable();
            try
            {
              
                conn.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(oSql, conn);
                sqlDataAdapter.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NA CONSULTA!! " + ex.Message);
            }
            return dt;

        }
    }
    
}
