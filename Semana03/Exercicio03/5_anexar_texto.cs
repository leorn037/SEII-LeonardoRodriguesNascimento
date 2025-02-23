using System;
using System.IO;


namespace CSCourse
{   class Program
    {
    public static void Main (string[] args)
    {
        string nomeDoarquivo= "documentos.txt";
        string conteudo=File.ReadAllText(nomeDoarquivo);
        Console.WriteLine("conteúdo do arquivo:");
        Console.WriteLine(conteudo);
        Console.WriteLine("\n");

        File.AppendAllText(nomeDoarquivo,"Um outro arquivo.");

        conteudo = File.ReadAllText(nomeDoarquivo);
        Console.WriteLine(conteudo);
        Console.WriteLine("\n");


        Console.ReadKey(true);
    }

}
    
}