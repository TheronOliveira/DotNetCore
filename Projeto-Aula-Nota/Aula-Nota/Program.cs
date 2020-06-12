using System;

namespace Aluno_Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indAluno = 0;

            string opcao = opcaoEscolhida();
            
            while (opcao != "4")
            {
                switch(opcao)
                {
                    case "1":

                        Aluno aluno = new Aluno();

                        Console.WriteLine("Informe seu nome");
                        aluno.nome = Console.ReadLine();

                        Console.WriteLine("Informe sua nota");
                        aluno.nota = decimal.Parse(Console.ReadLine());

                        alunos[indAluno] = aluno;
                        indAluno++;

                        break;
                    case "2":
                            foreach(var a in alunos)
                            {
                                if(a != null)
                                {
                                    Console.WriteLine($"\nSeu nome é: {a.nome} e sua nota é: {a.nota}");
                                } 
                            }
                       
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;

                }
                opcao = opcaoEscolhida();
            }
          
        }

        private static string opcaoEscolhida()
        {
            string opcao = "";

            Console.WriteLine("\n------Projeto Média Aluno, escolha uma das opções abaixo-----\n");
            Console.WriteLine("1 - Cadastrar aluno e nota");
            Console.WriteLine("2 - Listar aluno");
            Console.WriteLine("3 - Média total dos alunos");
            Console.WriteLine("4 - Sair\n");

            opcao = Console.ReadLine();
            return opcao;
        }
    }

    public class Aluno{
        public string nome { get; set; }

        public decimal? nota { get; set; }

    }


}
