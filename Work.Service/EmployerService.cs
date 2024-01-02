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
    public class EmployerService : IEmployerService
    {
        private readonly IEmployerRepository _employerRepository;
        public EmployerService(IEmployerRepository employerRepository)
        {
            _employerRepository = employerRepository;
        }

        public Employer Add(Employer employer)
        {
           return _employerRepository.Add(employer);
        }

        public void DeleteById(int id)
        {
            _employerRepository.DeleteById(id);
        }

        public DbSet<Employer> GetAll()
        {
            return _employerRepository.GetList();
        }

        public Employer GetById(int id)
        {
            return _employerRepository.GetById(id);
        }

        public Employer Update(Employer employer)
        {
           return _employerRepository.Update(employer);
        }
    }
}
