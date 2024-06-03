using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5praktika.Models.Entities

{
	public class StudentGrade
    {
        [Key]
		[Column("grade_id")]
		public int GradeId { get; set; }
		[Column("student_id")]
		public int StudentId { get; set; }
		[Column("semester")]
		public int Semester { get; set; }
		[Column("discipline_name")]
		public string DisciplineName { get; set; }
		[Column("grade")]
		public decimal Grade { get; set; }
    }
}