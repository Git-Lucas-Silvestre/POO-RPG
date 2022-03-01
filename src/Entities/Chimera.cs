namespace JogoRPG.src.Entities
{
    public class Chimera : Monster
    {
        public Chimera (string Name, int Level, string Race, int HealthPoints, int MagicPoints) : base (Name, Level, Race, HealthPoints, MagicPoints){
        }

        public override string Attack(){
            return this.Name + " Strike";
        }
        public override string AttackSpecial(){
            return this.Name + " Sandstorm";
        }
        public override string Support(){
            return this.Name + " Fear";
        }
    }
}