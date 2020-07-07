using System;
using System.Collections.Generic;

namespace QuizGrader
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz newQuiz = new Quiz();

            Question q1 = new MultipleChoiceQuestion("Australia", "What's the biggest island?", new List<string>() { "Australia","Madascar","NewZealand","Guam"});

            newQuiz.AddQuestion(q1);
            Question q2 = new TrueFalseQuestion("1 is an even number", "false");
            newQuiz.AddQuestion(q2);



            newQuiz.Administer();
        }
    }
}