using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public class TrueFalseQuestion : Question
    {
        public string CorrectAnswer { get; set; }
        public string UserResponse { get; set; }

        // Create overloaded constructor for this subclass of Question
        /*
         * Needs to accept (prompt, correctAnswer)
         * Pass a new List object of { "True", "False" } to the Options param
         */
        public TrueFalseQuestion(string prompt, string correctAnswer)
            : base(prompt, new List<string>() { "True", "False" })
        {
            this.CorrectAnswer = correctAnswer;
            this.UserResponse = "";
        }

        // Implement GradeQuestion method

        public override bool GradeQuestion()
        {
            Console.WriteLine("Enter your answer");
            UserResponse = Console.ReadLine();

            return UserResponse.Equals(CorrectAnswer);

        }
    }
}