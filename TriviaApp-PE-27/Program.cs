using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Web;

namespace TriviaApp_PE_27
{
    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }
    class Trivia
    {
        public int response_code;
        public List<TriviaResult>results;

    }
    class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;
            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            start:
                url = "https://opentdb.com/api.php?amount=1&type=multiple";
                request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
                reader = new StreamReader(response.GetResponseStream());
                s = reader.ReadToEnd();
                reader.Close();

                Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

                trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
                trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);

                for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
                {
                    trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
                }

                Console.WriteLine(trivia.results[0].question);
                Console.WriteLine("");
                Random rand = new Random();
                List<string> answerList = new List<string> { trivia.results[0].correct_answer, trivia.results[0].incorrect_answers[0], trivia.results[0].incorrect_answers[1], trivia.results[0].incorrect_answers[2] };
        
            

                for(int i=3; i>=0; i--)
                {
                    int randAnswerIndex = rand.Next(0, i);
                    Console.WriteLine($"{4 - i}. {answerList[randAnswerIndex]}");
                    answerList.RemoveAt(randAnswerIndex);
                }
                string userAnswer = Console.ReadLine();
                if(userAnswer.ToLower().Equals(trivia.results[0].correct_answer.ToLower()))
                {
                    Console.WriteLine("congrats! you got it right.");
                }
                else
                {
                    Console.WriteLine("sorry, the answer was " + trivia.results[0].correct_answer);
                }
            Console.WriteLine("\n would you like to play again? y/n");
            if(Console.ReadLine().Contains("y"))
            {
                goto start;
            }
            else
            {
                return;
            }
        }
    }
}
