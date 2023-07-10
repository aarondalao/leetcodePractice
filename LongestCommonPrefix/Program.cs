
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] case1 = { "flower", "flow", "flight" };
            string[] case2 = { "dog", "racecar", "car" };
            string[] case3 = { "" };
            string[] case4 = {
"grandmother",
"grandfather",
"grammatical",
"gravimetric",
"grandparent",
"groundswell",
"grasshopper",
"granulation",
"gravitation",
"greengrocer",
"granulocyte",
"greasepaint",
"grandiflora",
"gradiometer",
"grandnephew",
"grotesquery",
"groupuscule",
"granivorous",
"graniteware",
"greenkeeper",
"greenockite",
"groundsheet",
"groundlings",
"groundwoods",
"groundwater",
"groundworks",
"groupthinks",
"grotesquely",
"grouchiness",
"grovelingly",
"growthiness",
"grossnesses",
"gridironing",
"gridlocking",
"griminesses",
"grindstones",
"gristliness",
"grumblingly",
"gruffnesses",
"grubstaking",
"grubstakers",
"greennesses",
"greenmailed",
"greenmailer",
"greenshanks",
"greenhouses",
"greenhearts",
"greenfields",
"greenstones",
"greenswards",
"greenstuffs",
"greenwashes",
"greaseballs",
"greasewoods",
"greaseproof",
"greenbriers",
"greenbacker",
"greatnesses",
"grecianized",
"grecianizes",
"gravitating",
"gravitative",
"gravimeters",
"gravidities",
"gratulatory",
"gratulating",
"gratulation",
"gratineeing",
"gravestones",
"gravenesses",
"granitelike",
"grangerisms",
"granduncles",
"grandstands",
"grandnesses",
"grandnieces",
"grandiosity",
"grandiosely",
"granolithic",
"granophyres",
"granophyric",
"granulomata",
"granulators",
"granularity",
"granulating",
"gratefuller",
"graptolites",
"grapefruits",
"graphically",
"graphicness",
"graphitized",
"graphitizes",
"grapholects",
"grapinesses",
"gradualists",
"gradualness",
"gradualisms",
"gradational"};

            string[] case5 = { "a" };
            string[] case6 = { "ab", "a" };



            Solution mySolutionObject = new Solution();

            Console.WriteLine(mySolutionObject.LongestCommonPrefix(case6));
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string initStringSample = strs[0];
            string prefix = "";
            // check if string[] is empty or null
            if (strs.Length == 0 || strs == null) return "";

            // check if string[] contains 1 element
            if (strs.Length == 1) return strs[0];

            // iterate the characters of the first string
            for (int i = 0; i <= strs[0].Length-1; i++)
            {

                foreach (string word in strs)
                {
                    if (i > word.Length -1) return prefix;
                    if (strs[0][i] != word[i]) return prefix;
                }

                prefix = prefix + strs[0][i];

            }
            return prefix;
        }
    }
}