using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;

namespace Work.Core.Services
{
    public interface IJobService
    {
        DbSet<Job> GetAll();
        Job GetById(int id);
       void Update(Job job);
        void DeleteById(int id);

        void Add(Job job);
        
    }
}
