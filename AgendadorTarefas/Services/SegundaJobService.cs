using FluentScheduler;
using System;

namespace AgendadorTarefas.Services
{
    public class SegundaJobService : IJob
    {
        public void Execute()
        {
            Console.WriteLine("Segunda Job em execução!!! São {0:HH:mm:ss} horas", DateTime.Now);
        }
    }
}
