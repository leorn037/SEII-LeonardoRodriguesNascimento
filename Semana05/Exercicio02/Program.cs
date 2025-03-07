using System;
using System.Collections.Generic;
using System.Diagnostics; 
using System.Threading;

namespace ProgAssincrona
{
    class Program
    {
        static void Main(string[]args)
        {
            Stopwatch sw =new Stopwatch();
            sw.Start();
            ExecutarcomTasks();
            sw.Stop();
            Console.WriteLine($"Operação gastou {sw.ElapsedMilliseconds} milissegundos.");

        }
        static void RealizarOperacao(int op, string nome, string sobrenome)
        {
            Console.WriteLine($"Iniciando operação{op}...");
            for(int i =0;i<1000000000;i++)
            {
                var p = new Pessoa(nome, sobrenome, 35);

            }
            Console.WriteLine($"Finalizando operação{op}...");
        }

        private static void ExecutarSequencial()
        {
            RealizarOperacao(1,"Fulano","da Silva");
            RealizarOperacao(2,"Beltrano","da Silva");
            RealizarOperacao(3,"Sicrano","da Silva");
        }

        static void ExecutarcomThreads()
        {
            var t1 = new Thread(()=>
            {
                RealizarOperacao(1,"Fulano","da Silva");
            });
            var t2 = new Thread(()=>
            {
                RealizarOperacao(2,"Beltrano","da Silva");
            });

            var t3 = new Thread(()=>
            {
                RealizarOperacao(3,"Sicrano","da Silva");
            });

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
        }

        static void ExecutarcomTasks()
        {
            var t1 = Task<int>.Run(()=>
            {
                RealizarOperacao(1,"Fulano","da Silva");
                return 1;
            });
            var t2 = Task<int>.Run(()=>
            {
                RealizarOperacao(2,"Beltrano","da Silva");
                return 2;
            });

            var t3 = Task<int>.Run(()=>
            {
                RealizarOperacao(3,"Sicrano","da Silva");
                return 3;
            });

            Console.WriteLine($"Tarefa {t1.Result} finalizou.");
            Console.WriteLine($"Tarefa {t2.Result} finalizou.");
            Console.WriteLine($"Tarefa {t3.Result} finalizou.");
        }
    }
}