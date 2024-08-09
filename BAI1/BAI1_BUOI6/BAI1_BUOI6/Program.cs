using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XuLI_GENERAY;
using Result_Generayy;
namespace BAI1_BUOI6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Result_Generayy.Class1 xuli = new Result_Generayy.Class1();
            // Gọi các phương thức kiểm tra
            xuli.KiemTraIntStack();
            xuli.KiemTraStringStack();
            xuli.KiemTraStackRong();

            Console.ReadLine();
        }
    }
}
