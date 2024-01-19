using System;
using System.Collections.Generic;
using System.Linq;

namespace Faculdade.Models
{
    public class Alunos
    {
        private List<Pessoa> alunos = new List<Pessoa>();

        public void AdicionarAluno()
        {
            Console.WriteLine("Qual o nome do aluno ?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a idade do aluno ?");
            int idade;

            while (!int.TryParse(Console.ReadLine(), out idade))
            {
                Console.WriteLine("Por favor, insira uma idade válida.");
            }
            if (idade < 18)
            {
                Console.WriteLine("O aluno deve ser maior de idade para concluir a matrícula");
            }
            else
            {

                Console.WriteLine("Qual o email do aluno?");
                string email = Console.ReadLine();

                Console.WriteLine("Qual o CPF do aluno?");
                int cpf;
                while (!int.TryParse(Console.ReadLine(), out cpf))
                {
                    Console.Write("Digite um CPF válido:");
                }

                if (alunos.Any(x => x.Cpf == cpf))
                {
                    Console.WriteLine("CPF já cadastrado");
                }
                else
                {
                    Pessoa novoAluno = new Pessoa(nome);
                    novoAluno.Idade = idade;
                    novoAluno.Email = email;
                    novoAluno.Cpf = cpf;

                    alunos.Add(novoAluno);
                    Console.WriteLine($"O aluno {nome} de CPF {cpf} foi cadastrado com sucesso");
                }
            }
        }

        public void RemoverAluno()
        {
            Console.WriteLine("Digite o CPF do aluno que deseja remover:");
            int cpf;
            while (!int.TryParse(Console.ReadLine(), out cpf))
            {
                Console.WriteLine("Este CPF não consta em nossa base de dados");
            }

            Pessoa alunoRemover = alunos.FirstOrDefault(x => x.Cpf == cpf);

            if (alunoRemover != null)
            {
                alunos.Remove(alunoRemover);
                Console.WriteLine($"O aluno {alunoRemover.Nome} de CPF {alunoRemover.Cpf} foi removido com sucesso ");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }

        public void ListarAlunos()
        {
            if (alunos.Any())
            {
                Console.WriteLine("Alunos do curso de Ciências da computação são: ");
                foreach (Pessoa aluno in alunos)
                {
                    Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Email: {aluno.Email}, CPF: {aluno.Cpf}");
                }
            }
            else
            {
                Console.WriteLine("Ainda não há alunos matriculados neste curso");
            }
        }
    }
}
