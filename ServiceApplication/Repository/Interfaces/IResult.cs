using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ServiceApplication.Entities;

namespace ServiceApplication.Repository.Interfaces
{
    public interface IResult<TEntity>
    {
        Task<IEnumerable<QuizAttempt>> GetAttemptHistory(string argCandidateID);
        Task<IEnumerable<QuizReport>> ScoreReport(ReqReport argRpt);
        Task<int> AddResult(List<TEntity> entity);
        Task<string> GetCertificateString(ReqCertificate argRpt);
    }
}
