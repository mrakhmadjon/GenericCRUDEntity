using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCRUDEntity.Models
{
    [Table("students")]
    internal class Student
    {
        [Key,Column("id")]
        public int Id { get; set; }

        [Column("firstname"),MaxLength(30),Required]
        public string FirstName { get; set; }

        [Column("lastname"), MaxLength(30)]

        public string LastName { get; set; }

        [Column("age")]
        public int Age { get; set; }


        [Column("email"),MaxLength(20)]
        public string Email { get; set; }

        [Column("password"), MaxLength(20)]

        public string Password { get; set; }
    }
}
