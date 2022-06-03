using System.ComponentModel.DataAnnotations;

namespace CleanArch.Application.DTOs
{
    public class CategoryDTO
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
