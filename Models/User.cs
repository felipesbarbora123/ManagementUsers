using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ManagementUsers.Models
{
    public class User
    {
        [Display(Name = "Código")]
        public int ID { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Display(Name = "Data de nascimento")]
        [BindProperty, DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Telefone")]
        public string Contact { get; set; }
    }
}
