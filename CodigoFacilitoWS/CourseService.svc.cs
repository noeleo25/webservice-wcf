using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Data;

namespace CodigoFacilitoWS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CourseService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CourseService.svc or CourseService.svc.cs at the Solution Explorer and start debugging.
    public class CourseService : ICourseService
    {
        private CourseDataService _service;

        public CourseService()
        {
            _service = new CourseDataService();
        }

        public Course[] GetCourses()
        {
            return _service.GetCourses();
        }

        public Course GetCourseById(int id)
        {
            return _service.GetCourseById(id);
        }

        public void AddCourse(Course course)
        {
            _service.AddCourse(course);
        }

        public void DeleteCourseById(int id)
        {
            _service.DeleteCourse(id);
        }
    }
}
