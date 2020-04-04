using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5NS
{
    class Program
    {
        static void Main(string[] args)
        {
            School sch = new School("54 Sloneczna Street");
            Pupil p1 = new Pupil("John");
            Pupil p2 = new Pupil("Anna");
            Pupil p3 = new Pupil("Tom");
            Pupil p4 = new Pupil("Claudia");
            Classroom c1 = new Classroom("3A");
            c1.AddPupil(p1);
            c1.AddPupil(p2);
            Classroom c2 = new Classroom("2E");
            c2.AddPupil(p3);
            c2.AddPupil(p4);

            sch.AddClassroom(c1);
            sch.AddClassroom(c2);

            School copy = sch.SchoolCopy();
            bool test1 = Object.ReferenceEquals(sch, copy);
            bool test2 = Object.ReferenceEquals(sch.GetClassrooms(), copy.GetClassrooms());
            bool test2a = Object.ReferenceEquals(sch.GetAdress(), copy.GetAdress());
            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine(test2a);
            for (int i = 0; i < sch.GetClassrooms().Count; i++)
            {
                bool test3 = Object.ReferenceEquals(sch.GetClassrooms()[i], copy.GetClassrooms()[i]);
                Console.WriteLine(test3);
            }
            Console.ReadKey();
        }
    }
}
