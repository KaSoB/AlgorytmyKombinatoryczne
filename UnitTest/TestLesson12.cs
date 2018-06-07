using AlgorytmyKombinatoryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTest {
    [TestClass]
    public class TestLesson12 {

        [TestMethod]
        public void Test12Task1_0() {
            // Arrange
            var input = new List<Tuple<int, int>> {
                new Tuple<int, int>(1, 4),
                new Tuple<int, int>(1, 7),
                new Tuple<int, int>(4, 5),
                new Tuple<int, int>(1, 6),
                new Tuple<int, int>(6, 8),
                new Tuple<int, int>(8, 3),
                new Tuple<int, int>(8, 2)
            };
            // Act 
            var result = Lesson12.Task1(input, 8);

            var expected = new List<int>() { 1, 4, 1, 8, 8, 6 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test12Task2_0() {
            // Arrange
            var output = new List<int>() { 1, 4, 1, 8, 8, 6 };
            // Act 
            var result = Lesson12.Task2(output);

            var expected = new List<Tuple<int, int>> {
                new Tuple<int, int>(1, 4),
                new Tuple<int, int>(1, 7),
                new Tuple<int, int>(4, 5),
                new Tuple<int, int>(1, 6),
                new Tuple<int, int>(6, 8),
                new Tuple<int, int>(8, 3),
                new Tuple<int, int>(8, 2)
            };
            expected.Sort();
            result.Sort();
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }


        [TestMethod]
        public void Test12Task3_0() {
            // Arrange
            // Act 
            var result = Lesson12.Task3(new List<int>() { 2, 3, 5 }, 5);
            var expected = 39;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test12Task3_1() {
            // Arrange
            // Act 
            var result = Lesson12.Task3(new List<int>() { 2, 6, 2, 6, 5 }, 7);
            var expected = 4204;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test12Task4_0() {
            // Arrange
            // Act 
            var result = Lesson12.Task4(39, 5);
            var expected = new int[] { 2, 3, 5 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test12Task4_1() {
            // Arrange
            // Act 
            var result = Lesson12.Task4(4204, 7);
            var expected = new int[] { 2, 6, 2, 6, 5 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
