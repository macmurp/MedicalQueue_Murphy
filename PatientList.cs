using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalQueue_Murphy
{
    class PatientList
    {
        //contains patients and pointers to others in list
        protected PatientList _Previous;
        protected PatientList _Next;
        protected Patient _Data;
        public PatientList Previous { get { return _Previous; } set { _Previous = value; } }
        public PatientList Next { get { return _Next; } set { _Next = value; } }
        public Patient Data { get { return _Data; } set { _Data = value; } }

        public PatientList(Patient p)
        {

            Data = p;
            Next = null;
            Previous = null;
        }
    }
}
