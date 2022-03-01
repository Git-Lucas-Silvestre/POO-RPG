namespace JogoRPG.src.Entities
{
    public class Dalahan : Boss
    {
        public Dalahan (string Name, int Level, string Race, int HealthPoints, int MagicPoints) : base (Name, Level, Race, HealthPoints, MagicPoints){
        }
        public override string Attack(){
            return this.Name + " Wing Attack";
        }
        public override string AttackSpecial(){
            return this.Name + " Blast Ray";
        }
        public override string Support(){
            return this.Name + " Devour Allie";
        }
    }
}