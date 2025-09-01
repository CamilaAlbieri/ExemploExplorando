using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }


        public void AdicionarAlunoa(Pessoa aluno)
        {
            Alunos.Add(aluno); //Adiciona um aluno na lista de alunos
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            int qtd = Alunos.Count; //Obtém a quantidade de alunos na lista
            return qtd;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno); //Remove um aluno da lista
        }

        public  void ListarAlunos()
        {
            foreach (var aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }




    }       
}