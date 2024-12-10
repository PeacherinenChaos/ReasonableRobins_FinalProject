// Name: Annapoorna Nair
// email: nairap @mail.uc.edu
// Assignment Title: Reasonable Robins Final project
// Due Date: 12 / 07 / 24
// Course: IS 3050
// Semester/Year: Fall 2024
// Brief Description: Final project using the watertrap problem
// Citations: Leetcode for the actual problem itself
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ReasonableRobins_FinalProject
{
    public partial class WordCount
    {
        public int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            // Initialize a dictionary to store letter frequencies
            var letterCounts = new Dictionary<char, int>();
            // Count the frequency of each letter in the given letters
            foreach (char letter in letters)
            {
                if (!letterCounts.ContainsKey(letter))
                {
                    letterCounts.Add(letter, 1);
                }
                else
                {
                    letterCounts[letter]++;
                }
            }
            // Initialize the maximum score
            int maxScore = 0;
            // Iterate over each word in the list of words
            foreach (string word in words)
            {
                // Initialize the word's score and a flag to check validity
                int wordScore = 0;
                bool isValid = true;
                // Iterate over each letter in the word
                foreach (char letter in word)
                {
                    // If the letter is not available, the word is invalid
                    if (!letterCounts.ContainsKey(letter) || letterCounts[letter] == 0)
                    {
                        isValid = false;
                        break;
                    }
                    // Add the letter's score to the word's score
                    wordScore += score[letter - 'a'];
                    // Decrement the letter's count in the letter_counts dictionary
                    letterCounts[letter]--;
                }
                // If the word is valid, add its score to the maximum score
                if (isValid)
                {
                    maxScore += wordScore;
                }
            }
            return maxScore;
        }
    }
}