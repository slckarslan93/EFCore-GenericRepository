using DataAccess.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class Repository<TEntity,TContext>:IAsyncRepository<TEntity>,IRepository<TEntity>
        where TEntity : BaseEntity
        where TContext:DbContext
    {

    }
}
