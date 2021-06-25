using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {

        public static void Executar()
        {

            double raio = 4.5;
            //double(valor real, aceita casas decimais), colocar ponto, é a mesma coisa de virgula

            const double PI = 3.14;
            // const faz com que o valor da variavel não possa ser alterada, sinal de " = " é de recebe


            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é  " + area);

            //tipos internos

            bool estaChovendo = true;
            //bool = para executar operãções logicas, apresenta valor verdadeiro ou falso, treu(verdadeiro) ou false(falso)
            Console.WriteLine("esta chevendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("idade " + idade);

            int menorValorInt = int.MinValue; //mais usado dos inteiros
            Console.WriteLine("menos int " + menorValorInt);

            uint populacaoBrasileira = int.MaxValue; //inteiro sem sinal
            Console.WriteLine("populacao Bra " + populacaoBrasileira);

            float precoComputador = 1299.99f; //sem pre que atribuir um numero em float tem que colocar f no final do numero
            Console.WriteLine("o preço é " + precoComputador);

            char letra = 'b'; // cadeia delimitada por aspas duplas = string, aspas simples so armazena uma letra
            Console.WriteLine("letra: " + letra);



        }

    }
}
