using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorytmyKombinatoryczne {
    public class Lesson10 {
        /// <summary>
        /// Napisz program generujący funkcję RGF f : {1, . . . , n} → Z+ odpowiadającą zadanemu
        /// podziałowi zbioru {1, . . . , n }
        /// </summary>
        public static int[] Task1(List<List<int>> list, int n) {
            var array = new int[n];
            int num = 1;
            for (int i = 1 ; i <= n ; i++) {
                var findSubset = list.Where(it => it.Contains(i)).FirstOrDefault();

                if (findSubset != null) {
                    list.Remove(findSubset);
                    foreach (var item in findSubset) {
                        array[item - 1] = num;
                    }
                    num++;
                }
            }


            return array;
        }
        /// <summary>
        /// Napisz program generujący podział zbioru {1, . . . , n } odpowiadający zadanej funkcji RGF f : {1, . . . , n} → Z+.
        /// </summary>
        public static List<List<int>> Task2(List<int> list) {
            int n = list.Max();
            var result = new List<List<int>>();

            for (int i = 0 ; i < n ; i++) {
                result.Add(new List<int>()); // TODO: sprawdzić czy trzeba usunać tą linię
                result[i].AddRange(list
                    .Select((value, index) => new { Value = value, Index = index + 1 })
                    .Where(x => x.Value == i + 1)
                    .Select(x => x.Index));
            }
            return result;
        }


        /// <summary>
        /// Napisz program generujący wszystkie funkcje RGF f : {1, . . . , n} → Z+ w porządku leksykograficznym.
        /// </summary>
        public static void Task3(int n) {
            List<int> array = Enumerable.Repeat(1, n).ToList();
            List<int> fmax = Enumerable.Repeat(2, n).ToList();
            array.Insert(0, 0);
            fmax.Insert(0, 0);
            bool running = true;
            int j;
            while (running) {
                Output.Subset(array.Skip(1));

              
                j = n + 1;
                do {
                    j -= 1;
                } while (array[j] == fmax[j]);
                if (j > 1) {
                    array[j] += 1;
                    for (int i = j + 1 ; i <= n ; i++) {
                        array[i] = 1;
                        if (array[j] == fmax[j]) {
                            fmax[i] = fmax[j] + 1;
                        } else {
                            fmax[i] = fmax[j];
                        }
                    }
                } else {
                    running = false;
                }
            }


        }
    }
}
