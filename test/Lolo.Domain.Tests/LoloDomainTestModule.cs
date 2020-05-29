﻿using Lolo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Lolo
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(LoloEntityFrameworkCoreTestModule)
        )]
    public class LoloDomainTestModule : AbpModule
    {
        
    }
}
