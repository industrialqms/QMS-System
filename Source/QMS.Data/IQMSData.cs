﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QMS.Data.Repository;
using QMS.Models;

namespace QMS.Data
{
    public interface IQmsData : IDisposable
    {
        IRepository<User> Users { get; }

        IRepository<Area> Areas { get; }

        IRepository<Department> Departments { get; }

        IRepository<Division> Divisions { get; }

        IRepository<Document> Documents { get; }

        IRepository<Note> Notes { get; }

        IRepository<Post> Posts { get; }

        IRepository<Record> Records { get; }

        int SaveChanges();
    }
}
