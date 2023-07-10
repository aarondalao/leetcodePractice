namespace ValidParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            // valid cases
            string case1 = "()";
            string case2 = "{}";
            string case3 = "[]";
            string case4 = "(){}[]";
            string case5 = "{([])}";
            string case6 = "{}{()[]}[(){}()[]{}[]]";

            // invalid cases
            string case7 = "(((({))))[][]}";
            string case8 = "(]";
            string case9 = "[])";
            string case10 = "{{{{{{)}}}}}}";

            

            Solution s = new Solution();
            Console.WriteLine(s.isValid(case1));
        }
    }

    public class Solution
    {
        public string isValid(string s)
        {   
            // check if the length of the string is not an even number. 
            // if odd, then the string must be missing a character.
            // return false immediately
            if (s.Length % 2 != 0) return "false";

            // if s is even
            for(int i = 0; i<=s.Length - 1; i++)
            {
                // Console.WriteLine(s[i]);

                if(i % 2 == 0) Console.WriteLine($"even string:  {s[i]} index is: {i}");
                else Console.WriteLine($"odd string: { s[i]} index is {i}");
            }

            return "true";
        }
    }
}