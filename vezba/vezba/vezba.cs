using System;
using System.Collections.Generic;
using System.Text;

namespace vezba
{
    class vezba
    {
       

        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentIndex { get; set; }

        public int Points { get; set; }


        public vezba(int Id, string StudentName, string StudentIndex, int Points)
        {
            this.Id = Id;
            this.StudentName = StudentName;
            this.StudentIndex = StudentIndex;
            this.Points = Points;
        }

        

        public override string ToString()
        {
            return "Ime: " + this.StudentName + "\n" + 
                "Index" + this.StudentIndex + "\n"  +
                "Poeni:" + this.Points;
        }
    }
}
