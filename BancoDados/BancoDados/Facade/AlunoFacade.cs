using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados
{
    public class AlunoFacade
    {
        private AlunoDAO alunoDAO;

        public AlunoFacade()
        {
            alunoDAO = new AlunoDAO();
        }

        public void IncluirAluno(string nome, string ra)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = String.IsNullOrEmpty(nome) ? null : nome;
            aluno.RA = String.IsNullOrEmpty(ra) ? null : ra;
            alunoDAO.IncluirAluno(aluno);
        }
    }
}
