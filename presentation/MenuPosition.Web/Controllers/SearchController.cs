using MenuPosition;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPosition.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly IDoctorRepository doctorRepository;
        public SearchController(IDoctorRepository doctorRepository)
        {
            this.doctorRepository = doctorRepository;
        }
        public IActionResult Index(string query)
        {
            var doctors = doctorRepository.GetAllByNameOrPosition(query);
            return View(doctors);
        }
    }
  }