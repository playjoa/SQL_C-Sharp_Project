using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Banco_de_Dados
{
    class ConexaoSQL
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public ConexaoSQL()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "highscoresTable";
            uid = "root";
            password = "12345";
            string connectionString;
            connectionString = "DATASOURCE=" + server + ";port=3306;" + "USERNAME=" + uid + ";" + "PASSWORD=" + password + ";" + "DATABASE=" + database + ";";
            connection = new MySqlConnection(connectionString);

        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void NovaInsercao(string tabela, string[] camposInsercao, string[] variaveisParaSeremInseridas)
        {
            if (camposInsercao.Length != variaveisParaSeremInseridas.Length || camposInsercao.Length == 0 || variaveisParaSeremInseridas.Length == 0)
                return;

            string query = "INSERT INTO " + tabela;
            string campos = " (";
            string valores = " VALUES(";

            for (int i = 0; i < camposInsercao.Length; i++) 
            {
                if (i + 1 < camposInsercao.Length)
                {
                    campos += camposInsercao[i] + ", ";
                    valores += "'" + variaveisParaSeremInseridas[i] + "', ";
                }
                else
                {
                    campos += camposInsercao[i];
                    valores += "'" + variaveisParaSeremInseridas[i] + "'";
                }
            }

            campos += ")";
            valores += ")";

            query = query + campos + valores;

            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

        public bool VerificarSeTemAvaliacao(int idJogo, int idUser) 
        {
            OpenConnection();

            bool result = false;

            string query = "SELECT * FROM AvaliaJogo WHERE idJogo='" + idJogo + "' AND idUser ='" + idUser + "';";


            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
                result = true;

            CloseConnection();
            return result;
        }

        public void InserirAvaliacao(int idJogo, int idUser, int nota, string comentarioAvaliacao)
        {
            string query;

            bool aux = VerificarSeTemAvaliacao(idJogo, idUser);

            if (aux)
                query = "UPDATE AvaliaJogo SET notaAvaliacao = '" + nota + "', comentario = '" + comentarioAvaliacao + "' WHERE idJogo='" + idJogo + "' AND idUser='" + idUser + "';";
            else
                query = "INSERT INTO AvaliaJogo (idJogo, idUser, notaAvaliacao, comentario) VALUES('" + idJogo + "', '" + idUser + "', '" + nota + "', '" + comentarioAvaliacao + "');";

            OpenConnection();
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            //close connection
            CloseConnection();
        }



        public float MediaDoJogo(int idJogo) 
        {
            float media = 0;

            string query = "SELECT AVG(notaAvaliacao) 'media' FROM AvaliaJogo WHERE idJogo  ='" + idJogo + "';";

            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    try
                    {
                        media = float.Parse(dataReader["media"].ToString());
                    }
                    catch { media = 0; }
                }
                CloseConnection();
            }
            return media;
        }

        public int MaiorScoreDoJogo(int idJogo)
        {
            int maior = 0;

            string query = "SELECT MAX(valorScore) 'maiorScore' FROM JogaJogo WHERE idJogo  ='" + idJogo + "';";

            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    try
                    {
                        maior = Convert.ToInt32(dataReader["maiorScore"].ToString());
                    }
                    catch { maior = 0; }
                }
                CloseConnection();
            }
            return maior;
        }

        public void AtualizarDadosJogo(int idJogo, string nomeJogo, string descJogo)
        {
            string query = "UPDATE Jogo SET nomeJogo = '" + nomeJogo + "', descJogo = '" + descJogo + "' WHERE idJogo='" + idJogo + "';";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void RodarLinhadeComando(string linha) 
        {
            string query = linha;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void AtualizarScore(int idJogo, int idUser, int score) 
        {
            string query = "UPDATE JogaJogo SET valorScore = '" + score +"' WHERE idJogo='" + idJogo + "' AND idUser='" + idUser + "';";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public string PegarNomeUsuarioDoScore(string score)
        {
            string query = "SELECT u.nomeUser FROM Usuario u INNER JOIN JogaJogo j ON u.idUser = j.idUser WHERE j.valorScore = '" + score + "';";

            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                string aux = "-";
                while (dataReader.Read())
                {
                    aux = dataReader["nomeUser"].ToString();
                }
                CloseConnection();
                return aux;
            }
            else
            {
                return "-";
            }
        }

        public string PegarNomeDevJogo(int idJogo)
        {
            string query = "SELECT u.nomeUser FROM Usuario u INNER JOIN Developer d ON u.idUser = d.idUser INNER JOIN Jogo j ON j.idDev = d.idDev WHERE j.idJogo = '" + idJogo + "';";

            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                string aux = "-";
                while (dataReader.Read())
                {
                    aux = dataReader["nomeUser"].ToString();
                }
                CloseConnection();
                return aux;
            }
            else
            {
                return "-";
            }
        }

        public bool VerificarSerDev(int id)
        {
            string query = "SELECT * FROM Developer WHERE  idUser ='" + id + "';";

            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                if (dataReader.HasRows)
                {
                    CloseConnection();
                    return true;
                }
                else
                {
                    CloseConnection();
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public int VerificarLogIn(string email, string senha) 
        {
            string query = "SELECT idUser, nomeUser FROM Usuario WHERE  email ='" + email + "' AND senha = '" + senha + "';";

            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                int aux = -1;
                while (dataReader.Read())
                {
                    aux = Convert.ToInt32(dataReader["idUser"]);
                    UsuarioAtual.nomeUser = dataReader["nomeUser"].ToString();
                }
                
                CloseConnection();

                if (aux > 0)
                    return aux; 
                else
                    return -1;

            }
            else
            {
                return -1;
            }
        }

        public int VoltarScoreJogoDoUsuario(int idJogo, int idUser) 
        {
            string query = "SELECT valorScore FROM JogaJogo WHERE  idJogo = '" + idJogo + "' AND idUser = '" + idUser + "';";

            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                int aux = -1;
                while (dataReader.Read())
                {
                    if (dataReader["valorScore"].ToString() != string.Empty)
                        aux = Convert.ToInt32(dataReader["valorScore"]);                  
                }
                CloseConnection();
                return aux;
            }
            else
            {
                return -1;
            }
        }

        public string PegarInfoDeTabela(string tabela, string campoDesejado, string onde, string id) 
        {
            string query = "SELECT "+ campoDesejado + " FROM " + tabela + " WHERE  "+ onde +" ='" + id + "';";

            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                string aux ="";
                while (dataReader.Read())
                {
                   aux = dataReader[campoDesejado].ToString();
                }
                CloseConnection();
                return aux;
            }
            else
            {
                return "";
            }
        }

        public string DevolverAvaliacoesJogo(int idJogo)
        {
            string query = "SELECT u.nomeUser, a.notaAvaliacao, a.comentario FROM Usuario u INNER JOIN AvaliaJogo a ON u.idUser = a.idUser WHERE a.idJogo = "+ idJogo +";";

            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                string aux = "";
                
                while (dataReader.Read())
                {
                    aux += Environment.NewLine;
                    aux += "Nome: " + dataReader["nomeUser"].ToString() + Environment.NewLine;
                    aux += "Nota: " + dataReader["notaAvaliacao"].ToString() + Environment.NewLine;
                    aux += "Comentário: " + Environment.NewLine + dataReader["comentario"].ToString() + Environment.NewLine;
                    aux += Environment.NewLine + "----------------------------------------------" + Environment.NewLine;
                }

                CloseConnection();
                return aux;
            }
            else
            {
                return "";
            }

        }

        public bool VerificarSeJaTemEmUpdate(string tabela, string variavel, string valor, int idUser)
        {
            string query = "SELECT * FROM " + tabela + " WHERE " + variavel + " = '" + valor + "' AND idUser <> '"+idUser+"';";

            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();



                if (dataReader.HasRows)
                {
                    CloseConnection();
                    return true;
                }
                else
                {
                    CloseConnection();
                    return false;
                }
            }
            else
            {
                CloseConnection();
                return false;
            }
        }

        public bool VerificarSeJaTemEm(string tabela, string variavel, string valor) 
        {
            string query = "SELECT * FROM "+ tabela + " WHERE "+ variavel + " = '" + valor + "';";

            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();



                if (dataReader.HasRows)
                {
                    CloseConnection();
                    return true;
                }
                else
                {
                    CloseConnection();
                    return false;
                }
            }
            else
            {
                CloseConnection();
                return false;
            }
        }

        public List<string> ListaDeTodosJogos() 
        {
            string query = "SELECT nomeJogo FROM Jogo;";

            List<string> listaJogos = new List<string>();

            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    listaJogos.Add(dataReader["nomeJogo"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();
            }
            return listaJogos;
        }

        public List<string> ListarMeusJogos(int idDev)
        {
            string query = "SELECT nomeJogo FROM Jogo WHERE idDev = '" + idDev + "';";

            List<string> listaJogos = new List<string>();

            if (OpenConnection())
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    listaJogos.Add(dataReader["nomeJogo"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();
            }
            return listaJogos;
        }

        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public int ContarEm(string tabela, string campo, string igualA)
        {
            string query = "SELECT Count(*) FROM " + tabela + " WHERE "+ campo + " = '"+ igualA + "';";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

    }
}
