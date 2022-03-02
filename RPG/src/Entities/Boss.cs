namespace RPG.src.Entities
{
    public class Boss : Hero
    {
        public Boss(string Name, int Level, string HeroType, string ArmorType, int Hitpoints)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
            this.ArmorType = ArmorType;
            this.Hitpoints = Hitpoints;
        }
        public override string Attack()
        {
            return this.Name + " ";
        }
    }
}