using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;
namespace StudentManager
{
    public class StudentManager
    {
       
            private Dictionary<int, Student> students = new Dictionary<int, Student>();

            // Nhập thông tin sinh viên từ người dùng
            public void AddStudentFromInput()
            {
                Console.WriteLine("Nhập ID sinh viên: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhập tên sinh viên: ");
                string name = Console.ReadLine();

                Console.WriteLine("Nhập điểm sinh viên: ");
                double grade = double.Parse(Console.ReadLine());

                Student student = new Student { ID = id, Name = name, Grade = grade };
                students[student.ID] = student;

                Console.WriteLine("Đã thêm sinh viên: {0}, Điểm: {1}\n", student.Name, student.Grade);
            }

            // Tìm sinh viên có điểm số cao nhất
            public void PrintTopStudent()
            {
                var topStudent = students.Values.OrderByDescending(s => s.Grade).FirstOrDefault();
                if (topStudent != null)
                {
                    Console.WriteLine("Sinh viên có điểm cao nhất: {0} - {1}\n", topStudent.Name, topStudent.Grade);
                }
            }

            // Lấy danh sách tên sinh viên có điểm lớn hơn một giá trị cho trước
            public void PrintStudentsWithGradeAbove(double threshold)
            {
                var highGrades = students.Values.Where(s => s.Grade > threshold).Select(s => s.Name).ToList();
                Console.WriteLine("Sinh viên có điểm lớn hơn {0}: {1}\n", threshold, string.Join(", ", highGrades));
            }

            // Đếm số lượng sinh viên đạt điểm trung bình trở lên (>= 5.0)
            public void PrintCountStudentsWithAverageOrAbove()
            {
                int count = students.Values.Count(s => s.Grade >= 5.0);
                Console.WriteLine("Số lượng sinh viên đạt điểm trung bình trở lên: {0}\n", count);
            }
    }
}
