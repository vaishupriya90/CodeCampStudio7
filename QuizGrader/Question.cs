using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public abstract class Question
    {
        // Which countries in Oceania are big? (CheckBox)
        // Which country has the outback? (MultipleChoiceQuestion)
        // NZ
        // Samoa
        // Guam
        // Australia

        public string Prompt { get; set; }
        public List<string> Options { get; set; }

        // NZ stands for New Zoo (T/F)
        public Question(string prompt, List<string> options)
        {
            Prompt = prompt;
            Options = options;
        }

        public abstract bool GradeQuestion(List<string> userResponse);
    }
}
