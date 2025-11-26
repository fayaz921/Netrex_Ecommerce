using Domain_Service.RepoInterfaces.GenericRepo;
using Infrastructure_Service.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Service.Persistance.GenericRepo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> dbset;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            dbset =_context.Set<T>();
        }
        public async Task<T> Create(T obj)
        {
           await dbset.AddAsync(obj);
            return obj;
           
        }

        public async Task<bool> Delete(T obj)
        {
            dbset.Remove(obj);
            return true;
        }

        public async Task<T> GetById(Guid id)
        {
            var getresult = await dbset.FindAsync(id);
            return getresult!;
        }

        public async Task<T> Update(T obj)
        {
            dbset.Update(obj);
            return obj;
        }
    }
}
