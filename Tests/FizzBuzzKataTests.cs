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
            answersList.Add(fizzBuzzKata.Answer(3));
            answersList.Add(fizzBuzzKata.Answer(93));
            answersList.Add(fizzBuzzKata.Answer(999));
            answersList.Add(fizzBuzzKata.Answer(18));

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
            answersList.Add(fizzBuzzKata.Answer(5));
            answersList.Add(fizzBuzzKata.Answer(100));
            answersList.Add(fizzBuzzKata.Answer(1135));
            answersList.Add(fizzBuzzKata.Answer(5555));

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
            answersList.Add(fizzBuzzKata.Answer(15));
            answersList.Add(fizzBuzzKata.Answer(30));
            answersList.Add(fizzBuzzKata.Answer(1500));
            answersList.Add(fizzBuzzKata.Answer(5550));

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
            answersList.Add(fizzBuzzKata.Answer(4));
            answersList.Add(fizzBuzzKata.Answer(88));
            answersList.Add(fizzBuzzKata.Answer(1357));
            answersList.Add(fizzBuzzKata.Answer(125537));

            //Assert
            foreach (var answer in answersList)
            {

                Assert.That(answer.Equals("NEITHER"));

            }
         }
    }
}
