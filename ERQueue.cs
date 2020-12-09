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
                head = new PatientList(inputdata);
                tail = head;
                count++;
                return head;
            }
            else
            {
                //add to head
                PatientList temphead = new PatientList(inputdata);
                temphead.Next = head;
                head = temphead;
                count++;
                return head;

            }
        }
        public PatientList DeQueue()
        {
            PatientList temp = head;
            if (head == null)
            {
                return null;
            }
            if (head.Next == null)
            {
                head = null;
                count--;
                return temp;
            }
            PatientList current = head;
            PatientList previous = null;
            
            while(current.Next != null)
            {
                previous = current;
                current = current.Next;
                temp = current;
            }
            //remove from tail
            previous.Next = current.Next;
            current = null;
            count--;
            return temp;
        }
        public override string ToString()
        {
            string output = "";
            if (head == null)
            {
                output += "There are 0 patients in the queue.\n";
            }
            else
            { 
                PatientList current = head;
                while (current != null)
                {
                    output += current.Data.Name + "   " + current.Data.Priority;
                    output += "\n";
                    current = current.Next;
                }
            }
            return output;
        }
    }
}
