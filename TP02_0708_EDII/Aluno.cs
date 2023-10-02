using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02_0708_EDII
{
    public class Aluno
    {
        private int id = 0;
        private string nome = "";

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }

        public Aluno(string nome, int id) {
            Nome = nome;
            Id = id;
        }

        public Aluno() { }

        public bool podeMatricular(Curso cursos)
        {
            return false;
        }
    }
}
