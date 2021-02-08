using RealPage.RealEstateProperties.Data.Context.Interfaces;
using RealPage.RealEstateProperties.Data.Repositories.Interfaces;
using RealPage.RealEstateProperties.Entity;
using System.Collections.Generic;
using System.Linq;

namespace RealPage.RealEstateProperties.Data.Repositories
{
    public class PropertyTypeRepository : IPropertyTypeRepository
    {
        #region Properties
        private readonly IRealStatePropertiesContext _context;
        #endregion
        #region Constructor
        public PropertyTypeRepository(IRealStatePropertiesContext context)
        {
            _context = context;
        }
        #endregion
        #region Methods
        public List<PropertyType> GetPropertyTypes()
        {
            return _context.Set<PropertyType>()
                .ToList();
        }
        #endregion
    }
}