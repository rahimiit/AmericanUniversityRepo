using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceApplication.Repository.Interfaces;
using ServiceApplication.Repository.Base;
using ServiceApplication.Repository.Base;

namespace ServiceApplication.Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
           .AddScoped<ICandidate<Entities.Candidate>, CandidateService<Entities.Candidate>>()
           .AddScoped<IExam<Entities.Exam>, ExamService<Entities.Exam>>()
           .AddScoped<IQuestion<Entities.Question>, QuestionService<Entities.Question>>()
           .AddScoped<IResult<Entities.Result>, ResultService<Entities.Result>>();
        }
    }
}