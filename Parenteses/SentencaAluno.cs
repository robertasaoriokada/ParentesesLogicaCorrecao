using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parenteses
{
    class SentencaAluno
    {
        public int Id { get; set; }
        public string Conteudo { get; set; }
        public int QuantMatches { get; set; }
        public SentencaGaba SentencaDoGabarito { get; set; }
        public SentencaAluno(int id, string conteudo)
        {
            Id = id;
            Conteudo = conteudo;
        }

        public override string ToString()
        {
            return $"{Id}) {Conteudo}, Matches com o gabarito: {QuantMatches}, Sentença associada: {(SentencaDoGabarito != null ? SentencaDoGabarito.Id + " " + SentencaDoGabarito.Conteudo : "Nenhum")}";
        }
    }
}
