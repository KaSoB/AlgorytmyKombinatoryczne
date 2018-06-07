using AlgorytmyKombinatoryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest {
    [TestClass]
    public class TestLesson12 {
        [TestMethod]
        public void Test12Task3_0() {
            // Arrange
            // Act 
            var result = Lesson12.Task3(new List<int>() { 1, 2, 4 }, 5);
            var expected = 39;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test12Task3_1() {
            // Arrange
            // Act 
            var result = Lesson12.Task3(new List<int>() { 1, 5, 1, 5, 4 }, 7);
            var expected = 4204;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test12Task4_0() {
            // Arrange
            // Act 
            var result = Lesson12.Task4(39, 5);
            var expected = new int[] { 1, 2, 4 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test12Task4_1() {
            // Arrange
            // Act 
            var result = Lesson12.Task4(4204, 7);
            var expected = new int[] { 1, 5, 1, 5, 4 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
