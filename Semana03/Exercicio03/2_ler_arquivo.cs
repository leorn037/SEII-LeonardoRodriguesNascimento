using System;
using System.IO;


namespace CSCourse
{   class Program
    {
    public static void Main (string[] args)
    {
        string arquivo="arquivo.txt";
        string texto= File.ReadAllText(arquivo);
        File.WriteAllText(nomeDoarquivo,texto);
        Console.WriteLine("Conteúdo do arquivo"+texto);
        Console.ReadKey(true);
    }

}
    
}