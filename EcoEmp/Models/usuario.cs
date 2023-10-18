using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoEmp.Models
{

    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o login!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o telefone!")]
        public string Telefone { get; set; }

       

    }
}
