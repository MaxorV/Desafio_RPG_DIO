namespace RPG
{
     public class Healer : Hero
    {
         public Healer(string Name, int Level, string HeroType, string ArmorType, int Hitpoints)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
            this.ArmorType = ArmorType;
            this.Hitpoints = Hitpoints;
        }
        public override string Attack()
        {
            return this.Name + " Curou seu time ";
        }
        public string Attack(int Bonus)
        {
                return this.Name + $" Curou seu time com bonus de {Bonus} de vida ";
        }
    }
}