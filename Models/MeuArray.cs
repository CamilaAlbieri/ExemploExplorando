using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class MeuArray<T> //T é um tipo genérico
    {
        private static int capacidade = 10;
        private int contador = 0;

        //private int[] array = new int[10];
        private T[] array = new T[capacidade];

        public void AdicionarElemento(T elemento)
        {
            if (contador + 1 < 11)
            {
                array[contador] = elemento;
            }
            contador++;
        }

        //define um indexador para a classe MeuArray<T>.
        //O indexador permite acessar ou modificar elementos do array interno usando a sintaxe de colchetes, como em um array comum.
        public T this[int index]
        {
            get { return array[index]; } //  retorna o elemento na posição index.
            set { array[index] = value; } // define o valor na posição index.
        }

    }
}