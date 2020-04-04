using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5NS
{
    class Pupil
    {
        private string name;

        public Pupil()
        {

        }

        public Pupil(string name)
        {
            this.name = name;
        }

        public Pupil PupilCopy()
        {
            Pupil temp = new Pupil();
            temp.name = String.Copy(this.name);
            return temp;
        }
    }
}
