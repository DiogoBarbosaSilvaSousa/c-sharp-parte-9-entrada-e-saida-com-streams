using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO; // IO = Input e Output
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void TestReadAllLines()
        {
            var linhas = File.ReadAllLines("contas.txt");
            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }
        }

        static void TestReadAllBytes()
        {
            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");
        }

        static void TestWriteAllText()
        {
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");
            Console.WriteLine("Arquivo escrevendoComAClasseFile criado!");
        }
    }

}