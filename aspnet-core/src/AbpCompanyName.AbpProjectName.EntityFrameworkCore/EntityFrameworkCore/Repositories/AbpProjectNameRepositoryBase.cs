﻿using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using System;

namespace AbpCompanyName.AbpProjectName.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class AbpProjectNameRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<AbpProjectNameDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AbpProjectNameRepositoryBase(IDbContextProvider<AbpProjectNameDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="AbpProjectNameRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class AbpProjectNameRepositoryBase<TEntity> : AbpProjectNameRepositoryBase<TEntity, Guid>, IRepository<TEntity>
        where TEntity : class, IEntity
    {
        protected AbpProjectNameRepositoryBase(IDbContextProvider<AbpProjectNameDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }
}
