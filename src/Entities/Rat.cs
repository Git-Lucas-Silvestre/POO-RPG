namespace JogoRPG.src.Entities
{
    public class Rat : Monster
    {
        public Rat (string Name, int Level, string Race, int HealthPoints, int MagicPoints) : base (Name, Level, Race, HealthPoints, MagicPoints){
        }

        public override string Attack(){
            return this.Name + " Strike";
        }
        public override string AttackSpecial(){
            return this.Name + " Bite";
        }
        public override string Support(){
            return this.Name + " Scape";
        }

    }
}