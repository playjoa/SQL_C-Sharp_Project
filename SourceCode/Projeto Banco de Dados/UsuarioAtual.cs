using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_de_Dados
{
    class UsuarioAtual
    {
        public static int idUsuario, idDev = -1;
        public static bool isDeveloper = false;
        public static string nomeUser;

        public static void ApagarDados()
        {
            idUsuario = -1;
            idDev = -1;
            isDeveloper = false;
            nomeUser = string.Empty;
        }

        
    }
}
