using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;

namespace Work.Core.Repositories
{
    public interface IEmployeeRepository
    {
        DbSet<Employee> GetList();

        Employee GetById(int id);

        void DeleteById(int id);
        void Update(Employee employee);

        void Add(Employee employee);
    }
}
