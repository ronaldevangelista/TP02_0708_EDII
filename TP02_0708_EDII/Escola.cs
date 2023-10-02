using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02_0708_EDII
{
    public class Escola
    {
        Curso[] cursos = new Curso[5];

        int idCursos = 1;

        public Curso[] Cursos { get => cursos; set => cursos = value; }

        public bool adicionarCurso(Curso curso)
        {
            int i = -1;
            do
            {
                i++;
            } while ((Cursos[i].Descricao != "" && Cursos[i].Descricao != curso.Descricao) && i < 5) ;

            if (Cursos[i].Descricao != "" && Cursos[i].Descricao != curso.Descricao)
            {
                return false;
            } else
            {
                curso.Id = idCursos;
                idCursos++;
                Cursos[i] = curso;
                return true;
            }
        }
        public Curso pesquisarCurso(Curso curso)
        {
            int i = -1;
            do
            {
                i++;
            } while (Cursos[i].Descricao != curso.Descricao && i < 5);

            if (Cursos[i].Descricao != curso.Descricao)
            {
                curso = Cursos[i];
            } else
            {
                curso.Descricao = null;
            }
            return curso;
        }
        public bool removerCurso(Curso curso)
        {
            int i = -1;
            do
            {
                i++;
            } while (Cursos[i].Descricao != curso.Descricao && i < 5);

            if (Cursos[i].Descricao != curso.Descricao)
            {
                return false;
            } else if (Cursos[i].Disciplina[0].Descricao == "")
            {
                return false;
            } else {
                Cursos[i].Descricao = "";
                Cursos[i].Id = 0;
                foreach (Disciplina d in Cursos[i].Disciplina)
                {
                    d.Descricao = "";
                    d.Id = 0;
                }
                return true; 
            }
        }
    }
}
