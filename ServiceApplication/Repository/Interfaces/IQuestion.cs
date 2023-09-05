using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ServiceApplication.Entities;

namespace ServiceApplication.Repository.Interfaces
{
    public interface IQuestion<TEntity>
    {
        Task<QnA> GetQuestionList(int ExamID);       
        Task<IQueryable<TEntity>> SearchQuestion(Expression<Func<TEntity, bool>> search = null);
        Task<int> AddQuestion(TEntity entity);
        Task<int> UpdateQuestion(TEntity entity);
        Task<int> DeleteQuestion(TEntity entity);
    }
}
