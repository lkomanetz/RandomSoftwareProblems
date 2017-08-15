using System;
using System.Linq;

namespace PalindromeExample {

	public class PalindromeChecker {

		public bool Check(string textToCheck) {
			char[] textAsArray = textToCheck.Replace(" ", "").ToCharArray();
			char[] reversedArray = Reverse(textAsArray);

			return textAsArray.SequenceEqual(reversedArray);
		}

		private char[] Reverse(char[] charArray) {
			char[] reversedArray = new char[charArray.Length];

			for (int i = 0; i < charArray.Length; ++i) {
				char tmp = charArray[charArray.Length - i - 1];
				reversedArray[i] = tmp;
			}

			return reversedArray;
		}

	}

}