namespace Ucu.Poo.Defense
{
    public class Material
    {
        public string Name { get; set; }

        public bool IsDangerous {get; set;}

        public MaterialType Type { get; set; }

        public Material(string name, MaterialType type)
        {
            this.IsDangerous = type.IsDangerous;
            this.Name = name;
            this.Type = type;
        }
    }
}