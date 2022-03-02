namespace RPG
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, string ArmorType, int Hitpoints)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
            this.ArmorType = ArmorType;
            this.Hitpoints = Hitpoints;
        }
        public override string Attack()
        {
            return this.Name + " Lançou uma Magia";
        }
        
        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " Lançou uma Magia super efetiva com bonus de ataque de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma Magia básica bonus de ataque de " + Bonus;
            }
            
        }
    }
}