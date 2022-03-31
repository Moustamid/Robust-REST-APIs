using RobustAPI.Models.Courses;

namespace RobustAPI.Services.Courses;

public interface ICourseService
{
    //- Courses
     bool DoesCourseExists(int id);

     int GerCourseCount();

     int AddCourses(Course contact);

     void DeleteCourses(int id);

     Course? GetCourse(int id);

     void UpdateCourse(Course contact);

     Course[] GetCourseList(int skip , int take);

     //- Student (With in the Course)

     bool DoesStudentExistInCourse(int courseId , int studentId);

     int GetStudentCount(int courseId);

     int AddStudentToCourse(int courseId , Student student);

     void DeleteStudentFromCourse(int courseId , int studentId);

     Student? GetStudentInCourse(int courseId , int studentId);

     void UpdateStudentInCourse(int courseId , Student student);
     
     Student[] GetStudentsInCourseList(int courseId , int skip , int take);

     void SetStudentIdentificationImage(int courseId , int studentId , byte[] image , string fileName);

}