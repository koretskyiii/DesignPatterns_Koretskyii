using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class LightElementNode : LightNode
    {
        private string _tagName;
        private LightNode _child;

        public LightElementNode(string tagName, LightNode child)
        {
            _tagName = tagName;
            _child = child;
        }

        public override string OuterHTML => $"<{_tagName}>{_child.OuterHTML}</{_tagName}>";
    }
}
