using System.ComponentModel.DataAnnotations;

namespace WebStoreBootstrap.Models
{
    public class Worker
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
        public string State { get; set; }

    }
}
