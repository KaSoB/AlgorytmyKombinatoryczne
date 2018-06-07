using System;
using System.Collections.Generic;
using System.Linq;
namespace AlgorytmyKombinatoryczne {
    public class Lesson12 {
        /// <summary>
        /// Napisz program generujący kod Prufera dla zadanego drzewa T o n wierzchołkach
        /// </summary>
        public static List<int> Task1(List<Tuple<int, int>> list, int n) {
            List<int> result = new List<int>();
            int[] d = new int[n];
            for (int i = 1 ; i <= d.Length ; i++) {
                d[i - 1] = list.Count(it => it.Item1 == i || it.Item2 == i);
            }

            while (result.Count != n - 2) {
                // szukamy min większej od 0
                var min = d.Where(it => it > 0).Min();
                // +1, bo numeracja od 1
                var indexMin = d.Select((value, index) => new { Value = value, Index = index }).Last(it => it.Value == min).Index + 1;
                // szukamy krotki która posiada parametr równy indexMin
                var tuple = list.Find(it => it.Item1 == indexMin || it.Item2 == indexMin);
                // usuwamy wybraną krotkę
                list.Remove(tuple);

                // odnotowujemy to usunięcie
                d[tuple.Item1 - 1] -= 1;
                d[tuple.Item2 - 1] -= 1;

                // dodajemy do wyników tę drugą wartość krotki
                result.Add((tuple.Item1 == indexMin) ? tuple.Item2 : tuple.Item1);
            }

            return result;
        }

        /// <summary>
        /// Napisz program wyznaczający drzewo odpowiadające zadanemu kodowi Prufera L.
        /// </summary>
        public static List<Tuple<int, int>> Task2(List<int> list) {
            int n = list.Count + 2;
            int[] d = new int[n];

            for (int i = 1 ; i <= d.Length ; i++) {
                d[i - 1] = list.Count(it => it == i);
            }
            for (int i = 1 ; i <= d.Length ; i++) {
                d[i - 1] += 1;
            }
            list.Add(1);
            var result = new List<Tuple<int, int>>();
            while (list.Any()) {
                // szukamy min większej od 0
                var min = d.Where(it => it > 0).Min();
                // +1, bo numeracja od 1
                var indexMin = d.Select((value, index) => new { Value = value, Index = index }).Last(it => it.Value == min).Index + 1;
                var firstElement = list[0];
                // dodajemy pierwszy element z listy + indeks gdzie znajduje sie wartość min
                result.Add(new Tuple<int, int>(firstElement, indexMin));
                // usuwamy ten element
                list.RemoveAt(0);
                // odnotowujemy to usunięcie
                d[firstElement - 1] -= 1;
                d[indexMin - 1] -= 1;
            }
            return result;
        }

        /// <summary>
        /// Napisz program obliczający rangę kodu Prufera L.
        /// </summary>
        public static int Task3(List<int> list, int n) {
            int r = 0;
            int p = 1;
            for (int i = n - 3 ; i >= 0 ; i--) {
                r += p * (list[i] - 1);
                p *= n;
            }
            return r;
        }

        /// <summary>
        /// Napisz program wyznaczający kod Prufera długości n − 2 o randze r.
        /// </summary>
        public static int[] Task4(int r, int n) {
            var tmp = new int[n - 2];

            for (int i = n - 3 ; i >= 0 ; i--) {
                tmp[i] = (r % n) + 1;
                r = (r - tmp[i] + 1) / n;
            }

            return tmp;
        }
    }
}
