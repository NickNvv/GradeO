using GradeO.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeO.Data.Models
{
    public class Student : BaseUser
    {
        public ICollection<Note> ReceivedNotes { get; set; }

        public ICollection<Grade> ReceivedGrades { get; set; }
    }
}
