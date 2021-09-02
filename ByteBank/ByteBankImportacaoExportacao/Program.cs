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
        static void Main(string[] args)
        {
            // LidandoComFileStreamDiretamente();var enderecoDoArquivo = "contas.txt";

            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))            
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                //var linha = leitor.ReadToEnd();
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();

                    Console.WriteLine(linha);
                }
            }
            
            Console.ReadLine();
        }



    }
}
