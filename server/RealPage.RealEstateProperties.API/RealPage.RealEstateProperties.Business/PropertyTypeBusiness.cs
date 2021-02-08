using RealPage.RealEstateProperties.Business.Interfaces;
using RealPage.RealEstateProperties.Data.Repositories.Interfaces;
using RealPage.RealEstateProperties.Entity;
using System.Collections.Generic;

namespace RealPage.RealEstateProperties.Business
{
    public class PropertyTypeBusiness : IPropertyTypeBusiness
    {
        #region Properties
        private readonly IPropertyTypeRepository _repository;
        #endregion
        #region Constructor
        public PropertyTypeBusiness(IPropertyTypeRepository repository)
        {
            this._repository = repository;
        }
        #endregion
        #region Methods
        public List<PropertyType> GetPropertyTypes()
        {
            return _repository.GetPropertyTypes();
        }
        #endregion
    }
}