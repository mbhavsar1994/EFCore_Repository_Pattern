﻿using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using PocketBook.Core.IRepositories;
using PocketBook.Data;

namespace PocketBook.Core.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T: class
{

    protected ApplicationDbContext _context;
    protected DbSet<T> dbSet;
    protected readonly ILogger _logger;

    public GenericRepository(
        ApplicationDbContext context,
        ILogger logger)
    {
        _context = context;
        _logger = logger;
        dbSet = context.Set<T>();
    }

    public virtual async Task<IEnumerable<T>> All()
    {
       return await dbSet.ToListAsync();
    }

    public virtual async Task<T> GetById(Guid id)
    {
        return await dbSet.FindAsync(id);
    }

    public virtual async Task<bool> Add(T entity)
    {
        await dbSet.AddAsync(entity);
        return true;
    }

    public virtual Task<bool> Delete(Guid id)
    {
       throw new  NotImplementedException();
    }

    public virtual Task<bool> Upsert(T entity)
    {
        throw new NotImplementedException();
    }
}
