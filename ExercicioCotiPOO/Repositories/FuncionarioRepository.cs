using ExercicioCotiPOO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCotiPOO.Repositories
{
    public class FuncionarioRepository
    {
        public void ExportaDados(Funcionario funcionario)
        {
            var streamWriter = new StreamWriter("C:\\Users\\jayme\\OneDrive\\Desktop\\arquivosgerados\\funcionarios.txt", true);

            streamWriter.WriteLine("ID: " + funcionario.IdFuncionario);
            streamWriter.WriteLine("Name: " + funcionario.Name);
            streamWriter.WriteLine("Matricula: " + funcionario.Matricula);
            streamWriter.WriteLine("CPF:" + funcionario.Cpf);
            streamWriter.WriteLine("Data Admissão: " + funcionario.DataAdmissao);
            streamWriter.WriteLine("Cargo: " + funcionario.Cargo);
            streamWriter.WriteLine("Cargo: " + funcionario.Salario);

            streamWriter.WriteLine("...");

            streamWriter.Close();
        }
    }
}
