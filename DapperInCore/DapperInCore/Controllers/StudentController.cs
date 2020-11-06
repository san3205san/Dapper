using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DapperInCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace DapperInCore.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {

        private readonly IMapper _mapper;

        public StudentController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public Student get()
        {
            StudentDTO st = new StudentDTO()
            {
                Age = 18,
                Name = "Bob",
                 Address=new AddressDTO()
                 {
                      Country="India",
                       State="Tamilnadu"
                 }
            };

            return _mapper.Map<Student>(st);
        }
        public IActionResult Index()
        {
            return View();
        }




    }
}