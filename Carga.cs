using System;
using System.IO;

namespace CargaCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o diretório do arquivo");

            var diretorio = Console.ReadLine();

            var arquivo = Directory.GetFiles(diretorio);

            if(Path.GetExtension(arquivo) )
        }
    }
}
