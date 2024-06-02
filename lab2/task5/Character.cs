namespace task5
{
    public class Character
    {
        public string Name { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothes { get; set; }
        public string Inventory { get; set; }

        public override string ToString()
        {
            return $"Ім'я: {Name}, колір волосся: {HairColor}, колір очей: {EyeColor}, одяг: {Clothes}, інвентар: {Inventory}";
        }
    }
}
