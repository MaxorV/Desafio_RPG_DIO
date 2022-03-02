namespace RPG
{
     public class Assassin : Hero
    {
         public Assassin(string Name, int Level, string HeroType, string ArmorType, int Hitpoints)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
            this.ArmorType = ArmorType;
            this.Hitpoints = Hitpoints;
        }
        public override string Attack()
        {
            return this.Name + " Atacou com sua adaga ";
        }
        public string Attack(int Bonus)
        {
                return this.Name + $" Atacou sua adaga com {Bonus} de bonus de backstab ";
        }
    }
}