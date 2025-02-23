using System;
using System.IO;


namespace CSCourse
{   class Program
    {
    public static void Main (string[] args)
    {

        string nomeDoarquivo= "documentos.txt";
        string[] documentos=File.ReadAllLines(nomeDoarquivo);
        foreach(string documento in documentos)
            Console.WriteLine(documento);
        Console.ReadKey(true);
    }

}
    
}