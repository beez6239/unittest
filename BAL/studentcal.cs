using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DAL;

namespace BAL
{
    public class studentcal
    {
        static void Main(string[] args)
        {
            studentcal student = new studentcal();
            student.getstudents();
            
            //excellent_students();
            Console.ReadLine();




        }


        public  bool getstudents()
        {

            String[] csvlines = File.ReadAllLines(@"C:\Users\OSAS\Desktop\Students.csv");
            var students = new List<Students>();
            for (int i = 0; i < csvlines.Length; i++)
            {
                Students st = new Students(csvlines[i]);
                students.Add(st);

            }

            Console.WriteLine("All Students");
            for (int i = 1; i < students.Count; i++)
            {

                Console.WriteLine(students[i]+ "\n");
            }




            Console.WriteLine("Students that got excellent grades");
            for (int i = 1; i < students.Count; i++)
            {
                Students stud = new Students(csvlines[i]);

                if (stud.Score > 89)
                {
                    Console.WriteLine(students[i]);
                }



            }
            return true;
        }



        //public static bool excellent_students()
        //{

        //    String[] csvlines = File.ReadAllLines(@"C:\Users\OSAS\Desktop\Students.csv");
        //    var students = new List<Students>();

        //    Console.WriteLine("Students that got excellent grades");
        //    for (int i = 1; i < students.Count; i++)
        //    {
        //        Students stud = new Students(csvlines[i]);

        //        if (stud.Score > 89)
        //        {
        //            Console.WriteLine(students[i]);
        //        }

        //    }
        //    return true;           
        //}
    }
  
}
