using ExemploExplorando.Models;
using System.Globalization;



//DAteTime com TryParse

string dataString = "2024-073-31 15:30";
//É preferivel usar o TryParse, pois ele tenta converter e não gera uma exceção caso não consiga
bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {dataConvertida}");

}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}


//Console.WriteLine(dataConvertida); //Exibe a data e hora no formato padrão do sistema

// DateTime data = DateTime.Parse ("31/03/2024 15:30"); //Ano-Mês-Dia Hora:Minuto

// Console.WriteLine(data); //Exibe a data e hora no formato padrão do sistema
// //Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); //Formatação de data e hora



//Alterando a localização do código
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


// decimal valorMonetario = 1582.45M;

// //Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //C de currency (moeda)

// Console.WriteLine(valorMonetario.ToString("C2")); //C de currency (moeda) e 2 de duas casas decimais

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P")); //P de porcentagem


// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##")); //Máscara personalizada


// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2; //Concatenação de String

// Console.WriteLine(resultado); //1020






// Pessoa p1 = new Pessoa("Camila", "Mattos"); //Instanciando a classe Pessoa, criando um objeto do tipo Pessoa
// Pessoa p2 = new Pessoa(nome: "Valéria", sobrenome: "Mattos");

// Curso cursoDeInglês = new Curso();

// cursoDeInglês.Nome = "Inglês";
// cursoDeInglês.Alunos = new List<Pessoa>();
// cursoDeInglês.AdicionarAlunoa(p1);
// cursoDeInglês.AdicionarAlunoa(p2);
// cursoDeInglês.ListarAlunos();

// Console.WriteLine($"Quantidade de alunos matriculados: {cursoDeInglês.ObterQuantidadeAlunosMatriculados()}");


// cursoDeInglês.RemoverAluno(p1);
// cursoDeInglês.ListarAlunos();

// Console.WriteLine($"Quantidade de alunos matriculados: {cursoDeInglês.ObterQuantidadeAlunosMatriculados()}");


