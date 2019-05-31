using System;

namespace Problems
{
    public class Program
    {
        public string Prefix(string input){
            if(input == null){
                return null;
            }
            string[] myStrings = input.Split();
            int count = 0;
            foreach(string word in myStrings){
                string current = word.Replace(" ","");
                if(current.Length != 0){
                    count++;
                }
            }
            return $"{input.Length},{count}:{input}";
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Prefix("what ... did you say?? "));
        }
    }
}
