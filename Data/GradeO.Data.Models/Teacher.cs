using GradeO.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeO.Data.Models
{
    public class Teacher : BaseUser
    {
        public ICollection<Note> WrittenNotes { get; set; }

        public ICollection<Grade> WrittenGrades { get; set; }
    }
}
