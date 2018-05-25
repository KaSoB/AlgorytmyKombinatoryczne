using AlgorytmyKombinatoryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest {
    [TestClass]
    public class TestLesson11 {
        [TestMethod]
        public void Test11Task1_0() {
            // Arrange
            // Act 
            var result = Lesson11.Task1(7, 4);
            var expected = 3;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test11Task1_1() {
            // Arrange
            // Act 
            var result = Lesson11.Task1(6, 1);
            var expected = 1;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test11Task1_2() {
            // Arrange
            // Act 
            var result = Lesson11.Task1(6, 2);
            var expected = 3;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test11Task1_3() {
            // Arrange
            // Act 
            var result = Lesson11.Task1(6, 3);
            var expected = 3;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test11Task1_4() {
            // Arrange
            // Act 
            var result = Lesson11.Task1(6, 4);
            var expected = 2;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test11Task1_5() {
            // Arrange
            // Act 
            var result = Lesson11.Task1(3, 2);
            var expected = 1;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test11Task1_6() {
            // Arrange
            // Act 
            var result = Lesson11.Task1(2, 1);
            var expected = 1;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test11Task2_0() {
            // Arrange
            // Act 
            var result = Lesson11.Task2(new List<int>() { 4, 2, 1 }, 7);
            var expected = new List<int>() { 3, 2, 1, 1 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
