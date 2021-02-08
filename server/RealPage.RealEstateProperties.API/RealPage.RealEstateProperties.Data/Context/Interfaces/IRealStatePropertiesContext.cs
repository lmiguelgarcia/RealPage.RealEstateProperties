using Microsoft.EntityFrameworkCore;
using System;

namespace RealPage.RealEstateProperties.Data.Context.Interfaces
{
    public interface IRealStatePropertiesContext
    {
        DbSet<T> Set<T>() where T : class;
        int SaveChanges();
    }
}
