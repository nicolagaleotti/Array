using System;

namespace LibreriaArray
{
    public class GestioneArray
    {
        // Tipi int

        public static void LeggiArrayInt(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine($"Inserisci il valore dell'array i posizione {1}");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void StampaArrayInt(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static int[] CopiaArrayInt(int [] array)
        {
            int[] array2 = new int[array.Length];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array2[i] = array[i];
            }
            return array2;
        }
        public static bool RicercaArrayInt(int [] array, int elemento)
        {
            int v = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == elemento)
                    v++;
            }
            if (v == 0)
                return false;
            else
                return true;
        }
        public static bool SonoUgualiInt(int [] array1, int [] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            string risposta = "si";
            for (int i = 0; i < array1.Length - 1; i++)
            {
                if (array1[i] != array2[i])
                    risposta = "no";
            }
            if (risposta == "si")
                return true;
            else
                return false;
        }

        // Tipi double

        public static void LeggiArrayDouble(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine($"Inserisci il valore dell'array i posizione {1}");
                array[i] = double.Parse(Console.ReadLine());
            }
        }
        public static void StampaArrayDouble(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static double[] CopiaArrayDouble(double[] array)
        {
            double[] array2 = new double [array.Length];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array2[i] = array[i];
            }
            return array2;
        }
        public static bool RicercaArrayDouble(double[] array, double elemento)
        {
            int v = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == elemento)
                    v++;
            }
            if (v == 0)
                return false;
            else
                return true;
        }
        public static bool SonoUgualiDouble(double[] array1, double[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            string risposta = "si";
            for (int i = 0; i < array1.Length - 1; i++)
            {
                if (array1[i] != array2[i])
                    risposta = "no";
            }
            if (risposta == "si")
                return true;
            else
                return false;
        }

        // Tipi string

        public static void LeggiArrayString(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine($"Inserisci il valore dell'array i posizione {1}");
                array[i] = Console.ReadLine();
            }
        }
        public static void StampaArrayString(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static string[] CopiaArrayString(string[] array)
        {
            string[] array2 = new string[array.Length];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array2[i] = array[i];
            }
            return array2;
        }
        public static bool RicercaArrayString(string[] array, string elemento)
        {
            int v = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == elemento)
                    v++;
            }
            if (v == 0)
                return false;
            else
                return true;
        }
        public static bool SonoUgualiString(string[] array1, string[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            string risposta = "si";
            for (int i = 0; i < array1.Length - 1; i++)
            {
                if (array1[i] != array2[i])
                    risposta = "no";
            }
            if (risposta == "si")
                return true;
            else
                return false;
        }

        // Altri metodi

        public static int CercaMax(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length - 1;)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        public static int CercaMin(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length - 1;)
            {
                if (array[i] > min)
                    min = array[i];
            }
            return min;
        }
        public static bool Crescente (int [] array)
        {
            string risposta = "si";
            for ( int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                    risposta = "no";
            }
            if (risposta == "si")
                return true;
            else
                return false;
        }
        public static bool Decrescente(int[] array)
        {
            string risposta = "si";
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                    risposta = "no";
            }
            if (risposta == "si")
                return true;
            else
                return false;
        }
    }
}
