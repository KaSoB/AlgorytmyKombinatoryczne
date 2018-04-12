using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyKombinatoryczne {
    public class Lesson3 {
        /// <summary>
        /// 1. Napisz program generujący wszystkie podzbiory zbioru {1, . . . , n} w porządku minimalnych
        /// zmian(Graya), wykorzystując wagi Hamminga lub różnicę symetryczną zbiorów.
        /// </summary>
        /// <param name="n"></param>
        public static void Task1(int n) {
            bool[] gray = new bool[n];

            int indexToReverseBit;
            // Jest Math.Pow(2,n) takich podzbiorów
            for (int i = 0 ; i < Math.Pow(2, n) ; i++) {

                // Wyświetl numery indeksu tych elementów którego wartości są równe "1"
                // np. 001 -> {3}  011 -> {2,3}  100-> {1}
                Output.Subset(
                    gray.Select((value, index) => new { Value = value, Index = index + 1 })
                    .Where(x => x.Value != false)
                    .Select(x => x.Index)
                    .ToArray());

                if (HammingWeight(gray) % 2 == 0) { // Jeżeli waga Hamming'a jest parzysta...
                    indexToReverseBit = n - 1;  // wybierz ostatni bit
                } else { // w przeciwnym razie -> wybierz pierwszą 1 od prawej strony, i wybierz następny (na lewo) bit
                    indexToReverseBit = Math.Max(0, LastIndexOfPositiveBit(gray)-1); 
                }
                // Zamień bit
                gray[indexToReverseBit] = !gray[indexToReverseBit];
            }

        }
        /// <summary>
        /// https://en.wikipedia.org/wiki/Hamming_weight
        /// </summary>
        /// <returns>number of symbols that are different from the zero-symbo</returns>
        public static int HammingWeight(bool[] vs) => 
            vs.Count(it => it == true);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vs"></param>
        /// <returns>-1 if not found</returns>
        public static int LastIndexOfPositiveBit(bool[] vs) {
            for (int i = vs.Count() - 1 ; i >= 0 ; i--) {
                if (vs[i]) {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Napisz program obliczający rangę podzbioru T ⊂ {1, . . . , n} w uporządkowaniu minimalnych
        /// zmian(Graya) podzbiorów zbioru {1, . . . , n }.
        /// </summary>
        /// <param name="n">size</param>
        /// <param name="list"></param>
        public static void Task2(int n, List<int> list) {
            list.Sort();

            var tmp = new int[n];

            // Przypisz 1 pod indeksem wskazanym przez wartość w liście
            foreach (var value in list) {
                tmp[value - 1] = 1; 
            }

            int rank = 0;
            for (int i = 0 ; i < n ; i++) {
                tmp[i] = (rank + tmp[i]) % 2;
                rank = tmp[i];
            }

            int result = 0;
            // Zamień wartość binarną na wynik w postaci dziesiętnej
            for (int i = n - 1, j = 0 ; i >= 0 ; i--, j++) {
                result += tmp[i] * (int) Math.Pow(2, j);
            }
            Output.Value(result);
        }
        /// <summary>
        /// Napisz program wyznaczający podzbiór T o zadanej pozycji r w uporządkowaniu minimalnych
        /// zmian(Graya) podzbiorów zbioru {1, . . . , n }.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="r"></param>
        public static void Task3(int n, int r) {
            List<int> result = new List<int>(n);

            // Zamień wartość r na postać binarną i ujednolić długość listy do n
            List<int> binary1 = Utils.ToBinary(r);
            Utils.StaticResizeList(binary1, n);
            // Zamień wartość r/2 na postać binarną i ujednolić długość listy do n
            List<int> binary2 = Utils.ToBinary(r / 2);
            Utils.StaticResizeList(binary2, n);

            for (int i = 0 ; i < n ; i++) {
                if ((binary1[i] ^ binary2[i]) == 1) { // XOR
                    // wrzuć pozycję do wyniku
                    result.Add(i + 1);
                }
            }
            Output.Subset(result);
        }

      

      


    }

}
