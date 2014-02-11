using Angular4DotNetMvc.Models.Courses;
using Angular4DotNetMvc.Models.Instructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular4DotNetMvc.Models.Registration
{
    public class RegistrationViewModelBuilder
    {
        
        public CourseViewModel[] GetCoursesVms()
        {
            var courses = new[] {
                new CourseViewModel {Number = "CREA101", Name="Care of magical creatures", Instructor = "Rubeus Hagrid"},
                new CourseViewModel {Number = "DARK502", Name="Defence against the dark arts", Instructor = "Severus Snape"},
                new CourseViewModel {Number = "TRAN201", Name="Transfiguration", Instructor = "Minerva McGonagall"}
            };

            return courses;
        }

        public InstructorViewModel[] GetInstructorsVms()
        {
            var instructors = new[] {
                new InstructorViewModel {Name= "Rubeus Hagrid", Email= "hagrid@hogwards.com", RoomNumber = 1001},
                new InstructorViewModel {Name="Severus Snape", Email= "snape@hogwards.com", RoomNumber = 105},
                new InstructorViewModel {Name="Minerva McGonagall", Email= "mcgonagall@hogwards.com", RoomNumber = 102}
            };

            return instructors;
        }
    }
}