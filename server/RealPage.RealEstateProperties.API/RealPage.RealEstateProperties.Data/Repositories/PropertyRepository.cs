using RealPage.RealEstateProperties.Data.Context.Interfaces;
using RealPage.RealEstateProperties.Data.Repositories.Interfaces;
using RealPage.RealEstateProperties.Entity;
using System.Collections.Generic;
using System.Linq;

namespace RealPage.RealEstateProperties.Data.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        #region Properties
        private readonly IRealStatePropertiesContext _context;
        #endregion
        #region Constructor
        public PropertyRepository(IRealStatePropertiesContext context)
        {
            _context = context;
        }
        #endregion
        #region Methods
        public int AddProperty(Property property)
        {
            _context.Set<Property>().Add(property);
            
            return _context.SaveChanges(); ;
        }
        public List<Property> GetProperties()
        {
            return _context.Set<Property>().ToList();
        }

        public Property GetPropertyById(int id)
        {
            return _context.Set<Property>().FirstOrDefault(i => i.PropertyId == id);
        }

        public int RemoveProperty(Property property)
        {
            _context.Set<Property>().Remove(property);

            return _context.SaveChanges();
        }

        public int UpdateProperty(Property property)
        {
            _context.Set<Property>().Update(property);            

            return _context.SaveChanges();
        }
        #endregion
    }
}