using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class FizzBuzzKataTests
    {
        [Test]
        public void ReturnsFizzWhenGivenANumberDivisbleBy3()
        {
            //Arrange
            var fizzBuzzKata = new FizzBuzzKata();
            var answersList = new ArrayList();


            //Act
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(3));
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(93));
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(999));
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(18));

            //Assert
            foreach (var answer in answersList)
            {
                
                Assert.That(answer.Equals("FIZZ"));

            }

        }

        [Test]
        public void ReturnsBuzzWhenGivenANumberDivisbleBy5()
        {
            //Arrange
            var fizzBuzzKata = new FizzBuzzKata();
            var answersList = new ArrayList();


            //Act
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(5));
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(100));
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(1135));
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(5555));

            //Assert
            foreach (var answer in answersList)
            {

                Assert.That(answer.Equals("BUZZ"));

            }

        }

        [Test]
        public void ReturnsFizzBuzzWhenGivenANumberDivisbleByBoth3And5()
        {
            //Arrange
            var fizzBuzzKata = new FizzBuzzKata();
            var answersList = new ArrayList();


            //Act
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(15));
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(30));
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(1500));
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(5550));

            //Assert
            foreach (var answer in answersList)
            {

                Assert.That(answer.Equals("FIZZBUZZ"));

            }

        }


        [Test]
        public void ReturnsNeitherWhenitsNotDivisbleBy3Or5()
        {

            //Arrange
            var fizzBuzzKata = new FizzBuzzKata();
            var answersList = new ArrayList();


            //Act
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(4));
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(88));
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(1357));
            answersList.Add(fizzBuzzKata.AreYouAFizzBuzzOrNot(125537));

            //Assert
            foreach (var answer in answersList)
            {

                Assert.That(answer.Equals("NEITHER"));

            }
         }
    }
}
