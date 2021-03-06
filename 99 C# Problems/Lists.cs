// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
namespace NinetyNineProblemsC
{
	public class Lists
	{
		public Lists ()
		{
		}

		public void runSolutions(){
			p01 ();
			p02 ();
			p03 (2);
			p04 ();
			p05 ();
			p06 ();
			p07 ();
			p08 ();
		}

		/**
		 * Helper function. 
		 * Simply prints representation of list and includes list name.
		 */
		public void printList(ArrayList list, string name){
			Console.Write (name + "(");
			for (int i = 0; i < list.Count; i++) {
				if(i < list.Count - 1){
					Console.Write(list[i] + ", ");
				}else{
					Console.Write (list[i]);
				}
			}
			Console.WriteLine (")");
		}

		/**
		 * Problem 01.
		 * Find last element of a list.
		 * Note that ArrayList is not restricted by type, therefore the variable
		 * to store the last element of the list in must be generic.
		 */
		public void p01(){
			Console.WriteLine ("\nP01 - Last element of a list.");
			ArrayList list = new ArrayList ();
			list.Add (27);
			list.Add ("Hello World!");
			list.Add ('a');
			list.Add (3.14);
			printList (list, "last");
			Object last = list [list.Count - 1];
			Console.WriteLine ("Last element is {0}.\nP01 Complete.\n", last);
		}

		/**
		 * Problem 02.
		 * Find the last but one element of a list.
		 */
		public void p02(){
			Console.WriteLine ("P02 - Last but one element of a list.");
			ArrayList list = new ArrayList ();
			list.Add (27);
			list.Add ("Hello World!");
			list.Add ('a');
			list.Add (3.14);
			printList (list, "lastButOne");
			Object lastButOne = list [list.Count - 2];
			Console.WriteLine ("Last but one element is {0}.\nP02 Complete.\n", lastButOne);
		}

		/**
		 * Problem 03.
		 * Find the K'th element of a list.
		 */
		public void p03(int k){
			Console.WriteLine ("P03 - Find the K'th element of a list.");
			ArrayList list = new ArrayList ();
			list.Add (27);
			list.Add ("Hello World!");
			list.Add ('a');
			list.Add (3.14);
			printList (list, "kthElement");
			Object kth = null;
			try{
				kth = list [k-1];
			}catch(ArgumentOutOfRangeException e){
				Console.WriteLine("Index error in P03: " + e.Message);
			}catch(Exception e){
				Console.WriteLine("Error occured in P03: " + e.Message);
			}
			if (kth != null) {
				Console.WriteLine ("kth element is {0}.\nP03 Complete.\n", kth);
			}
		}

		/**
		 * Problem 04.
		 * Find the number of elements in a list.
		 */
		public void p04(){
			Console.WriteLine ("P04 - Find the number of elements in a list.");
			ArrayList list = new ArrayList ();
			list.Add (27);
			list.Add ("Hello World!");
			list.Add ('a');
			list.Add (3.14);
			printList (list, "length");
			Console.WriteLine ("Length of the list is {0}.\nP04 Complete.\n", list.Capacity);
		}

		/**
		 * Problem 05.
		 * Reverse a list.
		 */
		public void p05(){
			Console.WriteLine ("P05 - Reverse a list.");
			ArrayList list = new ArrayList ();
			list.Add (27);
			list.Add ("Hello World!");
			list.Add ('a');
			list.Add (3.14);
			printList (list, "original");
			Console.Write ("reversed(");
			for (int i = list.Count - 1; i >= 0; i--) {
				if(i > 0){
					Console.Write (list[i] + ", ");
				}else{
					Console.Write (list[i]);
				}
			}
			Console.Write (")\nP05 Complete.\n");
		}

		/**
		 * Problem 06.
		 * Find out whether a list is a palindrome.
		 */
		public void p06(){
			Console.WriteLine ("\nP06 - Check if list is a palindrome.");
			ArrayList list = new ArrayList (new int[] {1, 2, 3, 2, 1});
			bool isPalindrome = true;
			printList (list, "isPalindrome");
			int i = 0, j = list.Count - 1;
			while (i <= j) {
				if(!list[i].Equals(list[j])){
					isPalindrome = false;
				}	
				i++;
				j--;
			}
			Console.WriteLine ("isPalindrome = {0}.\nP06 Complete.\n", isPalindrome);
		}

		/**
		 * Problem 07.
		 * Flatten a nested list structure.
		 */
		public void p07(){
			Console.WriteLine ("\nP07 - Flatten nested list structure.");
			List<Object> list = new List<Object> ();
			List<int> list1 = new List<int> ();
			list.Add (1);
			list.Add (1);
			int two = 2;
			List<int> list2 = new List<int> ();
			list2.Add (5);
			list2.Add (8);
			int three = 3;
			List<Object> list3 = new List<Object> ();
			list3.Add (three);
			list3.Add (list2);
			list.Add (list1);
			list.Add (two);
			list.Add (list3);
			List<int> flatten = new List<int> ();

			foreach(var item in list){
				flattenList(item, flatten);
			}
			ArrayList flatten2 = new ArrayList (flatten);
			printList(flatten2, "flatten");
			Console.WriteLine ("P07 Complete.\n");
		}

		/**
		 * Problem 07.
		 * Recursive helper function to flatten a nested list structure.
		 */
		public void flattenList(Object item, List<int> flat){
			int test = 0;
			List<int> listInts = new List<int> ();
			List<Object> listObjects = new List<Object> ();
			if (item.GetType () == test.GetType ()) {
				flat.Add ((int)item);
			} else if (item.GetType () == listInts.GetType ()) {
				IList temp = item as IList;
				foreach (var i in temp) {
					flat.Add ((int)i);
				}
			} else if (item.GetType () == listObjects.GetType ()) {
				IList temp = item as IList;
				foreach(var i in temp){
					flattenList (i, flat);
				}
			}	
		}

		/**
		 * Problem 08.
		 * Eliminate consecutive duplicates of list elements.
		 */
		public void p08(){
			Console.WriteLine ("P08 - Remove consecutive duplicates of list elements.");
			List<char> list;
			list = new List<char> (new char[] {'a','a','a','a', 'b', 'c', 'c', 'a','a','d','e','e','e','e'});
			ArrayList original = new ArrayList (list);
			printList (original, "original");
			List<char> result = new List<char> ();

			foreach (char c in list) {
				if(result.Count == 0){
					result.Add (c);
				}else{
					if(c != result[result.Count - 1]){
						result.Add (c);
					}
				}
			}
			ArrayList res = new ArrayList(result);
			printList (res, "removeDupes");
			Console.WriteLine ("P08 Complete.\n");
		}

		/**
		 * Problem 09.
		 * Pack consecutive elements of list elements into sublists.
		 * IN PROGRESS.
		 */
		public void p09(){

		}

	}//class
}//namespace

