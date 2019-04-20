using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
			string line = "Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine.";
			string words = line.split(' ');
			string word = "";
			int counter = 0;
			foreach(string s in words){
				if(s.Length > counter)
				{
					word =s;
					counter = s.length;
				}
			}			
			Console.WriteLine(word);
			Console.ReadLine();
		}
	}
}
