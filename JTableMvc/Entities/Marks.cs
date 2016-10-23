using System.ComponentModel.DataAnnotations;

namespace JTableMvc.Entities
{
    public class Marks
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public int RollNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string MarksObtained { get; set; }
        [Required]
        public string TotalMarks { get; set; }
    }
}