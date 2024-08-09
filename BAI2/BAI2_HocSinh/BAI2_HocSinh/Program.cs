using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;
using StudentManager;
namespace BAI2_HocSinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            StudentManager.StudentManager manager = new StudentManager.StudentManager();

            // Thêm sinh viên vào
            manager.AddStudentFromInput();
            manager.AddStudentFromInput();
            manager.AddStudentFromInput();

            // In sinh viên có điểm số cao nhất
            manager.PrintTopStudent();

            // Nhập giá trị ngưỡng và in sinh viên có điểm lớn hơn giá trị đó
            Console.WriteLine("Nhập ngưỡng điểm: ");
            double threshold = double.Parse(Console.ReadLine());
            manager.PrintStudentsWithGradeAbove(threshold);

            // In số lượng sinh viên đạt điểm trung bình trở lên
            manager.PrintCountStudentsWithAverageOrAbove();

            Console.ReadLine();
        }
    }
}
