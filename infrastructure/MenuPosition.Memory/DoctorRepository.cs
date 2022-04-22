using System;
using System.Linq;

namespace MenuPosition.Memory
{
    public class DoctorRepository:IDoctorRepository
    {
        private readonly Doctor[] doctors = new[]
        {
new Doctor(1,"Хирург Павел Игнатович Чеччер"),
new Doctor(2,"Акушер Василий Игнатович Булава"),
new Doctor(2,"Окулист Анастасия Сергеевна Лапочка"),
        };

        public Doctor[] GetAllByName(string namePart)
        {
            return doctors.Where(doctors => doctors.Name.Contains(namePart))
                            .ToArray();
                }
    }
}
