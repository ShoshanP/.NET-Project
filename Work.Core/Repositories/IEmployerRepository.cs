﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;

namespace Work.Core.Repositories
{
    public interface IEmployerRepository
    {
        DbSet<Employer> GetList();
        Employer GetById(int id);
        void Update(Employer employer);

        void DeleteById(int id);
        void Add(Employer employer);

    }
}
