using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {   
        public Pessoa() //Construtor padrão
        {

        }
        public Pessoa(string nome, string sobrenome) //Construtor = método especial que é executado no momento em que a classe é instanciada
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public void Deconstruct (out string nome, out string sobrenome) //Desconstrutor
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome; //Campo que armazena o nome, o único que consegue modificar esse campo é a própria classe Pessoa
        private int _idade; //Campo que armazena a idade
        public string Nome
        {
            get => _nome.ToUpper(); //Retorna o nome em maiúsculo

            set
            {
                if (value == " ") //value é a palavra reservada que representa o valor que está sendo atribuído
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value; //Atribuição do valor ao campo, associa o valor atribuido ao nome no campo _nome

            }

        }
        

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); //Propriedade somente de leitura, não tem o set


        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }

                _idade = value;
            }

        }



        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}  - Idade: {Idade}");
        }

    }
}