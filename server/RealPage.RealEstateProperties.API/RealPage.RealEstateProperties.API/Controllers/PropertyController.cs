using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealPage.RealEstateProperties.Business.Interfaces;
using RealPage.RealEstateProperties.Entity.Dto;
using System;
using System.ComponentModel.DataAnnotations;

namespace RealPage.RealEstateProperties.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        #region Properties
        private readonly IPropertyBusiness _business;
        #endregion
        #region Constructor
        public PropertyController(IPropertyBusiness business)
        {
            _business = business;
        }
        #endregion
        #region Methods
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetProperties()
        {
            try
            {
                return Ok(_business.GetProperties());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetPropertyById([Required] int id)
        {
            try
            {
                return Ok(_business.GetPropertyById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult AddProperty([Required] PropertyViewModel property)
        {
            try
            {
                return Ok(_business.AddProperty(property));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }
        [HttpPut]
        [Route("[action]")]
        public IActionResult UpdateProperty([Required] PropertyViewModel property)
        {
            try
            {
                return Ok(_business.UpdateProperty(property));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }
        [HttpDelete]
        [Route("[action]")]
        public IActionResult RemoveProperty([Required] int id)
        {
            try
            {
                return Ok(_business.RemoveProperty(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }
        #endregion
    }
}