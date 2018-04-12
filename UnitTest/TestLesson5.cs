using System;
using System.Collections.Generic;
using AlgorytmyKombinatoryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    [TestClass]
    public class TestLesson5 {
        [TestMethod]
        public void Test5Task1_0() {
            // Arrange
            // Act 
            var result = Lesson5.Task1(new List<int>() { 7, 6, 4, 3, 2 }, 7, 5);
            var expected = new List<int>() { 7, 6, 5, 2, 1 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test5Task1_1() {
            // Arrange
            // Act 
            var result = Lesson5.Task1(new System.Collections.Generic.List<int>() { 7, 6, 5, 4, 3 }, 7, 5);

            // Assert 
            Assert.IsNull(result);
        }
        [TestMethod]
        public void Test5Task1_2() {
            // Arrange
            // Act 
            var result = Lesson5.Task1(new System.Collections.Generic.List<int>() { 5, 4, 3, 2, 1 }, 7, 5);
            var expected = new List<int>() { 6, 4, 3, 2, 1 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }


        [TestMethod]
        public void Test5Task2_0() {
            // Arrange
            // Act 
            var result = Lesson5.Task2(new System.Collections.Generic.List<int>() { 4, 2, 1 }, 5, 3);
            var expected = 1;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test5Task2_1() {
            // Arrange
            // Act 
            var result = Lesson5.Task2(new System.Collections.Generic.List<int>() { 5, 4, 1 }, 5, 3);
            var expected = 7;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test5Task2_2() {
            // Arrange
            // Act 
            var result = Lesson5.Task2(new System.Collections.Generic.List<int>() { 5, 4, 3 }, 5, 3);
            var expected = 9;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test5Task2_3() {
            // Arrange
            // Act 
            var result = Lesson5.Task2(new System.Collections.Generic.List<int>() { 5, 3, 2 }, 5, 3);
            var expected = 6;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test5Task2_4() {
            // Arrange
            // Act 
            var result = Lesson5.Task2(new System.Collections.Generic.List<int>() { 5, 4, 3, 2, 1 }, 7, 5);
            var expected = 0;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test5Task2_5() {
            // Arrange
            // Act 
            var result = Lesson5.Task2(new System.Collections.Generic.List<int>() { 8, 6, 4, 2 }, 8, 4);
            var expected = 49;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test5Task2_6() {
            // Arrange
            // Act 
            var result = Lesson5.Task2(new System.Collections.Generic.List<int>() { 6, 5, 4, 3, 1 }, 7, 5);
            var expected = 4;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test5Task3_0() {
            // Arrange
            // Act 
            var result = Lesson5.Task3(5, 3, 2);
            var expected = new List<int>() { 4, 3, 1 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test5Task3_1() {
            // Arrange
            // Act 
            var result = Lesson5.Task3(6, 4, 8);
            var expected = new List<int>() { 6, 4, 3, 2 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
