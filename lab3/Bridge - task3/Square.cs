﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge___task3
{
    public class Square : Shape
    {
        public Square(IRenderEngine renderEngine) : base(renderEngine) { }

        public override void Draw()
        {
            renderEngine.Render("Square");
        }
    }
}
