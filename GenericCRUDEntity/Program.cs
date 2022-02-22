using GenericCRUDEntity.Data.Contexts;
using GenericCRUDEntity.Data.Repositories;
using GenericCRUDEntity.Models;
using System;
using System.Threading.Tasks;

namespace GenericCRUDEntity
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
           

            //Student std = new Student()
            //{
            //    Id = 5,
            //    FirstName = "Alijon",
            //    LastName = "Karimov",
            //    Age = 25,
            //    Email = "alijon@gmail.com",
            //    Password = "70078005"

            //};

          
            
            StudentRepository studentrepo = new StudentRepository();

           // await studentrepo.UpdateAsync(std);
            var students = await studentrepo.GetAllAsync();

            foreach (var student in students)
                Console.WriteLine(student.Id + " " + student.FirstName);
        }
    }
}
