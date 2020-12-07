using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalQueue_Murphy
{
    class Patient
    {
        //holder of patient's info
        protected string _Name;
        protected int _Priority;
        public string Name { get { return _Name; } set { _Name = value; } }
        public int Priority { get { return _Priority; } set { _Priority = value; } }
        public Patient (string n, int p)
        {
            Name = n;
            Priority = p;
        }
    }
}
