using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Data;

namespace CodigoFacilitoWS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICourseService" in both code and config file together.
    [ServiceContract]
    public interface ICourseService
    {
        [OperationContract]
        Course[] GetCourses();

        [OperationContract]
        Course GetCourseById(int id);

        [OperationContract]
        void AddCourse(Course course);

        [OperationContract]
        void DeleteCourseById(int id);
    }
}
