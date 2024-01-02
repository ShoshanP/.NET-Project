using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;

namespace Work.Core.Repositories
{
    public interface IJobRepository
    {
        DbSet<Job> GetList();
        Job GetById(int id);
        
        void DeleteById(int id);
        Job Update(Job job);

        Job Add(Job job);
    }
}
