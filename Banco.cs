using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Ale_Academia
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection conexaoBanco()
        {
            conexao = new SQLiteConnection("data source = C:\\Users\\Alexandre\\Documents\\CODE\\C#\\Ale_Academia\\banco\\banco_academia.db");

            conexao.Open();

            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    da.Fill(dt);
                    return dt;
                }
            }catch(Exception ex)
            {
                conexaoBanco().Close();
                throw ex;
            }
        }

        public static DataTable consulta (string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    da.Fill(dt);
                    conexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                conexaoBanco().Close();
                throw ex;
            }
        }
        public static void NovoUsuario(Usuario usuario)
        {
            if (existeUsername(usuario))
            {
                MessageBox.Show("Usuário já existe!");
                return;
            }
            try
            {
                var cmd = conexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome, @username, @senha, @status, @nivel)";
                cmd.Parameters.AddWithValue("@nome", usuario.T_NOMEUSUARIO);
                cmd.Parameters.AddWithValue("@username", usuario.T_USERNAME);
                cmd.Parameters.AddWithValue("@senha", usuario.T_SENHAUSUARIO);
                cmd.Parameters.AddWithValue("@status", usuario.T_STATUSUSUARIO);
                cmd.Parameters.AddWithValue("@nivel", usuario.N_NIVELUSUARIO);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuário inserido!");
                conexaoBanco().Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuario");
                conexaoBanco().Close();
            }
        }
        public static bool existeUsername(Usuario usuario)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME = '" + usuario.T_USERNAME + "'" ;
            da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }



            return res;
        }

    }
}
