using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public class MultipleChoiceQuestion : Question
    {
        public string CorrectAnswer { get; set; }

        public MultipleChoiceQuestion(string correctAnswer, string prompt, List<string> options)
            : base(prompt, options)
        {
            CorrectAnswer = correctAnswer;
        }

        public override bool GradeQuestion(List<string> userResponse)
        {
            foreach (string response in userResponse)
            {
                if (response.Equals(CorrectAnswer))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
