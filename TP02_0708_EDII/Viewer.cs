using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02_0708_EDII
{
    internal class Viewer
    {
        static void Main(string[] args)
        {
            Escola escola = new Escola();
            bool key = true;
            while (key)
            {
                Console.WriteLine("Menu de Opções\n--- * ---\n");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar curso");
                Console.WriteLine("2. Pesquisar curso");
                Console.WriteLine("3. Remover curso");
                Console.WriteLine("4. Adicionar disciplina no curso");
                Console.WriteLine("5. Pesquisar disciplina");
                Console.WriteLine("6. Remover disciplina");
                Console.WriteLine("7. Matricular aluno na disciplina");
                Console.WriteLine("8. Remover aluno da disciplina");
                Console.WriteLine("9. Pesquisar aluno");

                int opt = Int16.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 0: key = false; break;
                    case 1:
                        Console.Write("Insira o nome do curso: ");
                        string nomeNovoCurso = Console.ReadLine();
                        Curso newCurso = new Curso(nomeNovoCurso);
                        if (escola.adicionarCurso(newCurso))
                        {
                            Console.WriteLine("Curso adicionado com sucesso");
                        }
                        else {
                            Console.WriteLine("Erro ao adicionar o curso");
                        };
                        break;
                    case 2:
                        Console.Write("Insira o nome do curso: ");
                        string nomePesquisarCurso = Console.ReadLine();
                        Curso cursoPesquisar = new Curso(nomePesquisarCurso);
                        cursoPesquisar = escola.pesquisarCurso(cursoPesquisar);
                        if (cursoPesquisar.Descricao == null)
                        {
                            Console.WriteLine("O curso não foi encontrado");
                        } else
                        {
                            Console.WriteLine("Curso encontrado!");
                            Console.WriteLine("ID curso: " + cursoPesquisar.Id);
                            Console.WriteLine("Descrição do Curso: " + cursoPesquisar.Descricao);
                            Console.WriteLine("Disciplinas:\n ---- ** ----");
                            foreach (var item in cursoPesquisar.Disciplina)
                            {
                                Console.WriteLine("\nID: " + item.Id);
                                Console.WriteLine("Descrição: " + item.Descricao);
                                Console.WriteLine("---- ** ----");
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Insira o nome do curso: ");
                        string nomeExcluirCurso = Console.ReadLine();
                        Curso cursoExcluir = new Curso(nomeExcluirCurso);
                        if (escola.removerCurso(cursoExcluir))
                        {
                            Console.WriteLine("Curso foi removido com sucesso");
                        }
                        else { 
                            Console.WriteLine("O curso não foi removido");
                        };
                        break;
                    case 4:
                        Console.Write("Insira o nome da disciplina: ");
                        string nomeNovaDisciplina = Console.ReadLine();
                        // PESQUISAR CURSO DESEJADO, ADICIONAR DISCIPLINA NELE E REALIZAR UPDATE
                        Curso newDisciplina = new Disciplina(nomeNovaDisciplina);
                        if (escola.adicionarCurso(newCurso))
                        {
                            Console.WriteLine("Curso adicionado com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao adicionar o curso");
                        };
                        break;
                }
            }
        }
    }
}
