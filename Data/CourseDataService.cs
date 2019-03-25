using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Data
{
    public class CourseDataService
    {
        private List<Course> Courses { get; set; } //lista de cursos
        string route = @"C:\Users\Noemi Leon\Documents\Cursos\Codigo Facilito\tmp\courses.dat";
        //constructor de la clase
        public CourseDataService()
        {
            if (File.Exists(route))
            {
                var formatter = new BinaryFormatter();
                using (var stream = new FileStream(route, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    Courses = (List<Course>)formatter.Deserialize(stream); //deserializa archivo para convertir en lista
                }
            }
            else
            {
                Courses = new List<Course>();
                CreateCourses();
            }
        }
        //crea objetos curso para utilizarlos en las pruebas
        private void CreateCourses()
        {
            this.Courses.Add(new Course()
            {
                CourseId = 1,
                Name = "Introduccion a servicios web con .NET",
                Duration = 10800,
                InstructorName = "Noemi Leon"
            });
            this.Courses.Add(new Course()
            {
                CourseId = 2,
                Name = "Introduccion a React",
                Duration = 16000,
                InstructorName = "Uriel Hernandez"
            });

            Save();
        }
        //guarda cursos de la lista courses en archivo serializando
        private void Save()
        {
            var formatter = new BinaryFormatter();
            using (var stream = new FileStream(route, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, Courses);
            }
        }
        //obtiene la lista de cursos
        public Course[] GetCourses()
        {
            return Courses.ToArray();
        }
        //obtiene curso por id
        public Course GetCourseById(int id)
        {
            return Courses.SingleOrDefault(p => p.CourseId == id);
        }
        //agrega un curso
        public void AddCourse(Course course)
        {
            var lastCourseId = Courses.Max(c => c.CourseId);
            course.CourseId = lastCourseId + 1;
            Courses.Add(course);
            Save();
        }
        //eliminar un curso
        public void DeleteCourse(int id)
        {
            var course = Courses.SingleOrDefault(c => c.CourseId == id);
            Courses.Remove(course);
            Save();
        }
    }
}
