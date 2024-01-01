using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;
using Work.Core.Repositories;
using Work.Core.Services;

namespace Work.Service
{
   
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public void Add(Job job)
        {
            _jobRepository.Add(job);
        }

        public void DeleteById(int id)
        {
            _jobRepository.DeleteById(id);
        }

        public DbSet<Job> GetAll()
        {
           return _jobRepository.GetList();
        }

        public Job GetById(int id)
        {
            return _jobRepository.GetById(id);
        }

        public void Update(Job job)
        {
            _jobRepository.Update(job);
        }
    }
}
