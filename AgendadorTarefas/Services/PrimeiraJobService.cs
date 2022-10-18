using AgendadorTarefas.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AgendadorTarefas.Services
{
    public class PrimeiraJobService : IPrimeiraJob
    {
        public void PrimeiraJob()
        {
            // Para testar um processamento mais demorado
            Thread.Sleep(20000);
            Console.WriteLine("Primeira Job em execução!!! São {0:HH:mm:ss} horas", DateTime.Now);
        }

        public async Task PrimeiraJobOutroTesteAsync()
        {
            // Para testar um processamento mais demorado
            await Task.Delay(20000);
            Console.WriteLine("Primeira Job em execução com processamento Assincrono!!! São {0:HH:mm:ss} horas", DateTime.Now);
        }
    }
}
