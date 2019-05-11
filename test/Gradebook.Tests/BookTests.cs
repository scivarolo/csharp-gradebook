using System;
using Xunit;

namespace Gradebook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Average);
        }

        [Fact]
        public void AddOnlyValidGrades()
        {
            var book = new Book("");
            book.AddGrade(101);
            book.AddGrade(-1);
            book.AddGrade(50);

            var result = book.GetStatistics();
            Assert.Equal(50, result.Average, 1);
            Assert.Equal(50, result.High, 1);
            Assert.Equal(50, result.Low, 1);
            Assert.Equal('F', result.Letter);
        }
    }
}
