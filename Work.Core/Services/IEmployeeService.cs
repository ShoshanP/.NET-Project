using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;

namespace Work.Core.Services
{
    public interface IEmployeeService
    {
        DbSet<Employee> GetAll();
        Employee GetById(int id);
        void Update(Employee employee);
        void DeleteById(int id);

        void Add(Employee employee);

    }
}
