using System.ComponentModel.DataAnnotations;

namespace TestSystem.Models
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Введите название теста")]
        [Required(ErrorMessage = "Вам нужно ввести название")]
        public string Name { get; set; }
        [Display(Name="Введите описание")]
        [StringLength(50, ErrorMessage = "Описание должно составлять менее 10 символов")]
        [Required(ErrorMessage = "Вам нужно ввести описание")]
        public string Description { get; set; } 

       //public DateTime Date { get; set; }
    }
}
