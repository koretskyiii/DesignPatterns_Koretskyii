using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextReaderLocker : TextReader
    {
        private SmartTextReader _smartTextReader;
        private Regex _regex;

        public SmartTextReaderLocker(SmartTextReader smartTextReader, string pattern)
        {
            _smartTextReader = smartTextReader;
            _regex = new Regex(pattern);
        }

        public override char[][] ReadText(string filePath)
        {
            if (_regex.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return new char[0][];
            }
            else
            {
                return _smartTextReader.ReadText(filePath);
            }
        }
    }
}
