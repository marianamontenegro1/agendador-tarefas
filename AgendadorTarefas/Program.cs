using AgendadorTarefas.Interfaces;
using AgendadorTarefas.Services;
using FluentScheduler;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AgendadorTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPrimeiraJob, PrimeiraJobService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Inicia o Agendador
            JobManager.Initialize(new TarefasAgendadas(serviceProvider));          
                       
            // Aguarda pela intervenção do usuário
            Console.WriteLine("Tecle algo...");
            Console.ReadLine();
            // Para o Agendador            
            JobManager.StopAndBlock();
        }
       
    }
}
