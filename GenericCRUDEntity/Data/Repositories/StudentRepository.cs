using GenericCRUDEntity.Data.IRepository;
using GenericCRUDEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCRUDEntity.Data.Repositories
{
    internal class StudentRepository : GenericRepository<Student> , IStudentRepository
    {

    }
}
