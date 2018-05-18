﻿using System;
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
            Console.WriteLine("1) Write an algorithm to determine if a LinkedList is a palindrome.");
            // Q: input = LinkedList? output = boolean? singly-linked, doubly-linked, or circular? How to handle null or empty or 1 node? type of ll = char? ok to modify the ll in the process?
            string palindrome1 = "abccba";
            var ll = new LinkedList<char>(palindrome1);
            bool isPalindrome = IsPalindrome(ll);
            Console.WriteLine($"\nThe LinkedList containing {palindrome1} is a palindrome: {isPalindrome}");

            palindrome1 = "a";
            var mm = new LinkedList<char>(palindrome1);
            isPalindrome = IsPalindrome(mm);
            Console.WriteLine($"\nThe LinkedList containing {palindrome1} is a palindrome: {isPalindrome}");

            palindrome1 = string.Empty;
            var nn = new LinkedList<char>(palindrome1);
            isPalindrome = IsPalindrome(nn);
            Console.WriteLine($"\nThe LinkedList containing {palindrome1} is a palindrome: {isPalindrome}");

            var oo = new LinkedList<char>();
            oo = null;
            isPalindrome = IsPalindrome(oo);
            Console.WriteLine($"\nThe LinkedList containing {palindrome1} is a palindrome: {isPalindrome}");

            palindrome1 = "abc";
            var pp = new LinkedList<char>(palindrome1);
            isPalindrome = IsPalindrome(pp);
            Console.WriteLine($"\nThe LinkedList containing {palindrome1} is a palindrome: {isPalindrome}");


            palindrome1 = "abca";
            var qq = new LinkedList<char>(palindrome1);
            isPalindrome = IsPalindrome(qq);
            Console.WriteLine($"\nThe LinkedList containing {palindrome1} is a palindrome: {isPalindrome}");

            // 4.
            Console.WriteLine("\nWrite an algorithm to removed duplicates from an unsorted linked list. Follow up: What if a temporary buffer is not allowed?");
            // Q's: singly-, doubly-, or circular linked list? input = doubly-linked list, output = same list with dup's removed? Ok if it's sorted at the end? are the duplicates in any kind of sequence like unordered char's with dup's?
            // one solution would use a dictionary to store keys = data, values = number of occurences
            // Maybe should use a list for keys. first entry in list is num of occurrences, remaining entries contain node indexes for faster removal?
            // another solution would be to sort the list first. This would alter the list, but so will removing dups.

            string unorderedChars = "cbacba";
            var rr = new LinkedList<char>(unorderedChars);
            LinkedList<char> noDups = RemoveDups(rr);
            Console.WriteLine("\nThe LinkedList with dups:");
            Print(rr);
            Console.WriteLine("\nThe LinkedList without dups:");


            Console.ReadKey();
        }

        private static LinkedList<char> RemoveDups(LinkedList<char> ll)
        {
            // handle edge cases

            // sort the list

            // iterate through the ll to remove dups

            // return the new ll
        }

        private static void Print(LinkedList<char> ll)
        {
            foreach (var node in ll)
            {
                Console.Write($"{node} ");
            }
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
