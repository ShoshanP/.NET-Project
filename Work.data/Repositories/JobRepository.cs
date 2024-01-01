using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;
using Work.Core.Repositories;

namespace Work.data.Repositories
{
    public class JobRepository : IJobRepository
    {
        private readonly DataContext _context;
        public JobRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Job job)
        {
           _context.Jobs.Add(job);
        }

        public void DeleteById(int id)
        {
            Job j=_context.Jobs.FirstOrDefault(x => x.Id == id);
            if (j != null)
            {
                _context.Jobs.Remove(j);
            }
        }

        public Job GetById(int id)
        {
            return _context.Jobs.FirstOrDefault(j=>j.Id==id);
        }

        public DbSet<Job> GetList()
        {
            return _context.Jobs;
        }

       

        public void Update(Job job)
        {
            Job j= _context.Jobs.FirstOrDefault(j=> j.Id==job.Id);
            if(j!=null)
            {
                j.Employer = job.Employer;
                j.ExperienceYearsRequired = job.ExperienceYearsRequired;
                j.Type = job.Type;
            }
            else
                _context.Jobs.Add(job);
        }
    }
}
