using RealPage.RealEstateProperties.Entity;
using System.Collections.Generic;

namespace RealPage.RealEstateProperties.Data.Repositories.Interfaces
{
    public interface IPropertyTypeRepository
    {
        List<PropertyType> GetPropertyTypes();
    }
}