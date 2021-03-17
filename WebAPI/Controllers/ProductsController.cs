using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        //[HttpGet]
        //public string Get()
        //{
        //    return "Merhaba";
        //} 
        //Loosely Coupled
      //  naming Convention
      //IOC Container(inversion of Control)
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Get()
        {
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
