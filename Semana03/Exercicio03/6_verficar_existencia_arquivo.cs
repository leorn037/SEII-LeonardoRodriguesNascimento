using System;
using System.IO;


namespace CSCourse
{   class Program
    {
    public static void Main (string[] args)
    {
        string nomeDoarquivo= "documentos.txt";
        Console.WriteLine(File.Exists(nomeDoArquivo));
  
        File.WriteAllText(nomeDoarquivo,"Algum texto");

        Console.WriteLine(File.Exists(nomeDoarquivo));
    
        Console.ReadKey(true);
    }

}
    
}