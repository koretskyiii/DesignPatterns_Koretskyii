using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge___task3
{
    public class RasterRenderEngine : IRenderEngine
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Drawing {shape} as pixels");
        }
    }
}
