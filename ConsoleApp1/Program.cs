using System;

namespace ConsoleApp1
{
    class Program 
    {
        static void Main (string[] args)

            //class
            //Field (ข้อมูลที่ class สนใจ)
            //constructure
            //method
            //properties get,set
        {
            //var s1 = new sub1()
            //{
            //    Name = "jason", Score = 91
            //};


            // obj เก็บข้อมูลแบบ value
            ////s2 = s1; //  class เก็บข้อมูลแบบ ref (ร่วมกัน)                 
            //var ใช้แทน datatype เพราะ ขึ้นอยู่กับค่าที่กำหนดเป็นอะไร

            //var s2 = new sub1()
            //{
            //    Name = "joe", Score = 75

            //};

            //var b = new sub1[2] { s1, s2 };

            //greadcal cal1 = new greadcal();
            //cal1.cal(b); // 2 overload method cal

            var a = new sub2()
            {

            };
            a.S = 10000;
            Console.WriteLine(a.S);
            
            

        }
    }


}
