namespace task4
{
    public class Virus : ICloneable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(string name, string type, double weight, int age)
        {
            Name = name;
            Type = type;
            Weight = weight;
            Age = age;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }
        public object Clone()
        {
            Virus clone = (Virus)this.MemberwiseClone();
            clone.Children = new List<Virus>();
            foreach (Virus child in this.Children)
            {
                clone.Children.Add((Virus)child.Clone());
            }
            return clone;
        }
        public void showTheVirus()
        {
            Console.WriteLine($"Головний вірус: {this.Name}, Вага: {this.Weight}, Вік: {this.Age}, Тип: {this.Type}");
            Console.WriteLine($"К-ість дочірніх вірусів -> {this.Children.Count}, К-ість 'внуків' -> {this.Children[0].Children.Count}\n");
            foreach (Virus child in this.Children)
            {
                Console.WriteLine($"Представник 2-го покоління -> {child}");
                if (child.Children.Count > 0)
                {
                    Console.WriteLine($"К-ість дочірніх вірусів -> {child.Children.Count}\n" +
                                       $"Представники 3-го покоління -> {string.Join(", ", child.Children)}\n\n");;
                }
                else
                {
                    Console.WriteLine("Дочірніх вірусів немає\n\n");
                }
            }
        }
        public override string ToString()
        {
            return $"{Name} [{Type}]";
        }
    }
}

