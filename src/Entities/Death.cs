namespace JogoRPG.src.Entities
{
    public class Death : Boss
    {
        public Death (string Name, int Level, string Race, int HealthPoints, int MagicPoints) : base (Name, Level, Race, HealthPoints, MagicPoints){
        }
        public override string Attack(){
            return this.Name + " Scyther Wave";
        }
        public override string AttackSpecial(){
            return this.Name + " Drain Souls";
        }
        public override string Support(){
            return this.Name + " Summon Skeleton";
        }
    }
}