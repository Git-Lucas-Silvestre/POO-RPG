namespace JogoRPG.src.Entities
{
    public class Blackmage : Hero
    {
        
    public Blackmage(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints) : base (Name, Level, HeroType, HealthPoints, MagicPoints){
        }
        public override string Attack(){
        return this.Name + " Fireball";
        }
        public override string AttackSpecial(){
            return this.Name + " Meteor";
        }
        public override string Support(){
            return this.Name + " Buff Status";
        }
    }
}