using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FileLoggerAdapter : FileWriter
    {
        private Logger _logger = new Logger();

        public void Log(string message)
        {
            _logger.Log(message);
            base.Write(message);
        }

        public void Error(string message)   
        {
            _logger.Error(message);
            base.Write(message);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
            base.Write(message);
        }
    }
}
