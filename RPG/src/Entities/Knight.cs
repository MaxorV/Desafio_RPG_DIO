namespace RPG
{
    public class Knight : Hero
    {
         public Knight(string Name, int Level, string HeroType, string ArmorType, int Hitpoints)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
            this.ArmorType = ArmorType;
            this.Hitpoints = Hitpoints;
        }
        public string Attack(int Bonus)
        {
            return this.Name + " Atacou com bonus de " + Bonus;
        }
    }
}