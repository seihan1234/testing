using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zad
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("List 1: ");
            List<int> nums1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.Write("List 2: ");
            List<int> nums2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> resSame = new List<int>();
            List<int> resN1 = new List<int>();
            List<int> resN2 = new List<int>();

            int len1 = nums1.Count;
            int len2 = nums2.Count;

            for (int i = 0; i < len1; i++)
            {
                if (nums2.Contains(nums1[i]))
                {
                    resSame.Add(nums1[i]);
                }
            }

            for (int i = 0; i < len1; i++)
            {
                if (!nums2.Contains(nums1[i]))
                {
                    resN1.Add(nums1[i]);
                }
            }

            for (int i = 0; i < len2; i++)
            {
                if (!nums1.Contains(nums2[i]))
                {
                    resN2.Add(nums2[i]);
                }
            }

            Console.WriteLine("Same");
            foreach (var item in resSame)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Special for list 1");
            foreach (var item in resN1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Special for list 2");
            foreach (var item in resN2)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
