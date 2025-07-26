
using System.Linq;

namespace GenericSort
{


public static class Sort
{

    
        /// <summary>
        ///     Sorts given array in ascending order using a recursive quick sort algorithm 
        ///     This implementation uses the LINQ library for partitioning 
        /// </summary>
        /// <typeparam name="T">The type of the elements in the array.
        /// It must implement <see cref="IComparable{T}"/> for comparison and
        /// <see cref="IEquatable{T}"/> for equality checks.</typeparam>
        ///  <exception cref="System.ArgumentNullException">Thrown if the input <paramref name="array"/> is null.</exception>
        /// <param name="array">An array of items to be sorted</param>
        /// <returns>The input Array sorted in ascending order </returns>
        /// <example>
        ///     This example shows how to sort an array of strings
        ///     <code lang="csharp">
        ///   string[] musicians = { "eminem", "zz top", "esmeralda", "sade", "mfdoom","prince", "michael jackson", "adele", "adele"  };
        ///  string[] sortedMusicians = Algos.Sort(musicians);
        ///  sortedMusicians.ToList().ForEach(Console.WriteLine);
        ///     </code>
        /// </example>
        public static T[] QSort<T>(T[] array)
            where T : IEquatable<T>, IComparable<T>
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "The input array cannot be null.");
            }
            if (array.Length <= 1) return array;
            var pivot = array[0];
            var left = array.Where(item => item.CompareTo(pivot) < 0).ToArray();
            var middle = array.Where(item => item.Equals(pivot)).ToArray();
            var right = array.Where(item => item.CompareTo(pivot) > 0).ToArray();

            return [.. QSort(left), .. middle, .. QSort(right)];
        }


/// <summary>
/// Sorts given array in ascending order using an iterative insertion sort algorithm
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="array"></param>
/// <returns></returns>
        public static void ISort<T>(T[] array)
            where T : IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 8, 6, 2 };
            string[] musicians = { "eminem", "zz top", "esmeralda", "sade", "mfdoom", "prince", "michael jackson", "adele", "adele" };
            ISort(numbers);
            ISort(musicians);

            Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));
            Console.WriteLine("Sorted musicians: " + string.Join(", ", musicians));
            

        }

}
}