using AgendadorTarefas.Interfaces;
using FluentScheduler;

namespace AgendadorTarefas.Services
{
    public class PrimeiraJobComDependenciaService : IJob
    {
        private readonly IPrimeiraJob _primeiraJob;

        public PrimeiraJobComDependenciaService(IPrimeiraJob primeiraJob)
        {
            _primeiraJob = primeiraJob;
        }

        public void Execute()
        {
            //_primeiraJob.PrimeiraJob();
            _primeiraJob.PrimeiraJobOutroTesteAsync();
        }

    }
}
