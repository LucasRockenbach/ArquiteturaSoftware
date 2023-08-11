using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = "C:/Users/autologon.CSED/Desktop/aula1Dados.CSV";
            if (File.Exists(caminhoArquivo))
            {
                Stream file = File.Open(caminhoArquivo, FileMode.Open);
                StreamReader leitor = new StreamReader(file);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    Console.WriteLine(linha + "\n");
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                file.Close();
            }
            else
            {
                Console.WriteLine("Nenhum arquivo encontrado");
            }
            Console.ReadLine();
        }
    }
}
