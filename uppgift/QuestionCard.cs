using System;

namespace uppgift
{
    class QuestionCard
    {
        private String question;
        private String answer;
        public QuestionCard(string q, string ans)
      {
          question = q;
          answer = ans;
      }

      public string GetQuestion()
      {
          return question;
      }

      public bool IsCorrect(string guess)
      {
          return answer == guess;
      }
    }
}