namespace JogoRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints) : base (Name, Level, HeroType, HealthPoints, MagicPoints){
        }
        public override string Attack(){
        return this.Name + " Double Strike";
        }
        public override string AttackSpecial(){
        return this.Name + " Shuriken Storm";
        }
        public override string Support(){
            return this.Name + " Smokescreen";
        }
    }
}
