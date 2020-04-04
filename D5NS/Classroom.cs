using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5NS
{
    class Classroom
    {
        private List<Pupil> pupils = new List<Pupil>();
        private string className;

        public Classroom()
        {

        }

        public Classroom(string className)
        {
            this.className = className;
        }

        public void AddPupil(Pupil param)
        {
            pupils.Add(param);
        }

        public List<Pupil> GetPupilsList()
        {
            return pupils;
        }

        public Classroom ClassroomCopy()
        {
            Classroom temp = new Classroom();
            List<Pupil> tempList = new List<Pupil>();
            for (int i = 0; i < pupils.Count; i++)
            {
                tempList.Add(pupils[i].PupilCopy());
            }

            temp.pupils = tempList;
            temp.className = String.Copy(className);
            return temp;
        }
    }
}
