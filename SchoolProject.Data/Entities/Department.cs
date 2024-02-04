using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class Department
    {
        public Department()
        {
            Students = new HashSet<Student>(); //HashSet: is an array that doesn't allow duplication of values.
            DepartmentSubjects = new HashSet<DepartmentSubject>();
        }
        [Key]
        public int DID { get; set; }
        [StringLength(500)]
        public string DName { get; set; }

        [InverseProperty("Department")] // inverse property to 'Department Department' which is located inside Student class.
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<DepartmentSubject> DepartmentSubjects { get; set; }
    }
}
