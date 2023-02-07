using System;
using System.Collections.Generic;

namespace AlunoNomes
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }

        public Aluno(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Array Alunos
            Aluno[] alunosArray = new Aluno[3];
            alunosArray[0] = new Aluno("João Silva", 123456);
            alunosArray[1] = new Aluno("Maria Oliveira", 654321);
            alunosArray[2] = new Aluno("Pedro Sousa", 111111);

            Console.WriteLine("Array de Alunos:");
            foreach (Aluno aluno in alunosArray)
            {
                Console.WriteLine("Nome: " + aluno.Nome + " - Matrícula: " + aluno.Matricula);
            }

            // List Alunos
            List<Aluno> alunosList = new List<Aluno>();
            alunosList.Add(new Aluno("João Silva", 123456));
            alunosList.Add(new Aluno("Maria Oliveira", 654321));
            alunosList.Add(new Aluno("Pedro Sousa", 111111));

            Console.WriteLine("\nLista de Alunos:");
            foreach (Aluno aluno in alunosList)
            {
                Console.WriteLine("Nome: " + aluno.Nome + " - Matrícula: " + aluno.Matricula);
            }

            Console.ReadLine();
        }
    }
}