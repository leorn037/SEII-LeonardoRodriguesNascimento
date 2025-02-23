using System;
using System.IO;


namespace CSCourse
{   class Program
    {
    public static void Main (string[] args)
    {
        string diretorio="pasta";
        
        if(Directory.Exists(diretorio))
        {
            Console.WriteLine("O diretório existe");
        }
        else
            Console.WriteLine("Não existe");

        Console.ReadKey(true);
    }

}
    
}