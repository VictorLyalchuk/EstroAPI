using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Info
{
    public class Info
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Options> ? Options { get; set; }
    }
}
