namespace RPG
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, string ArmorType, int Hitpoints)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
            this.ArmorType = ArmorType;
            this.Hitpoints = Hitpoints;
        }
        public string Name;
        public int level;
        public string HeroType;
        public string ArmorType;
        public int Hitpoints;

        public override string ToString()
        {
            return this.Name + " " + this.level + " " + this.HeroType + " " + this.ArmorType ;
        }

        public Hero()
        {

        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada ";
        }
    }
}