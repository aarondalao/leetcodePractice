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
            string case10 = "";

            Solution s = new Solution();
            Console.WriteLine(s.isValid(case1));
        }
    }

    public class Solution
    {
        public string isValid(string s)
        {
            for (int i = 0; i <= s.Length; i++) { 
                
            }
        }
    }
}