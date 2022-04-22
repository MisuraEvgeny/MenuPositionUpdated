using System;
using System.Linq;

namespace MenuPosition.Memory
{
    public class DoctorRepository:IDoctorRepository
    {
        private readonly Doctor[] doctors = new[]
        {
new Doctor(1,"Доктор Хирург Павел Игнатович Чеччер"),
new Doctor(2,"Доктор Акушер Василий Игнатович Булава"),
new Doctor(3,"Доктор Окулист Анастасия Сергеевна Лапочка"),
        };

        public Doctor[] GetAllByNameOrPosition(string namePart)
        {
            return doctors.Where(doctors => doctors.Name.Contains(namePart))
                            .ToArray();
        }
        //        <form action = "/search" method="g">
        //    <input type = "text" name="query" value="" />
        //    <button type = "submit" > Найти </ button >
        //</ form >

        //   public class SearchController : Controller
        //   {
        //    private readonly IDoctorRepository doctorRepository;
        //    public SearchController(IDoctorRepository doctorRepository)
        //    {
        //        this.doctorRepository = doctorRepository;
        //    }
        //    public IActionResult Index(string query)
        //    {
        //        var doctors = doctorRepository.GetAllByTitle(query);
        //        return View(query);
        //    }
        //    }
    }
}
