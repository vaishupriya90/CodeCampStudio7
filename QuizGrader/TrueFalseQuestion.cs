using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public class TrueFalseQuestion : Question
    {
        public string CorrectAnswer { get; set; }

        // Create overloaded constructor for this subclass of Question
        /*
         * Needs to accept (prompt, correctAnswer)
         * Pass a new List object of { "True", "False" } to the Options param
         */
        public TrueFalseQuestion(string prompt, string correctAnswer)
            : base(prompt, new List<string>() { "True", "False" })
        {
            CorrectAnswer = correctAnswer;
        }

        // Implement GradeQuestion method
    }
}
