using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalQueue_Murphy
{
    class ERQueue
    {
        PatientList head;
        PatientList tail;
        int count = 0;
        public int QueueCount()
        {
            return count;
        }
        public PatientList EnQueue(Patient inputdata)
        {
            if (head == null)
            {
                //create head if none exists
                head = new PatientList(inputdata);
                tail = head;
                count++;
                return head;
            }
            else
            {
                //add to head otherwise
                PatientList temphead = new PatientList(inputdata);
                temphead.Next = head;
                head = temphead;
                count++;
                return head;

            }
        }
        public PatientList DeQueue()
        {
            if (head == null)
            {
                //don't remove if empty
                return null;
            }
            else
            {
                PatientList temptail = tail;
                tail.Previous.Next = null;
                //fix error here?
                tail.Next = null;
                tail = null;
                count--;
                return temptail;
            }
        }
        public override string ToString()
        {
            if (head == null)
            {
                //don't write if empty
                return null;
            }
            else
            {
                string output = "";
                PatientList current = head;
                while (current != null)
                {
                    output += current.Data.Name + "   " + current.Data.Priority;
                    output += "\n";
                    current = current.Next;
                }
                return output;
            }
        }
    }
}
