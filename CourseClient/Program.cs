using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseClient.Data;
using CourseClient.ServiceReference1;

namespace CourseClient
{
    class Program
    {
        private static CourseDataService _service;

        static void Main(string[] args)
        {
            _service = new CourseDataService();

            string input = "";
            while (input != "X")
            {
                Console.WriteLine("1: Ver lista de cursos");
                Console.WriteLine("2: Ver curso por id");
                Console.WriteLine("3: Agregar curso");
                Console.WriteLine("4: Eliminar cursos por id");
                Console.WriteLine("X: Salir");
                Console.Write("Please enter a command: ");
                input = Console.ReadLine();

                ExecuteOption(input);
            }
        }

        private static void ExecuteOption(string opt)
        {
            switch (opt)
            {
                case "1":
                    GetCourses();
                    break;
                case "2":
                    GetCourseById();
                    break;
                case "3":
                    AddCourse();
                    break;
                case "4":
                    DeleteCourseById();
                    break;
            }
        }

        static void GetCourses()
        {
            var courses = _service.GetCourses();
            foreach (var c in courses)
            {
                Console.WriteLine("");
                Console.WriteLine("{0}) {1}", c.CourseId, c.Name);
                Console.WriteLine("Instructor: {0}", c.InstructorName);
                Console.WriteLine("Duracion: {0} s", c.Duration);
            }
            Console.WriteLine("");
        }

        static void GetCourseById()
        {
            Console.WriteLine("Introduce el Id");
            string input = Console.ReadLine();
            int id;
            Int32.TryParse(input, out id);
            var c = _service.GetCourseById(id);
            Console.WriteLine("");
            Console.WriteLine("{0}) {1}", c.CourseId, c.Name);
            Console.WriteLine("Instructor: {0}", c.InstructorName);
            Console.WriteLine("Duracion: {0} s", c.Duration);
            
            Console.WriteLine("");
        }

        static void AddCourse()
        {
            Console.Write("Introduce Id");
            int id = 0;
            var input = Console.ReadLine();
            Int32.TryParse(input, out id);
            Console.Write("Introduce Nombre");
            var name = Console.ReadLine();
            Console.Write("Introduce Duracion");
            Int16 dur = 0;
            input = Console.ReadLine();
            Int16.TryParse(input, out dur);
            Console.Write("Introduce el Instructor");
            var inst = Console.ReadLine();
            var course = new Course
            {
                CourseId = id,
                Name = name,
                Duration = dur,
                InstructorName = inst
            };
            _service.AddCourse(course);
        }

        static void DeleteCourseById()
        {
            Console.WriteLine("Introduce el Id");
            string input = Console.ReadLine();
            int id;
            Int32.TryParse(input, out id);
            _service.DeleteCourseById(id);
        }
    }
}
