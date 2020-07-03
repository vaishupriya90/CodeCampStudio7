using System;

namespace QuizGrader
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz newQuiz = new Quiz();

            Question q1 = new MultipleChoiceQuestion("Australia", "What's the biggest island?", new List<string>());

            newQuiz.AddQuestion(q1);



            newQuiz.Administer();
        }
    }
}
