using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public class MultipleChoiceQuestion : Question
    {
        public string CorrectAnswer { get; set; }
        public string UserResponse { get; set; }

        public MultipleChoiceQuestion(string correctAnswer, string prompt, List<string> options)
            : base(prompt, options)
        {
            CorrectAnswer = correctAnswer;
            UserResponse = "";
        }

        public override bool GradeQuestion()
        {
            //get user response
            Console.WriteLine("Enter Your answer");
            UserResponse = Console.ReadLine();
            //check user response against correct answer
            
            
            return UserResponse.Equals(CorrectAnswer);
            
            
            
        }
    }
}   