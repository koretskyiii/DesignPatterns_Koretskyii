using Adapter;
using Bridge;
using Bridge___task3;
using Composite;
using Proxy;
using System.Threading;

// Adapter
FileLoggerAdapter fileLogger = new FileLoggerAdapter();

fileLogger.Log("This is a log message");
fileLogger.Error("This is an error message");
fileLogger.Warn("This is a warning message");

// Decorator
Hero hero = new Warrior();


hero = new Armor(hero);
hero = new Sword(hero);
hero = new Artifact(hero);

Console.WriteLine(hero.GetDescription());


// Bridge
Shape circle = new Circle(new VectorRenderEngine());
Shape square = new Square(new RasterRenderEngine());
Shape triangle = new Triangle(new VectorRenderEngine());

circle.Draw();
square.Draw();
triangle.Draw();


// Proxy
SmartTextReader smartTextReader = new SmartTextReader();
SmartTextChecker smartTextChecker = new SmartTextChecker(smartTextReader);
SmartTextReaderLocker smartTextReaderLocker = new SmartTextReaderLocker(smartTextReader, @"\.txt$");

char[][] text = smartTextChecker.ReadText("example.txt");
char[][] lockedText = smartTextReaderLocker.ReadText("example.txt");


// Composite
LightElementNode ul = new LightElementNode("ul");
ul.AddClass("my-list");
ul.AddClass("special-list");

LightTextNode li1 = new LightTextNode("Item 1");
LightTextNode li2 = new LightTextNode("Item 2");
LightTextNode li3 = new LightTextNode("Item 3");

ul.AddChild(new LightElementNode("li", li1));
ul.AddChild(new LightElementNode("li", li2));
ul.AddChild(new LightElementNode("li", li3));

Console.WriteLine(ul.OuterHTML);




