using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02_0708_EDII
{
    public class Disciplina
    {
        private int id = 0;
        private string descricao = "";
        private Aluno[] alunos = new Aluno[15];

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        private Aluno[] Alunos { get => alunos; set => alunos = value; }

        public Disciplina() {
            for (int i = 0; i < alunos.Length - 1; i++)
            {
                alunos[i] = new Aluno();
            }
        }
        public Disciplina(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;

            for(int i = 0; i < alunos.Length - 1; i++)
            {
                alunos[i] = new Aluno();
            }
        }

        public bool matricularAluno(Aluno aluno)
        {
            int i = -1;
            do
            {
                i++;
            } while (i < 14 && (alunos[i].Nome != "" && alunos[i].Nome != aluno.Nome));

            if (alunos[i].Nome != "")
            {
                return false;
            } else
            {
                alunos[i] = aluno; 
                return true;
            }
        }

        public bool desmatricularAluno(Aluno aluno)
        {
            int i = -1;
            do
            {
                i++;
            } while (i < 14 && alunos[i].Nome != aluno.Nome);

            if (alunos[i].Nome != aluno.Nome)
            {
                return false;
            }
            else
            {
                alunos[i].Nome = "";
                alunos[i].Id = 0;
                return true;
            }
        }
    }
}
