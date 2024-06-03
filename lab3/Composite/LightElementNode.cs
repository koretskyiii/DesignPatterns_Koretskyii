using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class LightElementNode : LightNode
    {
        private string _tagName;
        private List<string> _classes;
        private List<LightNode> _children;

        public LightElementNode(string tagName, params LightNode[] children)
        {
            _tagName = tagName;
            _classes = new List<string>();
            _children = children.ToList();
        }

        public void AddClass(string className)
        {
            _classes.Add(className);
        }

        public void AddChild(LightNode child)
        {
            _children.Add(child);
        }

        public override string OuterHTML
        {
            get
            {
                string classes = string.Join(" ", _classes);
                string children = string.Join("", _children.Select(c => c.OuterHTML));
                return $"<{_tagName} class=\"{classes}\">{children}</{_tagName}>";
            }
        }

        public override string InnerHTML
        {
            get
            {
                return string.Join("", _children.Select(c => c.OuterHTML));
            }
        }
    }
}
