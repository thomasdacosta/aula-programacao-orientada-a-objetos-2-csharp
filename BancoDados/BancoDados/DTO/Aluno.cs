using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados
{
    public class Aluno
    {
        private string nome;
        private string ra;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string RA
        {
            get { return ra; }
            set { ra = value; }
        }

        public override bool Equals(object obj)
        {
            var aluno = obj as Aluno;
            return aluno != null &&
                   this.ra == aluno.ra;
        }

        public override int GetHashCode()
        {
            var hashCode = -239606544;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ra);
            return hashCode;
        }
    }
}
