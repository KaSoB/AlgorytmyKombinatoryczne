using System;
using System.Collections.Generic;
using AlgorytmyKombinatoryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    [TestClass]
    public class TestLesson06 {
        [TestMethod]
        public void Test6Task2_0() {
            // Arrange
            // Act 
            var result = Lesson06.Task2(new List<int>() { 1, 2, 5 }, 5, 3);
            var expected = 9;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test6Task2_1() {
            // Arrange
            // Act 
            var result = Lesson06.Task2(new List<int>() { 1, 2, 3 }, 5, 3);
            var expected = 0;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test6Task2_2() {
            // Arrange
            // Act 
            var result = Lesson06.Task2(new List<int>() { 3, 4, 5 }, 5, 3);
            var expected = 6;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test6Task2_3() {
            // Arrange
            // Act 
            var result = Lesson06.Task2(new List<int>() { 1, 2, 3, 4 }, 5, 4);
            var expected = 0;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test6Task2_4() {
            // Arrange
            // Act 
            var result = Lesson06.Task2(new List<int>() { 1, 2, 3, 5 }, 5, 4);
            var expected = 4;
            // Assert 
            Assert.AreEqual(expected, result);
        }



        [TestMethod]
        public void Test6Task3_0() {
            // Arrange
            int n = 5;
            int k = 3;
            int r = 2;
            // Act 
            var result = Lesson05.Task3(n, k, r);
            var expected = Lesson05.Task2(result, n, k);
            // Assert 
            Assert.AreEqual(expected, r);
        }
        [TestMethod]
        public void Test6Task3_1() {
            // Arrange
            int n = 5;
            int k = 3;
            int r = 6;
            // Act 
            var result = Lesson05.Task3(n, k, r);
            var expected = Lesson05.Task2(result, n, k);
            // Assert 
            Assert.AreEqual(expected, r);
        }
        [TestMethod]
        public void Test6Task3_2() {
            // Arrange
            int n = 5;
            int k = 4;
            int r = 4;
            // Act 
            var result = Lesson05.Task3(n, k, r);
            var expected = Lesson05.Task2(result, n, k);
            // Assert 
            Assert.AreEqual(expected, r);
        }
        [TestMethod]
        public void Test6Task3_3() {
            // Arrange
            int n = 5;
            int k = 4;
            int r = 0;
            // Act 
            var result = Lesson05.Task3(n, k, r);
            var expected = Lesson05.Task2(result, n, k);
            // Assert 
            Assert.AreEqual(expected, r);
        }
    }
}
