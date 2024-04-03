

using ExercicioCotiPOO.Entities;
using ExercicioCotiPOO.Repositories;

Console.WriteLine("CADASTRO DE FUNCIONARIOS: ");

var funcionario = new Funcionario();

funcionario.IdFuncionario = Guid.NewGuid();
funcionario.DataAdmissao = DateTime.Now;

Console.Write("INFORME O NOME DO FUNCIONARIO:  ");
funcionario.Name = Console.ReadLine();

Console.Write("INFORME A MATRICULA DO FUNCIONARIO:  ");
funcionario.Matricula = Console.ReadLine();

Console.Write("INFORME O CPF DO FUNCIONARIO:  ");
funcionario.Cpf = Console.ReadLine();

Console.Write("INFORME O CARGO DO FUNCIONARIO:  ");
funcionario.Cargo = Console.ReadLine();

Console.Write("INFORME O SALARIO DO FUNCIONARIO:  ");
funcionario.Salario = decimal.Parse(Console.ReadLine());

Console.WriteLine("##################################################");

var funcionarioRepository = new FuncionarioRepository();


funcionarioRepository.ExportaDados(funcionario);


// Dados do Funcionario 

Console.WriteLine("DADOS DO FUNCIONARIO: ");
Console.WriteLine("ID: " + funcionario.IdFuncionario);
Console.WriteLine("NOME: " + funcionario.Name);
Console.WriteLine("MATRICULA: " + funcionario.Matricula);
Console.WriteLine("CPF: " + funcionario.Cpf);
Console.WriteLine("CARGO: " + funcionario.Cargo);
Console.WriteLine("SALARIO: " + funcionario.Salario);
Console.WriteLine("DATA ADMISSAO: " + funcionario.DataAdmissao);
