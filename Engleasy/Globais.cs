using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engleasy
{
    internal class Globais
    {
        public static string versao="1.0";
        public static Boolean logado = false;
        public static int nivel=0;
        public static int id = 0;
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "banco_engleasy.db";
        public static string nomeChangelog = "changelog.txt";
        public static string caminhoBanco = caminho+@"\banco\";
        public static string somPath = caminho+@"\..\..\..\Resources\Sounds\";
    }
}
    