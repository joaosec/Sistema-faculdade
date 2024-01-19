using Faculdade.Models; 

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Seja bem-vindo ao sistema da faculdade!");

bool exibirMenu = true;
Alunos alunos = new Alunos(); 

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a opção desejada:");
    Console.WriteLine("1 - Cadastrar Aluno");
    Console.WriteLine("2 - Remover Aluno");
    Console.WriteLine("3 - Listar Alunos");
    Console.WriteLine("4 - Encerrar o sistema");

    switch (Console.ReadLine())
    {
        case "1":
            alunos.AdicionarAluno();
            break;

        case "2":
            alunos.RemoverAluno();
            break;

        case "3":
            alunos.ListarAlunos(); 
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
