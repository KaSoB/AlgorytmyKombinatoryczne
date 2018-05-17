using System;
using System.Collections.Generic;
using AlgorytmyKombinatoryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    [TestClass]
    public class TestLesson07 {
        [TestMethod]
        public void Test7Task1_0() {
            // Arrange
            // Act 
            var result = Lesson07.Task1(new List<int>() { 3, 6, 2, 7, 5, 4, 1 }, 7);
            var expected = new List<int>() { 3, 6, 4, 1, 2, 5, 7 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test7Task1_2() {
            // Arrange
            // Act 
            var result = Lesson07.Task1(new List<int>() { 1, 2, 3, 4, 5, 6 }, 6);
            var expected = new List<int>() { 1, 2, 3, 4, 6, 5 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test7Task1_3() {
            // Arrange
            // Act 
            var result = Lesson07.Task1(new List<int>() { 3, 6, 2, 1, 5, 4 }, 6);
            var expected = new List<int>() { 3, 6, 2, 4, 1, 5 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test7Task2_0() {
            // Arrange
            // Act 
            var result = Lesson07.Task2(new List<int>() { 2, 4, 1, 3 }, 4);
            var expected = 10;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test7Task2_1() {
            // Arrange
            // Act 
            var result = Lesson07.Task2(new List<int>() { 1, 2, 3, 4, 5, 6 }, 6);
            var expected = 0;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test7Task2_2() {
            // Arrange
            // Act 
            var result = Lesson07.Task2(new List<int>() { 6, 5, 4, 3, 2, 1 }, 6);
            var expected = 719;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test7Task3_0() {
            // Arrange
            // Act 
            var result = Lesson07.Task3(6, 0);
            var expected = new List<int>() { 1, 2, 3, 4, 5, 6 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test7Task3_1() {
            // Arrange
            // Act 
            var result = Lesson07.Task3(6, 719);
            var expected = new List<int>() { 6, 5, 4, 3, 2, 1 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }

    }
}