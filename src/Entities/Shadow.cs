namespace JogoRPG.src.Entities
{
    public class Shadow : Boss
    {
        public Shadow (string Name, int Level, string Race, int HealthPoints, int MagicPoints) : base (Name, Level, Race, HealthPoints, MagicPoints){
        }
        public override string Attack(){
            return this.Name + " Jab";
        }
        public override string AttackSpecial(){
            return this.Name + " MegaPunch";
        }
        public override string Support(){
            return this.Name + " Dig";
        }

    }
}