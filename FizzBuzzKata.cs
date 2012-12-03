using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzKata : IFizzBuzzKata
    {
        public string Answer(int theNumberInQuestion)
        {
            var fizzBuzzAnswer = new StringBuilder();

            fizzBuzzAnswer.Append(areYouAFizz(theNumberInQuestion));
            fizzBuzzAnswer.Append(areYouABuzz(theNumberInQuestion));

            if(fizzBuzzAnswer.Length == 0)
            {
                fizzBuzzAnswer.Append("NEITHER");
            }

            return fizzBuzzAnswer.ToString();
        }

        private string areYouAFizz(int theNumberInQuestion)
        {
            string stringToReturn = "";

            if(theNumberInQuestion % 3 == 0)
            {
                stringToReturn = "FIZZ";
            }

            return stringToReturn;
        }

        private string areYouABuzz(int theNumberInQuestion)
        {
            string stringToReturn = "";

            if (theNumberInQuestion % 5 == 0)
            {
                stringToReturn = "BUZZ";
            }

            return stringToReturn;
        }

    }
}