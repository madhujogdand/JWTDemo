﻿using JWTDemo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookController : ControllerBase

    {
        private readonly IBookService service;
        public BookController(IBookService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        [Route("GetBooks")]
        public IActionResult GetBooks()
        {
            var model = service.GetBooks();
            return new ObjectResult(model);
        }
    }

}

