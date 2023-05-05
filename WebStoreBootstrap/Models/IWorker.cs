namespace WebStoreBootstrap.Models
{
    public interface IWorker
    {
        Worker GetDataWorker(int id);
        List<Worker> GetAll();
    }
}
