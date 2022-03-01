namespace JogoRPG.src.Entities
{
    public class Dragon : Monster
    {
        public Dragon (string Name, int Level, string Race, int HealthPoints, int MagicPoints) : base (Name, Level, Race, HealthPoints, MagicPoints){
        }

        public override string Attack(){
            return this.Name + " Claw";
        }
        public override string AttackSpecial(){
            return this.Name + " Firebreath";
        }
        public override string Support(){
            return this.Name + " Fly";
        }
    }
}