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
    public class EmployerRepository : IEmployerRepository
    {
        private readonly DataContext _context;
        public EmployerRepository(DataContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            Employer e = _context.Employers.FirstOrDefault(e => e.Id == id);
            if (e != null) {
                _context.Employers.Remove(e);
            }
            
        }

        public Employer GetById(int id)
        {
            return _context.Employers.FirstOrDefault(e => e.Id == id);
        }

        public DbSet<Employer> GetList()
        {
            return _context.Employers;
        }

        public Employer Update(Employer employer)
        {
            Employer e = _context.Employers.FirstOrDefault(e => e.Id == employer.Id);
            if (e != null)
            {
                e.Status = employer.Status;
                e.City = employer.City;
                e.Email = employer.Email;
                e.Name = employer.Name; 
                
            }
            else
                _context.Employers.Add(employer);
            _context.SaveChanges();
            return employer;
        }

        public Employer Add(Employer employer)
        {
            _context.Employers.Add(employer);
            _context.SaveChanges();
            return employer;
        }
    }
}
