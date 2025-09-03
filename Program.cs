using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;


// - DESERIALIZAÇÃO -

// 1º passo: estudar o arquivo, mapear ele em uma classe

string conteudoArquivo = File.ReadAllText("Arquivos/venda.json"); //Lendo o conteúdo do arquivo

List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo); //Deserializando o conteúdo do arquivo para uma lista de objetos do tipo Venda

foreach (var venda in listaVendas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data da Venda: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
    
}

//_______________________________________________________________

// - SERIALIZAÇÃO -

// DateTime dataAtual = DateTime.Now;
// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licensa de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); //Serializa o objeto venda1 para uma string em formato JSON

// File.WriteAllText("Arquivos/venda.json", serializado); //Escreve o conteúdo serializado em um arquivo

// Console.WriteLine(serializado);

//_______________________________________________________________

// -IF TERNÁRIO-

// int num = 10;
// /*
// if (num % 2 == 0)
// {
//     Console.WriteLine($"O numero {num} é par");
// }
// else
// {
//     Console.WriteLine($"O numero {num} é ímpar");
// }
// */

// bool ehPar = num % 2 == 0;

// Console.WriteLine($"O número {num} é " + (ehPar ? "par" : "ímpar")); //If ternário, a minha variável ehPar é verdadeira, então retorna "par" | se for falsa, retorna "ímpar"




//_______________________________________________________________

// -DESCONSTRUTOR-

// Pessoa p1 = new Pessoa("Camila", "Mattos"); //Chamendo o Construtor

// (string nome, string sobrenome) = p1; //Chamando o Desconstrutor

// Console.WriteLine($"{nome} {sobrenome}");  



//_______________________________________________________________

// -TUPLA METÓDOS-

// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivos("Arquivos/arquivoLeitura.txt"); //Usando _ para ignorar o terceiro valor retornado

// if (sucesso)
// {
//     //Console.WriteLine("Quantidade de linhas do arquivo: " + qtdLinhas);
//     foreach (var linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }

// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }


// -TUPLA-

// (int Id, string Nome, string Sobrenome) tupla = (1, "Camila", "Mattos"); //Declarando uma tupla

// //ValueTuple<int, string, string> tuplaValor = (1, "Camila", "Mattos"); //Outra forma de declarar uma tupla
// //var outroExemploTuplaCreate = Tuple.Create(1, "Camila", "Mattos"); //Outra forma de declarar uma tupla

// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");



//_______________________________________________________________

//COLEÇÕES

// -DICTIONARY-

// Dictionary<string, string> estados = new Dictionary<string, string>(); //primeiro elemento é a cave e tem que ser único, o segundo é o valor

// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("MG", "Minas Gerais");
// estados.Add("BH", "Belo Horizonte");

// Console.WriteLine(estados["MG"]); //Acessando o valor através da chave

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine($"\n--------------\n"); //Acessando o valor através da chave
// //estados.Add("MG", "Minas Gerais"); //Vai gerar uma excessão, pois a chave já existe

// estados.Remove("RJ"); //Remove o item com a chave especificada

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }


// string chave = "BH";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");

// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }



// -PILHA-
/*
Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"\nRemovendo o elemento do topo: {pilha.Pop()} "); //Remove o último item da pilha

pilha.Push(10); //Adiciona um novo item ao topo da pilha

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

*/


// -LISTAS-
/*
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (var item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"\nRemovendo o elemento: {fila.Dequeue()} "); //Remove o primeiro item da fila

foreach (var item in fila)
{
    Console.WriteLine(item);
}
*/
//_______________________________________________________________

//EXCEÇÕES

//new ExemploExcessao().Metodo1();

/*
Exceptions: Os recursos de manipulação de exceções do C# permitem que você lide com erros de forma elegante, 
fornecendo mecanismos para capturar, tratar e responder a situações excepcionais que podem ocorrer durante a execução do programa.

*/
/*
try //Tente fazer algo, porém ewtá ciente que algo pode dar errado, acontecer um erro
{
    string[] linhas = File.ReadAllLines("Arquivos/d/arquivoLeitura.txt");

    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex) //Captura a excessão específica de diretório não encontrado
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch (Exception ex) //Se algo der errado, capture a excessão e faça algo com ela
{
    Console.WriteLine($"Ocorreu uma excessão genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou no bloco finally");
    //Bloco opcional, sempre será executado, independente se deu erro ou não
}


*/




//_______________________________________________________________

//DateTime com TryParse

// string dataString = "2024-073-31 15:30";
// //É preferivel usar o TryParse, pois ele tenta converter e não gera uma exceção caso não consiga
// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {dataConvertida}");

// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }


//Console.WriteLine(dataConvertida); //Exibe a data e hora no formato padrão do sistema

// DateTime data = DateTime.Parse ("31/03/2024 15:30"); //Ano-Mês-Dia Hora:Minuto

// Console.WriteLine(data); //Exibe a data e hora no formato padrão do sistema
// //Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); //Formatação de data e hora


//_______________________________________________________________

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



//_______________________________________________________________


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


