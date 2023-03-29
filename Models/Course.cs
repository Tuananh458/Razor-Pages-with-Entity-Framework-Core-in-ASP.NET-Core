using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID102 { get; set; }
        public string Title102 { get; set; }
        public int Credits102 { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}