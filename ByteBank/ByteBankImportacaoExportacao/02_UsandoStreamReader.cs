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
        static void UsarStreamReader()
        {
            var enderecoDoArquivo = "contasCSV.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                //var linha = leitor.ReadToEnd();
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverterStringParaContaCorrente(linha);

                    var msg = $"{contaCorrente.Titular.Nome}: número {contaCorrente.Numero}, agência {contaCorrente.Agencia}, saldo {contaCorrente.Saldo}";
                    Console.WriteLine(msg);

                    //Console.WriteLine(linha);
                }
            }
        }
        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var agenciaComoInt = int.Parse(agencia);
            var numeroComoInt = int.Parse(numero);
            var saldoComoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
            resultado.Depositar(saldoComoDouble);
            resultado.Titular = titular;

            return resultado;

        }
    }
}