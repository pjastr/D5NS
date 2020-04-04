using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5NS
{
    class School
    {
        private List<Classroom> cls = new List<Classroom>();
        private string adrress;

        public School()
        {

        }

        public School(string adrress)
        {
            this.adrress = adrress;
        }

        public void AddClassroom(Classroom param)
        {
            cls.Add(param);
        }

        public List<Classroom> GetClassrooms()
        {
            return cls;
        }

        public string GetAdress()
        {
            return adrress;
        }

        public School SchoolCopy()
        {
            School temp = new School();
            temp.adrress = String.Copy(this.adrress);
            List<Classroom> tempList = new List<Classroom>();
            for (int i = 0; i < cls.Count; i++)
            {
                tempList.Add(cls[i].ClassroomCopy());
            }

            temp.cls = tempList;
            return temp;
        }
    }
}
