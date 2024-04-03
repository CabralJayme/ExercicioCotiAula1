using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCotiPOO.Entities
{
    public class Funcionario
    {
        public Guid IdFuncionario { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set;}

        public string Matricula { get; set;}
        public DateTime DataAdmissao {  get; set;}

        public string Cargo { get; set;}

        public decimal Salario { get; set;}


    }
}
