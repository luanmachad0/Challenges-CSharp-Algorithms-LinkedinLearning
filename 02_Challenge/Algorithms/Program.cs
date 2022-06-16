using System;

namespace Algorithms {
    class Program {
        static int[] Reverse(int[] input) {
            int[] reversed = new int[input.Length];

            for (int i = 0; i < reversed.Length; i++) {
                reversed[i] = input[input.Length - i - 1];
            }

            return reversed;
        }

        static void RotationInPlaceToLeft(int[] input) {
            for (int i = 0; i < input.Length - 1; i++)
            {
                int temp = input[i];
                input[i] = input[i + 1];
                input[i + 1] = temp;
            }
        }

        static void RotationInPlaceToRight(int[] input) {
            for (int i = 5; i > input.Length - 6; i--)
            {
                int temp = input[i];
                input[i] = input[i - 1];
                input[i - 1] = temp;
            }
        }

        static void Main(string[] args) {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            RotationInPlaceToLeft(arr);
            // RotationInPlaceToRight(arr);
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}