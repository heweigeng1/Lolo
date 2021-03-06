﻿using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Lolo.EntityFrameworkCore
{
    [ConnectionStringName(LoloDbProperties.MongoDbConnectionStringName)]
    public interface ILoloDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}