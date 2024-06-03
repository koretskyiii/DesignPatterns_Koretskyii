using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextReader : TextReader
    {
        public override char[][] ReadText(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            char[][] text = new char[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                text[i] = lines[i].ToCharArray();
            }
            return text;
        }
    }
}
