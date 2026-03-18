
using AutoMapper;
using FebBatch2026WebApi.Data;
using FebBatch2026WebApi.DTO;
using FebBatch2026WebApi.Models;
using FebBatch2026WebApi.Repo;
using Microsoft.EntityFrameworkCore;

namespace FebBatch2026WebApi.Service
{
    public class EmpService : IEmpService
    {
        ApplicationDbContext db;
        IMapper mapper;
        public EmpService(ApplicationDbContext db,IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddEmp(EmpDTO dto)
        {

            //var e = new Emp()
            //{
            //    ename = dto.ename,
            //    esalary = dto.esalary,
            //    mid = dto.mid
            //};
            var e=mapper.Map<Emp>(dto);
            db.emps.Add(e);
            db.SaveChanges();
        }

        public List<EmpDTOFetch> FetchEmp()
        {
            //var data = db.emps.Include(x => x.managers)
            //    .Select(e => new EmpDTOFetch()
            //    {
            //        eid=e.eid,
            //        ename=e.ename,
            //        esalary=e.esalary,
            //        mid=e.mid,
            //        mname=e.managers.mname!=null? e.managers.mname:"No"
            //    }).ToList();
            var data = db.emps.Include(x => x.managers).ToList();
            var mapperdata=mapper.Map<List<EmpDTOFetch>>(data);
            return mapperdata;            
        }
    }
}
