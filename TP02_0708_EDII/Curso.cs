namespace TP02_0708_EDII
{
    public class Curso
    {
        private int id = 0;
        private string descricao = "";
        private Disciplina[] disciplina = new Disciplina[12];
        private int idDisciplinas = 0;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Disciplina[] Disciplina { get => disciplina; set => disciplina = value; }

        public Curso() { }

        public Curso(string descricao)
        {
            this.descricao = descricao;
            for (int i = 0; i < 11; i++)
            {
                this.disciplina[i] = new Disciplina();
            }
        }

        public bool adicionarDisciplina(Disciplina disciplina)
        {
            int i = -1;
            do
            {
                i++;
            } while ((Disciplina[i].Descricao != "" && Disciplina[i].Descricao != disciplina.Descricao) && i < 5);

            if (Disciplina[i].Descricao != "" && Disciplina[i].Descricao != disciplina.Descricao)
            {
                return false;
            } else
            {
                disciplina.Id = ++idDisciplinas;
                Disciplina[i] = disciplina;
                return true;
            }
        }

        public Disciplina pesquisarDisciplina(Disciplina disciplina)
        {
            return disciplina;
        }
        public bool removerDisciplina(Disciplina disciplina)
        {
            return false;
        }
    }
}