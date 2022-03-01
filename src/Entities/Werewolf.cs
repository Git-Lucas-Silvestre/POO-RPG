namespace JogoRPG.src.Entities
{
    public class Werewolf : Monster
    {
        public Werewolf (string Name, int Level, string Race, int HealthPoints, int MagicPoints) : base (Name, Level, Race, HealthPoints, MagicPoints){
        }

        public override string Attack(){
            return this.Name + " Strike";
        }
        public override string AttackSpecial(){
            return this.Name + " Dismember";
        }
        public override string Support(){
            return this.Name + " Berserk";
        }
    }
}