using FebBatch2026WebApi.Data;
using FebBatch2026WebApi.DTO;
using FebBatch2026WebApi.Models;
using FebBatch2026WebApi.Repo;

namespace FebBatch2026WebApi.Service
{
    public class ManagerService : IManagerService
    {
        ApplicationDbContext db;
        public ManagerService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void AddManager(ManagerDTO mdto)
        {
            var m = new Manager()
            {
                mname=mdto.mname
            };
            db.managers.Add(m);
            db.SaveChanges();
        }
    }
}
