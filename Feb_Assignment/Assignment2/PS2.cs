using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class PS2
    {
        public string Solution(string s)
        {
            if (s == null) 
            { 
                return string.Empty; 
            }
            char[] separators = new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '/', '\\', '!', '?', ' ' }; 
            char[] chars = s.ToCharArray(); 
            int n = chars.Length;
            bool isWord = true; 
            StringBuilder sb = new StringBuilder(); 
            List<string> wordsList = new List<string>(); 
            List<string> separatorList = new List<string>(); 

            foreach (var c in chars) 
            { 
                if (isWord) 
                { 
                    if (separators.Contains(c)) 
                    { 
                        wordsList.Add(sb.ToString()); 
                        sb.Clear(); 
                        isWord = !isWord; 
                    } 
                } 
                else 
                { 
                    if (!separators.Contains(c)) 
                    { 
                        separatorList.Add(sb.ToString()); 
                        sb.Clear(); 
                        isWord = !isWord; 
                    } 
                } 
                sb.Append(c); 
            }
            separatorList.Add(sb.ToString()); 
            sb.Clear(); 
            int m = wordsList.Count(); 

            for (int i = 0; i < m; i++) 
            { 
                sb.Append(wordsList[m - 1 - i]); 
                sb.Append(separatorList[i]); 
            }

            return sb.ToString();
        }
    }
}
