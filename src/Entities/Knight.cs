namespace JogoRPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints) : base (Name, Level, HeroType, HealthPoints, MagicPoints){
        }
        public override string Attack(){
        return this.Name + " Sword Attack";
        }
        public override string AttackSpecial(){
            return this.Name + " Supernova Sword";
        }
        public override string Support(){
            return this.Name + " Break Status";
        }
    }
}