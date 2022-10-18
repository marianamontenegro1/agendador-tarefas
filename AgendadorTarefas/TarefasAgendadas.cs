using AgendadorTarefas.Interfaces;
using AgendadorTarefas.Services;
using FluentScheduler;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AgendadorTarefas
{
    public class TarefasAgendadas : Registry
    {        
        public TarefasAgendadas(IServiceProvider serviceProvider)
        {
            var _primeiraJob = serviceProvider.GetRequiredService<IPrimeiraJob>();            

            // Acessa um método com injeção de depedência
            Schedule(new PrimeiraJobComDependenciaService(_primeiraJob))
             .NonReentrant()                            // Permite somente uma instância do job por vez
             .ToRunOnceAt(DateTime.Now.AddSeconds(5)) // Aguarda X segundos antes da primeira execução
             .AndEvery(5).Seconds();                  // Intervalo de X segundos

            // Acessa um método de forma simples e direto
            Schedule<SegundaJobService>()
             .NonReentrant()                            
             .ToRunOnceAt(DateTime.Now.AddSeconds(5)) 
             .AndEvery(5).Seconds();               

            // Agenda um job para ser executado em uma hora e dia específico
            Schedule(() => Console.WriteLine("Executando em um horário específico")).ToRunEvery(1).Days().At(14, 13);
        }
    }
}
