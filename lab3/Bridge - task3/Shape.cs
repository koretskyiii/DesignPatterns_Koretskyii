namespace Bridge___task3
{
    public abstract class Shape
    {
        protected IRenderEngine renderEngine;

        public Shape(IRenderEngine renderEngine)
        {
            this.renderEngine = renderEngine;
        }

        public abstract void Draw();
    }
}
