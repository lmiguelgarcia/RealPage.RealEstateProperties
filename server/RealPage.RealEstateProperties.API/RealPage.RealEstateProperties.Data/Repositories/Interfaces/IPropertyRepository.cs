using RealPage.RealEstateProperties.Entity;
using System.Collections.Generic;

namespace RealPage.RealEstateProperties.Data.Repositories.Interfaces
{
    public interface IPropertyRepository
    {
        List<Property> GetProperties();
        Property GetPropertyById(int id);
        int AddProperty(Property property);
        int UpdateProperty(Property property);
        int RemoveProperty(Property property);
    }
}