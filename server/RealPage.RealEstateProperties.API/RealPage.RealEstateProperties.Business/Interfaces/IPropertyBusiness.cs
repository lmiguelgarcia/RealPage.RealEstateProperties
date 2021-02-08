using RealPage.RealEstateProperties.Entity;
using RealPage.RealEstateProperties.Entity.Dto;
using System.Collections.Generic;

namespace RealPage.RealEstateProperties.Business.Interfaces
{
    public interface IPropertyBusiness
    {
        List<Property> GetProperties();
        Property GetPropertyById(int id);
        int AddProperty(PropertyViewModel property);
        int UpdateProperty(PropertyViewModel property);
        int RemoveProperty(int id);
    }
}