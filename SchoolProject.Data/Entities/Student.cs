using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        [StringLength(500)]
        public string Phone { get; set; }
        public int? DID { get; set; }

        [ForeignKey("DID")]
        [InverseProperty("Students")] // inverse property to 'ICollection<Student> Students' which is located inside Department class.
        public virtual Department Department { get; set; } // Student class will include Department class in it.
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
