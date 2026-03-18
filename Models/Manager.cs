using System.ComponentModel.DataAnnotations;

namespace FebBatch2026WebApi.Models
{
    public class Manager
    {
        [Key]
        public int mid { get; set; }
        public string mname { get; set; }

        public List<Emp> emps { get; set; }
    }
}
