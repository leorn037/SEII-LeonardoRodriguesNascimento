
using System;
using System.IO;


namespace CSCourse
{   class Program
    {
    public static void Main (string[] args)
    {/    
        string nomeDoarquivo="arquivo.txt";
        string texto= "Este é um documento de texto.";
        File.WriteAllText(nomeDoarquivo,texto);
        Console.WriteLine("Arquivo criado com sucesso");
        Console.ReadKey(true);
    }

}
    
}