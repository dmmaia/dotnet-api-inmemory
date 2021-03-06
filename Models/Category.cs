using System.ComponentModel.DataAnnotations;
namespace test_api_dotnet.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este deve conter entre 3 e 60 caracteres")]
        public string Title {get; set;}
    }
}