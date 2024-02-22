using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Repository;

public interface IPersonSertvice {
    int calculateAge(DateTime DateOfBirth);
    decimal calculatedalary();
    List<string> getaddress();

}

public interface IInstructorService : IPersonSertvice {
    int calculateExperienceYear(DateTime joindate);
}

public interface IStudentService : IPersonSertvice {
    decimal calculateGPA(Dictionary<string, char> courses);
}

public interface ICourseService { 
    List<string> getenrolledstudent();
}

public interface IDepartmentService {
    List<string> getcourses();
    decimal getbudget(DateTime starttime, DateTime endtime);

}