using System.Threading.Tasks;

namespace AgendadorTarefas.Interfaces
{
    public interface IPrimeiraJob
    {
        public void PrimeiraJob();

        Task PrimeiraJobOutroTesteAsync();
    }
}
