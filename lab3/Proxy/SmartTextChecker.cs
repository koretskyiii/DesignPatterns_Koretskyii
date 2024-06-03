using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextChecker : TextReader
    {
        private SmartTextReader _smartTextReader;

        public SmartTextChecker(SmartTextReader smartTextReader)
        {
            _smartTextReader = smartTextReader;
        }

        public override char[][] ReadText(string filePath)
        {
            Console.WriteLine($"Opening file {filePath}");
            char[][] text = _smartTextReader.ReadText(filePath);
            Console.WriteLine($"Successfully read file {filePath}");
            Console.WriteLine($"Total lines: {text.Length}");
            Console.WriteLine($"Total characters: {GetTotalCharacters(text)}");
            Console.WriteLine($"Closing file {filePath}");
            return text;
        }

        private int GetTotalCharacters(char[][] text)
        {
            int total = 0;
            foreach (char[] line in text)
            {
                total += line.Length;
            }
            return total;
        }
    }
}
