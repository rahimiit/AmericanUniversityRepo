using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ServiceApplication.Entities;
 
using ServiceApplication.Repository.Interfaces;
using ServiceApplication.Services;

namespace ServiceApplication.Repository.Base
{
    public class CandidateService<TEntity> : ICandidate<TEntity> where TEntity : BaseEntity
    {
        private readonly AUEDBContext _dbContext;
        private DbSet<TEntity> _dbSet;
        public CandidateService(AUEDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }            
        public async Task<IEnumerable<TEntity>> GetCandidateList()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<TEntity> GetCandidate(int id)
        {
            
            return await _dbSet.FirstOrDefaultAsync(e => e.Id== id);
        }
 
        
        public async Task<IQueryable<TEntity>> SearchCandidate(Expression<Func<TEntity, bool>> search = null)
        {
            IQueryable<TEntity> query=_dbSet;
            if (search != null)
            { 
                query =query.Where(search); 
            }           
            return query;
        }

        public async Task<int> AddCandidate(TEntity entity)
        {
            int output = 0;
            _dbSet.Add(entity);
            output = await _dbContext.SaveChangesAsync();
            return output;
        }
        public async Task<int> UpdateCandidate(TEntity entity)
        {
            int output = 0;
            _dbSet.Update(entity);
            output = await _dbContext.SaveChangesAsync();
            return output;
        }
        public async Task<int> DeleteCandidate(TEntity entity)
        {
            int output = 0;
            _dbSet.Remove(entity);
            output = await _dbContext.SaveChangesAsync();
            return output;
        }
      
    }
}
