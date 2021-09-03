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
            // LidandoComFileStreamDiretamente();
            // UsarStreamReader();
            // CriarArquivo();
            //CriarArquivoComWriter();
            // TestaEscrita();
            // EscritaBinaria();
            LeituraBinaria();
            Console.WriteLine("Aplicação finalizada...");

            Console.ReadLine();
        }

       


    }
}
