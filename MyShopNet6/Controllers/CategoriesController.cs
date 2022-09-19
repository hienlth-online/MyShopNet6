﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShopNet6.Entities;

namespace MyShopNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly MyShopContext _context;

        public CategoriesController(MyShopContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Categories.ToList());
        }
    }
}
