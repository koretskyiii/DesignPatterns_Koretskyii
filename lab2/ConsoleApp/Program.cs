using task1;
using task2;
using task3;
using task4;
using System.Text;
using task5;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

// TASK 1 -> Фабричний метод

var website = new WebSite();
var mobileApp = new MobileApp();
var managerCall = new ManagerCall();

var webDomesticSub = website.CreateSubscription("Domestic", 5);
var mobileEduSub = mobileApp.CreateSubscription("Educational", 3);
var managerPremSub = managerCall.CreateSubscription("Premium", 3);

webDomesticSub.SubscriptionData();
mobileEduSub.SubscriptionData();
managerPremSub.SubscriptionData();

// TASK 2 -> Абстрактна фабрика
var iPhoneFactory = new iProneFactory();
var iphone15 = iPhoneFactory.CreateSmartphone();
Console.WriteLine(iphone15.GetDetails());

var appleNetbook = iPhoneFactory.CreateNetbook();
Console.WriteLine(appleNetbook.GetDetails());

var XioamiFactory = new KiaomiFactory();
var XioamiPro14 = XioamiFactory.CreateLaptop();
Console.WriteLine(XioamiPro14.GetDetails());

var Galaxyfactory = new BalaxyFactory();
var GalaxyEBook = Galaxyfactory.CreateEBook();
Console.WriteLine(GalaxyEBook.GetDetails());

// TASK 3 -> Одинак
Console.WriteLine("Одинак:\n");
Authenticator authenticator1 = Authenticator.Instance;
Authenticator authenticator2 = Authenticator.Instance;
if (authenticator1 == authenticator2)
{
    Console.WriteLine("Singleton патерн функціонує коретнно.");
}
else
{
    Console.WriteLine("Одинак не такий вже й одинак, маячня якась:(");
}

// TASK 4 -> Прототип

Virus parent = new Virus("Parent", "Type1", 1.0, 10);
Virus child1 = new Virus("Child1", "Type2", 0.5, 5);
Virus child2 = new Virus("Child2", "Type3", 0.3, 3);
Virus child3 = new Virus("Child3", "Type3", 0.3, 3);

Virus child4 = new Virus("Child4", "Type3", 0.3, 3);
Virus child5 = new Virus("Child5", "Type3", 0.3, 3);

parent.AddChild(child1);
parent.AddChild(child2);
parent.Children[0].AddChild(child4);
parent.Children[0].AddChild(child5);

Virus clone = (Virus)parent.Clone();

Console.WriteLine("Оригінал: \n");
parent.showTheVirus();

Console.WriteLine("Клон: \n");
clone.showTheVirus();

// TASK 5 -> Будівельник
Director director = new Director();
EnemyBuilder enemyBuilder = new EnemyBuilder();

Character enemy = director.makeEnemy(enemyBuilder);

HeroBuilder heroBuilder = new HeroBuilder();
Character hero = director.makeHero(heroBuilder);

Console.WriteLine(enemy);
Console.WriteLine(hero);