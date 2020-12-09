using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalQueue_Murphy
{
    class PatientList
    {
        //contains patients and pointers to next in list, singly linked
        protected PatientList _Next;
        protected Patient _Data;
        public PatientList Next { get { return _Next; } set { _Next = value; } }
        public Patient Data { get { return _Data; } set { _Data = value; } }

        public PatientList(Patient p)
        {

            Data = p;
            Next = null;
        }
    }
}
