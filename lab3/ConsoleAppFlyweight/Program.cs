
using Flyweight;

LightNodeFactory factory = new LightNodeFactory();


string[] lines = File.ReadAllLines("book.txt");

for (int i = 0; i < lines.Length; i++)
{
    string line = lines[i];
    LightNode node;

    if (i == 0)
    {
        node = new LightElementNode("h1", factory.GetNode(line));
    }
    else if (line.StartsWith(" "))
    {
        node = new LightElementNode("blockquote", factory.GetNode(line));
    }
    else if (line.Length < 20)
    {
        node = new LightElementNode("h2", factory.GetNode(line));
    }
    else
    {
        node = new LightElementNode("p", factory.GetNode(line));
    }

    Console.WriteLine(node.OuterHTML);
}
long memory = GC.GetTotalMemory(true);
Console.WriteLine($"Memory usage: {memory} bytes");

