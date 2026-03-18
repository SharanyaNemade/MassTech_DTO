

using FebBatch2026WebApi.DTO;
using FebBatch2026WebApi.Models;

namespace FebBatch2026WebApi.Repo
{
    public interface IEmpService
    {
        void AddEmp(EmpDTO dto);
        List<EmpDTOFetch> FetchEmp();
    }
}
