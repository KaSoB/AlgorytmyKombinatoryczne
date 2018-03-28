using System;
using System.Collections.Generic;
using AlgorytmyKombinatoryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    [TestClass]
    public class TestCwiczenie6 {
        [TestMethod]
        public void Test6Task1_0() {
            // Arrange
            // Act 
            var result = Cwiczenie5.Task1(
                new List<int>() { 7, 6, 4, 3, 2 }, 7, 5);
            var expected = new List<int>() { 7, 6, 5, 2, 1 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test6Task1_1() {
            // Arrange
            // Act 
            var result = Cwiczenie5.Task1(new List<int>() { 7, 6, 5, 4, 3 }, 7, 5);

            // Assert 
            Assert.IsNull(result);
        }
        [TestMethod]
        public void Test6Task1_2() {
            // Arrange
            // Act 
            var result = Cwiczenie5.Task1(new List<int>() { 5, 4, 3, 2, 1 }, 7, 5);
            var expected = new List<int>() { 6, 4, 3, 2, 1 };
            // Assert 
            CollectionAssert.AreEqual(expected, result);
        }


        [TestMethod]
        public void Test6Task2_0() {
            // Arrange
            // Act 
            var result = Cwiczenie6.Task2(new List<int>() { 1, 2, 5 }, 5, 3);
            var expected = 9;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test6Task2_1() {
            // Arrange
            // Act 
            var result = Cwiczenie6.Task2(new List<int>() { 1, 2, 3 }, 5, 3);
            var expected = 0;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test6Task2_2() {
            // Arrange
            // Act 
            var result = Cwiczenie6.Task2(new List<int>() { 3, 4, 5 }, 5, 3);
            var expected = 6;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test6Task2_3() {
            // Arrange
            // Act 
            var result = Cwiczenie6.Task2(new List<int>() { 1, 2, 3, 4 }, 5, 4);
            var expected = 0;
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test6Task2_4() {
            // Arrange
            // Act 
            var result = Cwiczenie6.Task2(new List<int>() { 1, 2, 3, 5 }, 5, 4);
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
            var result = Cwiczenie5.Task3(n, k, r);
            var expected = Cwiczenie5.Task2(result, n, k);
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
            var result = Cwiczenie5.Task3(n, k, r);
            var expected = Cwiczenie5.Task2(result, n, k);
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
            var result = Cwiczenie5.Task3(n, k, r);
            var expected = Cwiczenie5.Task2(result, n, k);
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
            var result = Cwiczenie5.Task3(n, k, r);
            var expected = Cwiczenie5.Task2(result, n, k);
            // Assert 
            Assert.AreEqual(expected, r);
        }
    }
}
