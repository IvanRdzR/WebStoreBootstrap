namespace WebStoreBootstrap.Models
{
    public class IWorkerRepository : IWorker
    {
        private List<Worker> listWorker;
        public IWorkerRepository()
        {
            listWorker = new List<Worker>();

            listWorker.Add(new Worker() { Id = 1, Name = "Iván", Age = 20, Phone = 4444444, State = "SLP" });
            listWorker.Add(new Worker() { Id = 2, Name = "Ian", Age = 21, Phone = 4444444, State = "SLP" });
            listWorker.Add(new Worker() { Id = 3, Name = "Emelyn", Age = 22, Phone = 4444444, State = "SLP" });
            listWorker.Add(new Worker() { Id = 4, Name = "Sugey", Age = 23, Phone = 4444444, State = "SLP" });

        }

        public Worker GetDataWorker(int id)
        {
            return this.listWorker.FirstOrDefault(lw => lw.Id == id);
        }

    }
}
