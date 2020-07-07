using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public interface IGradable
    {
        //Returns true if answer is correct els will return false
        bool Grade(List<string> userResponse);
    }
}
