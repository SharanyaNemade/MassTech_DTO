using System.ComponentModel.DataAnnotations.Schema;

namespace FebBatch2026WebApi.DTO
{
    public class EmpDTO
    {
        public int eid { get; set; }
        public string ename { get; set; }
        public double esalary { get; set; }
        public int mid { get; set; }
    }
}
