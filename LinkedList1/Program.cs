using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 
            Console.WriteLine("Write an algorithm to determine if a LinkedList is a palindrome.");
            // Q: input = LinkedList? output = boolean? singly-linked, doubly-linked, or circular? How to handle null or empty or 1 node? type of ll = char? ok to modify the ll in the process?
            string palindrome1 = "abccba";
            var ll = new LinkedList<char>(palindrome1);
            bool isPalindrome = IsPalindrome(ll);
            Console.WriteLine($"\nThe LinkedList containing {palindrome1} is a palindrome: {isPalindrome}");

            Console.ReadKey();
        }

        /// <summary>
        /// Write an algorithm to determine if a LinkedList is a palindrome.
        /// </summary>
        private static bool IsPalindrome(LinkedList<char> ll)
        {
            // Handle edge cases
            // if ll is null
            if (ll == null)
            {
                return false;
            }

            // if ll is empty 
            if (ll.First == null && ll.Last == null)
            {
                return true;
            }

            // if ll contains 1 node
            if (ll.Count == 1)
            {
                return true;
            }

            // algorithm for usual cases
            // check for node equality
            while (ll.First.Value == ll.Last.Value)
            {
                // remove first and last
                ll.RemoveFirst();
                ll.RemoveLast();

                // if zero or 1 node remains, return true
                if (ll.Count <= 1)
                {
                    return true;
                }
            }

            // return value
            return false;
        }
    }
}
