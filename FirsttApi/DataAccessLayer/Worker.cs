using System.ComponentModel.DataAnnotations;

namespace FirsttApi.DataAccessLayer
{
    public class Worker
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
