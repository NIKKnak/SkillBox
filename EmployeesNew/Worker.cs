using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesNew
{
    public struct Worker
    {
        public int Id { get; set; }
        public DateTime AddedDateTime { get; set; }
        public string Fio { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }

        public Worker(int id, DateTime date, string fio, int age, int height, DateTime dateOfBirth, string placeOfBirth)
        {
            this.Id = id;
            this.AddedDateTime = date;
            this.Fio = fio;
            this.Age = age;
            this.Height = height;
            this.DateOfBirth = dateOfBirth;
            this.PlaceOfBirth = placeOfBirth;
        }
        public string ToString()
        {
            return $"{Id}#{AddedDateTime:dd.MM.yyyy HH:mm}#{Fio}#{Age}#{Height}#{DateOfBirth:dd.MM.yyyy}#{PlaceOfBirth}";
        }
    }
}








