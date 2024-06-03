using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class LightNodeFactory
    {
        private Dictionary<string, LightNode> _nodes = new Dictionary<string, LightNode>();

        public LightNode GetNode(string text)
        {
            if (!_nodes.ContainsKey(text))
            {
                _nodes[text] = new LightTextNode(text);
            }
            return _nodes[text];
        }
    }
}
