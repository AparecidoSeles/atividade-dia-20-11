using System;

namespace atividade_dia_20_11
{
    class Program
    {      
        
                //Faça um programa que receba o nome e quatro notas de 10 alunos e armazene essa notas em vetores.
                // calcule e mostre:
                //A. a media do aluno
                //B. A quanridade de aprovados( media >= 7)
                //C. Quanaridade de reprovados( media < 7)
                //media geral dos alunos

        static void Main(string[] args)
        {
            Console.WriteLine("Atividade alunos aprovados e reprovados");

            string[] nomes = new string[10];
            float [] notas = new float [4];
            
            for (var contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("Digite seu nome");
                nomes[contador] = Console.ReadLine();
                for (var i = 0; i < 4; i++)
                {
                    Console.WriteLine("Digite 1º nota");
                     notas[contador] = float.Parse(Console.ReadLine());

                    // Console.WriteLine("Digite 2º nota");
                    //  notas[contador] = float.Parse(Console.ReadLine());

                    // Console.WriteLine("Digite 3º nota");
                    //  notas[contador] = float.Parse(Console.ReadLine());

                    // Console.WriteLine("Digite 4º nota");
                    //  notas[contador] = float.Parse(Console.ReadLine());

                }   
                

            }
            
        }

        // foreach (var item in collection)
        // {
            
        // }
    }
}
