using System;
using System.IO;
using System.Threading,Tasks

namespace CSTutorial
{   class Program
    {
    static void Main (string[] args)
    {

        string[] arquivos = directory.GetFiles(@"C:\");
        foreach(var arquivo in arquivos)
        {
            Console.WriteLine(arquivo);
        }
        
        Console.ReadKey(true);
    }

}
    
}