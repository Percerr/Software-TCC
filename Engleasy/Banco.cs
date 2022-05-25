using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Engleasy
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        //FUNC genericas 
        public static DataTable dql(string sql) // data query language (select)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        public static void dml(string q, string msgOK=null, string msgERRO=null) // data manipulation language (del, insert, updt)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                if (msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                throw ex;
            }
        }



        private static SQLiteConnection ConexaoBanco()
        {
            conexao=new SQLiteConnection("Data Source="+Globais.caminhoBanco + Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }


        /////funções do form F_NovoUsuario
        
        public static void NovoUsuario(Usuario u)
        {
            if (existeUsername(u))
            {
                MessageBox.Show("Username já existe");
                return;
            }
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO, N_PONTOGAMEONE) VALUES (@nome,@username,@senha,@status,@nivel,@ponto)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.Parameters.AddWithValue("@ponto", u.ponto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Cadastrado com Sucesso");
                ConexaoBanco().Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao Gravar Usuario");
                ConexaoBanco().Close();
            }


        }


        ///FIM das funções do form f_Novousuario



        ////// Rotinas Gerais
        public static bool existeUsername(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd=ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME='"+u.username+"'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }



            return res;
        }

        
        public static DataTable emptyWorld() //preenche as palavras iniciais
        {
            Random randNum = new Random();
            var res = "";
            int[] vet;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT * FROM tb_gameone";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());

            
            da.Fill(dt);
            res = dt.Rows[randNum.Next(28)][1].ToString();
            //Console.WriteLine(dt.Rows[0][0]);

            return dt;
        }
        public static DataTable emptyWorlddois() //preenche as palavras iniciais
        {
            Random randNum = new Random();
            var res = "";
            int[] vet;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT * FROM tb_gameone";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());


            da.Fill(dt);
            res = dt.Rows[randNum.Next(28)][1].ToString();
            //Console.WriteLine(dt.Rows[0][0]);

            return dt;
        }
        public static DataTable emptyWorldtres() //preenche as palavras iniciais
        {
            Random randNum = new Random();
            int[] vet;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT * FROM tb_gameone";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());


            da.Fill(dt);
            //res = dt.Rows[3][1].ToString();
            //Console.WriteLine(dt.Rows[0][0]);

            return dt;
        }

    }
}
