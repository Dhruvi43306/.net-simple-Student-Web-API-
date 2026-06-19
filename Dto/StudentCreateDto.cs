using System.ComponentModel.DataAnnotations;

namespace Student.Dto
{
    public class StudentCreateDto
    {

        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }


        [Required]
        [StringLength(50)]
        public string City { get; set; }
    }
}
