using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyKombinatoryczne {
    public class Lesson9 {
        /// <summary>
        /// Napisz program obliczający za pomocą programowania dynamicznego wartości liczb Stirlinga
        /// drugiego rodzaju ze wzoru: S(n, k) = kS(n − 1, k) + S(n − 1, k − 1)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int Task1(int n, int k) {
            return 1;
        }
        /// <summary>
        /// Napisz program obliczający za pomocą programowania dynamicznego wartości liczb Stirlinga
        /// pierwszego rodzaju ze wzoru: s(n, k) = s(n − 1, k − 1) − (n − 1)s(n − 1, k),
        /// </summary>
        /// <returns></returns>
        public static int Task2(int n, int k) {
            return 1;
        }
        /// <summary>
        /// Napisz program obliczający za pomocą programowania dynamicznego wartości liczb Bella
        /// ze wzoru: B(n) = for k=0 to n-1 do (n − 1)!/(k!(n-1-k!)*B(k)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Task3(int n) {
            return 1;
        }
    }
}
