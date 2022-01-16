using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GradeO.Data.Models
{
    public class Note

    {
        [Key]
        public int Id { get; set; }

        public string NoteMessage { get; set; }

        public Teacher Teacher { get; set; }

        public int TeacherId { get; set; }

        public Student Student { get; set; }

        public int StudentId { get; set; }

        public Subject Subject { get; set; }

        public int SubjectId { get; set; }
    }
}
