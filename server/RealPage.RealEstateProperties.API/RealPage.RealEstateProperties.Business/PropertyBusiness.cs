using RealPage.RealEstateProperties.Business.Interfaces;
using RealPage.RealEstateProperties.Data.Repositories.Interfaces;
using RealPage.RealEstateProperties.Entity;
using RealPage.RealEstateProperties.Entity.Dto;
using System;
using System.Collections.Generic;

namespace RealPage.RealEstateProperties.Business
{
    public class PropertyBusiness : IPropertyBusiness
    {
        #region Properties
        private readonly IPropertyRepository _repository;
        #endregion
        #region Constructor
        public PropertyBusiness(IPropertyRepository repository)
        {
            this._repository = repository;
        }
        #endregion
        #region Methods        
        public List<Property> GetProperties()
        {
            return _repository.GetProperties();
        }
        public Property GetPropertyById(int id)
        {
            if (id == 0)
                throw new ArgumentNullException("Campo id debe tener valor");
            var property = _repository.GetPropertyById(id);
            if (property == null)
                throw new Exception(string.Format("La propiedad con Id {0} no existe", id));

            return property;
        }
        public int AddProperty(PropertyViewModel property)
        {
            var propertyToAdd = new Property()
            {
                Address = property.Address,
                DateOnMarket = property.DateOnMarket,
                Description = property.Description,
                Name = property.Name,
                Owner = property.Owner,
                PropertyTypeId = property.PropertyTypeId,
                RoomCount = property.RoomCount
            };

            return _repository.AddProperty(propertyToAdd);
        }

        public int RemoveProperty(int id)
        {
            var property = GetPropertyById(id);
            return _repository.RemoveProperty(property);
        }

        public int UpdateProperty(PropertyViewModel property)
        {
            var propertyEdited = GetPropertyById(property.PropertyId);
            propertyEdited.Address = property.Address;
            propertyEdited.DateOnMarket = property.DateOnMarket;
            propertyEdited.Description = property.Description;
            propertyEdited.Name = property.Name;
            propertyEdited.Owner = property.Owner;
            propertyEdited.PropertyTypeId = property.PropertyTypeId;
            propertyEdited.RoomCount = property.RoomCount;

            return _repository.UpdateProperty(propertyEdited);
        }
        #endregion
    }
}