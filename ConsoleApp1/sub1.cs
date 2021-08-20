using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public class sub1
    //{
    //    public int Score;
    //    public string Name;

    //    //public sub1(int score, string name) //constructure มีหน้าที่ กำหนดค่าก่อนสร้าง obj
    //    //{
    //    //    Score = score;
    //    //    Name = name;

    //    //    // ถ้าเราสร้าง constrator แล้ว จะไม่มีตัว default มาให้

    //    //}

    //    //public sub1()
    //    //{
    //    //    // แต่สร้างเองได้นะ
    //    //}
    //}

    //public class greadcal
    //{
    //    public void cal(sub1[] b)
    //    {
    //        for (int i = 0; i < b.Length; i++)
    //        {
    //            var grade = cal(b[i]);
    //            Console.WriteLine(grade);
    //        }
    //    }

    //    public string cal(sub1 a)
    //    {
    //        if (a.Score > 90) return "A";
    //        else if (a.Score > 80) return "B";
    //        else if (a.Score > 70) return "C";
    //        else if (a.Score > 60) return "D";
    //        else return "F";

    //    }

       
    //}

    public  class sub2
    {
        public int s; // para ของ private มักใช้ตัวเล็ก

        public int S
        {
            get // อ่านค่า
            {
                return s;
            }
            set // กำหนดค่า ทำเงื่อนไข
            {
                if (value > 100) s = 100;
                else if (value < 100) s = 50;
                else s = value;
            }
        }

    }
}
