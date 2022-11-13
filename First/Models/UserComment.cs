using System.ComponentModel.DataAnnotations;

namespace First.Models
{
    public class UserComment
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}
