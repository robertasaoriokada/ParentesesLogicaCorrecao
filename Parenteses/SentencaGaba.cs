using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parenteses
{
    class SentencaGaba
    {
        public int Id { get; set; }
        public string Conteudo { get; set; }
        public int QuantMatches { get; set; }
        public List<SentencaAluno> SentencaDoAluno { get; set; }   
        public SentencaGaba(int id,  string conteudo) {
            Id = id;
            Conteudo = conteudo;
            SentencaDoAluno = new List<SentencaAluno>();
        }

        public string ListarSentencasMatches()
        {
            if(SentencaDoAluno.Count == 0)
            {
                return "Nenhum";
            }
            StringBuilder sb = new StringBuilder();
            foreach(SentencaAluno sentencaAluno in SentencaDoAluno)
            {
                sb.Append($"[{sentencaAluno.Id}) {sentencaAluno.Conteudo}] ");
        
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return $"{Id}) {Conteudo}, Matches com o aluno: {QuantMatches}, Sentença associada: {ListarSentencasMatches()}";
        }

    }
}
