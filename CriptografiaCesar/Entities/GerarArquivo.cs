using System;
using System.IO;

namespace CriptografiaCesar.Entities
{
    internal class GerarArquivo
    {
        private string SourcePath = @"c:\temp\";

        public string SalvarMensagem(string mensagem)
        {
            Directory.CreateDirectory(SourcePath);
            string arquivo = Path.Combine(SourcePath, "resultado.txt");
            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = new StreamWriter(arquivo))
                {
                    sw.WriteLine(mensagem);
                }
            }
            Console.WriteLine("Resultado em .txt foi salvo na pasta: " + arquivo);
            return mensagem;
        }
    }
}
