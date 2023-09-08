using System;
using Microsoft.EntityFrameworkCore;
using ServiceApplication.Entities;

namespace ServiceApplication.Services
{
    public class AUEDBContext : DbContext
    {
        public AUEDBContext()
        {
        }
        public AUEDBContext(DbContextOptions<AUEDBContext> options) : base(options)
        {
        }
        public virtual DbSet<Candidate> Candidate { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Choice> Choice { get; set; }
        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<Result> Result { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuizAttempt>(eb =>
            {
                //eb.HasNoKey();
                //eb.ToView(null);
            });

            modelBuilder.Entity<QuizReport>(eb =>
            {
                //eb.HasNoKey();
                //eb.ToView(null);
            });
        }
    }
}