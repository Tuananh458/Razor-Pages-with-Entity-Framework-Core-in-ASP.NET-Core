using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstMidName102="Carson",LastName102="Alexander",EnrollmentDate102=DateTime.Parse("2019-09-01")},
                new Student{FirstMidName102 = "Meredith", LastName102 = "Alonso", EnrollmentDate102 = DateTime.Parse("2017-09-01")},
                new Student{FirstMidName102 = "Arturo", LastName102 = "Anand", EnrollmentDate102 = DateTime.Parse("2018-09-01")},
                new Student{FirstMidName102 = "Gytis", LastName102 = "Barzdukas", EnrollmentDate102 = DateTime.Parse("2017-09-01")},
                new Student{FirstMidName102 = "Yan", LastName102 = "Li", EnrollmentDate102 = DateTime.Parse("2017-09-01")},
                new Student{FirstMidName102 = "Peggy", LastName102 = "Justice", EnrollmentDate102 = DateTime.Parse("2016-09-01")},
                new Student{FirstMidName102 = "Laura", LastName102 = "Norman", EnrollmentDate102 = DateTime.Parse("2018-09-01")},
                new Student{FirstMidName102 = "Nino", LastName102 = "Olivetto", EnrollmentDate102 = DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID102=1050,Title102="Chemistry",Credits102=3},
                new Course{CourseID102 = 4022, Title102 = "Microeconomics", Credits102 = 3},
                new Course{CourseID102 = 4041, Title102 = "Macroeconomics", Credits102 = 3},
                new Course{CourseID102 = 1045, Title102 = "Calculus", Credits102 = 4},
                new Course{CourseID102 = 3141, Title102 = "Trigonometry", Credits102 = 4},
                new Course{CourseID102 = 2021, Title102 = "Composition", Credits102 = 3},
                new Course{CourseID102 = 2042, Title102 = "Literature", Credits102 = 4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID102=1,CourseID102=1050,Grade=Grade.A},
                new Enrollment{StudentID102=1,CourseID102=4022,Grade=Grade.C},
                new Enrollment{StudentID102=1,CourseID102=4041,Grade=Grade.B},
                new Enrollment{StudentID102=2,CourseID102=1045,Grade=Grade.B},
                new Enrollment{StudentID102=2,CourseID102=3141,Grade=Grade.F},
                new Enrollment{StudentID102=2,CourseID102=2021,Grade=Grade.F},
                new Enrollment{StudentID102=3,CourseID102=1050},
                new Enrollment{StudentID102=4,CourseID102=1050},
                new Enrollment{StudentID102 = 4, CourseID102 = 4022,Grade=Grade.F},
                new Enrollment{StudentID102 = 5, CourseID102 = 4041,Grade=Grade.C},
                new Enrollment{StudentID102 = 6, CourseID102 = 1045},
                new Enrollment{StudentID102 = 7, CourseID102 = 3141,Grade=Grade.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}