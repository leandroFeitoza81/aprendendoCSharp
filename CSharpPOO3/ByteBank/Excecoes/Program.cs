using System;
using System.IO;

namespace Excecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = File.OpenText("data.txt"))
                {
                    Console.WriteLine($"A primeira linha do arquivo é: {sr.ReadLine()}");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Arquivo não encontrado. {ex}");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"Diretório não encontrado: {e}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"O arquivo nãopode ser aberto: {e}");
            }
        }
    }
}
