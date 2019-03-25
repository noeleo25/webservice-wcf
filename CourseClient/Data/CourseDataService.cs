using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseClient.ServiceReference1;

namespace CourseClient.Data
{
    class CourseDataService
    {
        private CourseServiceClient _client;

        public CourseDataService()
        {
            _client = new CourseServiceClient();
        }

        public Course[] GetCourses()
        {
            return _client.GetCourses();
        }

        public Course GetCourseById(int id)
        {
            return _client.GetCourseById(id);
        }

        public void AddCourse(Course course)
        {
            _client.AddCourse(course);
        }

        public void DeleteCourseById(int id)
        {
            _client.DeleteCourseById(id);
        }
    }
}
