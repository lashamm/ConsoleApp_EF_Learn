using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp_EF_418.Models
{
    [Table("students")]
    internal class Student
    {
        [Key]
        [Column("student_id")]
        public uint Id { get; set; }

        [Column("student_name")]
        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        [NotMapped]
        public string FullName { get => $"{Name} {Surname}"; }

        public string Email { get; set; } = string.Empty;

        public string? PhoneNumber { get; set; }

        public int FacultyId { get; set; }

        [Required]
        [ForeignKey("FacultyId")]
        public Faculty Faculty { get; set; } = null!;
        // public Faculty? Faculty { get; set; } /*= null!;*/
    }
}
