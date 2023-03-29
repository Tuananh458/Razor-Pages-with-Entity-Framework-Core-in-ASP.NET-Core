using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ContosoUniversity.Models
{
    public class Student
    {
        [Key]
        public int ID102 { get; set; }


        [DisplayName("LastName")]
        
        public string LastName102 { get; set; }

        [DisplayName("FirstMidName")]
        public string FirstMidName102 { get; set; }

        [DisplayName("EnrollmentDate")]
        public DateTime EnrollmentDate102 { get; set; }


        [Required]
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}