

using System.ComponentModel.DataAnnotations;

namespace Parenteses
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileGabarito = @"C:\Users\rober\OneDrive\Desktop\estudosC#\Parenteses\Parenteses\Gabarito.txt";
            const string fileAtvAluno = @"C:\Users\rober\OneDrive\Desktop\estudosC#\Parenteses\Parenteses\AtvAluno.txt";
            const string fileCorrecao = @"C:\Users\rober\OneDrive\Desktop\estudosC#\Parenteses\Parenteses\Correcao.txt";
            List<SentencaGaba> gabarito = new List<SentencaGaba>();
            List<SentencaAluno> listaAluno = new List<SentencaAluno>();
            List<SentencaAluno> sentencasCorrigidasCorretamente = new List<SentencaAluno>();
            List<SentencaAluno> sentencasNaoEncontradas = new List<SentencaAluno>();
            StreamWriter file = File.CreateText(fileCorrecao);
            string[] gabaritoArr = File.ReadAllLines(fileGabarito);
            string[] atvAlunoArr = File.ReadAllLines(fileAtvAluno);

            for (int i = 0; i < gabaritoArr.Length; i++) {
                gabarito.Add(new SentencaGaba(i + 1, gabaritoArr[i]));
            }

            for (int i = 0; i < atvAlunoArr.Length; i++)
            {
                listaAluno.Add(new SentencaAluno(i + 1, atvAlunoArr[i]));
            }

            foreach (SentencaGaba sentencaGaba in gabarito)
            {
                foreach (SentencaAluno sentencaAluno in listaAluno)
                {
                    if (sentencaGaba.Conteudo.Trim().Equals(sentencaAluno.Conteudo.Trim()))
                    {
                        sentencaGaba.QuantMatches += 1;
                        sentencaGaba.SentencaDoAluno.Add(sentencaAluno);
                        sentencaAluno.QuantMatches += 1;
                        sentencaAluno.SentencaDoGabarito = sentencaGaba;    
                           
                    } 
                }
               
            } 

            foreach(SentencaGaba sentencaGaba in gabarito)
            {
                Console.WriteLine(sentencaGaba.ToString());
                file.WriteLine(sentencaGaba.ToString());
            }

            file.Close();

            

            Console.WriteLine();
            Console.WriteLine("-----------------------------");

            foreach (SentencaAluno sentencaAluno in listaAluno)
            {
                if(sentencaAluno.QuantMatches > 0)
                {
                    sentencasCorrigidasCorretamente.Add(sentencaAluno);
                } else
                {
                    sentencasNaoEncontradas.Add(sentencaAluno);
                }
               
            }

            foreach (SentencaAluno item in sentencasNaoEncontradas)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}