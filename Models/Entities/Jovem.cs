using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using CrudAspNet.Models.Entities.Enums;
using System.Threading.Tasks;

namespace CrudAspNet.Models.Entities
{
   [Table("Jovem")]
    public class Jovem
    {
        [Display(Description = "Código")]
        public int Id { get; set; }

        [Display(Description = "Nome")]
        public string Nome { get; set; }

        [Display(Description = "Email")]
        public string Email { get; set; }

        [Display(Description = "Telefone")]
        public int Telefone { get; set; }

        [Display(Description ="Endereço")]
        public string Endereco { get; set; }

        [Display(Description ="Cidade")]
        public string Cidade { get; set; }

        [Display(Description ="UF")]
        public string UF { get; set; }
        
        [Display(Description ="Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Display(Description ="Sexo")]
        public Sexo Sexo { get; set; }
        
        
        public Jovem()
        {
        }

        public Jovem(int id, string nome, string email, int telefone, string endereco, string cidade, 
            string uF, DateTime dataNascimento, Sexo sexo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Cidade = cidade;
            UF = uF;
            DataNascimento = dataNascimento;
            Sexo = sexo;
        }
    }
}
