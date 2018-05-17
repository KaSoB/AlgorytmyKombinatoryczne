namespace AlgorytmyKombinatoryczne {
    public class Lesson09 {
        /// <summary>
        /// Napisz program obliczający za pomocą programowania dynamicznego wartości liczb Stirlinga
        /// drugiego rodzaju ze wzoru: S(n, k) = kS(n − 1, k) + S(n − 1, k − 1)
        /// </summary>
        public static int Task1(int n, int k) {
            if (k > n) {
                return 0;
            }

            int[,] s = new int[n + 1, n + 1];

            // Warunki początkowe:

            // S(n,0) = 0 dla n>=1
            for (int i = 1 ; i <= n ; i++) {
                s[i, 0] = 0;
            }
            // S(0,0) = 1
            s[0, 0] = 1;

            // S(n,1) = 1 dla n>=1
            for (int i = 1 ; i <= n ; i++) {
                s[i, 1] = 1;
            }
            // S(n,n) = 1
            for (int i = 0 ; i <= n ; i++) {
                s[i, i] = 1;
            }



            for (int i = 1 ; i <= n ; i++)
                for (int j = 2 ; j <= i ; j++) { // indeks od 2 ponieważ przypadek S(n,1) już rozpatrzono wyżej
                    if (i != j) { // Przypadki S(n,n) już rozpatrzono wyżej
                        s[i, j] = j * s[i - 1, j] + s[i - 1, j - 1];
                    }
                }
            return s[n, k];
        }
        /// <summary>
        /// Napisz program obliczający za pomocą programowania dynamicznego wartości liczb Stirlinga
        /// pierwszego rodzaju ze wzoru: s(n, k) = s(n − 1, k − 1) − (n − 1)s(n − 1, k),
        /// </summary>
        public static int Task2(int n, int k) {
            if (k > n) {
                return 0;
            }

            int[,] s = new int[n + 1, n + 1];

            // Warunki początkowe:

            // S(n,0) = 0 dla n>=1
            for (int i = 1 ; i <= n ; i++) {
                s[i, 0] = 0;
            }
            // S(0,0) = 1
            s[0, 0] = 1;

            // S(n,n) = 1
            for (int i = 0 ; i <= n ; i++) {
                s[i, i] = 1;
            }



            for (int i = 1 ; i <= n ; i++)
                for (int j = 1 ; j <= i ; j++) {
                    if (i != j) { // Przypadki S(n,n) już rozpatrzono wyżej
                        s[i, j] = s[i - 1, j - 1] - (i - 1) * s[i - 1, j];
                    }
                }
            return s[n, k];
        }
        /// <summary>
        /// Napisz program obliczający za pomocą programowania dynamicznego wartości liczb Bella
        /// ze wzoru: B(n) = for k=0 to n-1 do (n − 1)!/(k!(n-1-k!)*B(k)
        /// </summary>
        public static int Task3(int n) {
            int[] s = new int[n + 1];

            // Przypadek podstawowy
            s[0] = 1;


            for (int k = 1 ; k <= n ; k++) {
                for (int j = 0 ; j < k ; j++) {
                    s[k] += (int) Utils.BinomialCoeff(k - 1, j) * s[j];
                }
            }

            return s[n];
        }
    }
}
