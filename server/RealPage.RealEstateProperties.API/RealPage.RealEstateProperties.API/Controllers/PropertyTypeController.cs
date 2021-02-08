using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealPage.RealEstateProperties.Business.Interfaces;
using System;

namespace RealPage.RealEstateProperties.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PropertyTypeController : ControllerBase
    {
        #region Properties
        private readonly IPropertyTypeBusiness _business;
        #endregion
        #region Constructor
        public PropertyTypeController(IPropertyTypeBusiness business)
        {
            _business = business;
        }
        #endregion
        #region Methods
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetPropertyTypes()
        {
            try
            {
                return Ok(_business.GetPropertyTypes());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }
        #endregion
    }
}