using ExemploExplorando.Models;


Pessoa p1 = new Pessoa("Camila", "Mattos"); //Instanciando a classe Pessoa, criando um objeto do tipo Pessoa
Pessoa p2 = new Pessoa(nome: "Valéria", sobrenome: "Mattos");

Curso cursoDeInglês = new Curso();

cursoDeInglês.Nome = "Inglês";
cursoDeInglês.Alunos = new List<Pessoa>();
cursoDeInglês.AdicionarAlunoa(p1);
cursoDeInglês.AdicionarAlunoa(p2);
cursoDeInglês.ListarAlunos();

Console.WriteLine($"Quantidade de alunos matriculados: {cursoDeInglês.ObterQuantidadeAlunosMatriculados()}");


cursoDeInglês.RemoverAluno(p1);
cursoDeInglês.ListarAlunos();

Console.WriteLine($"Quantidade de alunos matriculados: {cursoDeInglês.ObterQuantidadeAlunosMatriculados()}");


