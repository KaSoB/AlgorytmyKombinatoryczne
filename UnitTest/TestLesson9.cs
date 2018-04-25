using AlgorytmyKombinatoryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    [TestClass]
    public class TestLesson9 {
        [TestMethod]
        public void Test9Task1_0() {
            // Arrange
            // Act 
            var result = Lesson9.Task1(0, 0);
            var expected = 1;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task1_1() {
            // Arrange
            // Act 
            var result = Lesson9.Task1(9, 9);
            var expected = 1;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task1_2() {
            // Arrange
            // Act 
            var result = Lesson9.Task1(5, 2);
            var expected = 15;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task1_3() {
            // Arrange
            // Act 
            var result = Lesson9.Task1(9, 0);
            var expected = 0;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task1_4() {
            // Arrange
            // Act 
            var result = Lesson9.Task1(9, 3);
            var expected = 3025;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task1_5() {
            // Arrange
            // Act 
            var result = Lesson9.Task1(4, 3);
            var expected = 6;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task1_6() {
            // Arrange
            // Act 
            var result = Lesson9.Task1(9, 7);
            var expected = 462;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task2_0() {
            // Arrange
            // Act 
            var result = Lesson9.Task2(0, 0);
            var expected = 1;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task2_1() {
            // Arrange
            // Act 
            var result = Lesson9.Task2(3, 2);
            var expected = -3;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task2_2() {
            // Arrange
            // Act 
            var result = Lesson9.Task2(6, 3);
            var expected = -225;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task2_3() {
            // Arrange
            // Act 
            var result = Lesson9.Task2(9, 0);
            var expected = 0;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task2_4() {
            // Arrange
            // Act 
            var result = Lesson9.Task2(0, 9);
            var expected = 0;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task2_5() {
            // Arrange
            // Act 
            var result = Lesson9.Task2(9, 3);
            var expected = 118124;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task2_6() {
            // Arrange
            // Act 
            var result = Lesson9.Task2(8, 6);
            var expected = 322;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task3_0() {
            // Arrange
            // Act 
            var result = Lesson9.Task3(0);
            var expected = 1;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task3_1() {
            // Arrange
            // Act 
            var result = Lesson9.Task3(1);
            var expected = 1;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task3_2() {
            // Arrange
            // Act 
            var result = Lesson9.Task3(2);
            var expected = 2;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task3_3() {
            // Arrange
            // Act 
            var result = Lesson9.Task3(3);
            var expected = 5;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task3_4() {
            // Arrange
            // Act 
            var result = Lesson9.Task3(4);
            var expected = 15;
            // Assert 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test9Task3_5() {
            // Arrange
            // Act 
            var result = Lesson9.Task3(5);
            var expected = 52;
            // Assert 
            Assert.AreEqual(expected, result);
        }
    }
}
