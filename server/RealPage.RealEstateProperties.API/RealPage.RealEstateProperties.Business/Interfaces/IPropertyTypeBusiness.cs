using RealPage.RealEstateProperties.Entity;
using System.Collections.Generic;

namespace RealPage.RealEstateProperties.Business.Interfaces
{
    public interface IPropertyTypeBusiness
    {
        List<PropertyType> GetPropertyTypes();
    }
}