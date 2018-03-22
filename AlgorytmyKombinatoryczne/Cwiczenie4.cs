﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyKombinatoryczne {
    public class Cwiczenie4 {
        public static List<int> Task1(List<int> list, int n, int k) {
            /*
            1. Napisz program wyznaczający następnik k-elementowego podzbioru T zbioru {1, . . . , n}
            w uporządkowaniu leksykograficznym podzbiorów k-elementowych. 
            */

            int i = k - 1;

            // Znajdź indeks elementu od którego można wyznaczyć następnik
            while (list[i] == n - k + i + 1 && i != 0) {
                i = i - 1;
            }

            if (i == 0) {
                Console.WriteLine("Nie ma następnika");
            } else {
                list[i] += 1;
                for (int j =  list.Count - 1 ; j < list.Count ; j++) {
                    list[j] = list[j - 1] + 1;
                }
            }

            Output.Subset(list);
            return list;
        }

        public static int Task2(List<int> list, int n, int k) {
            /*
            2. Napisz program obliczający rangę k-elementowego podzbioru T zbioru {1, . . . , n} w uporządkowaniu
            leksykograficznym podzbiorów k-elementowych.
            */
            list.Insert(0, 0); // zmiana indeksowania
            list.Sort();
            int rank = 0;

            for (int i = 1 ; i <= k ; i++) {
                for (int j = list[i - 1] + 1 ; j <= list[i] - 1 ; j++) {
                    rank += (int) Utils.BinomialCoeff(n - j, k - i);
                }
            }

            Output.Value(rank);
            return rank;
        }

        public static List<int> Task3(int n, int k, int r) {
            /*
            3.Napisz program wyznaczający podzbiór T o randze r w uporządkowaniu leksykograficznym
            k-elementowych podzbiorów zbioru {1, . . . , n}.
           */
            List<int> result = Enumerable.Range(1, k).ToList();

            int x = 1;
            for (int i = 1 ; i <= result.Count ; i++) {
                while ( Utils.BinomialCoeff(n - x, k - i) <= r) {
                    r -= (int)Utils.BinomialCoeff(n - x, k - i);
                    x += 1;
                }
                result[i - 1] = x;
                x += 1;
            }


            Output.Subset(result);
            return result;
        }
    }
}
