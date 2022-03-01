namespace JogoRPG.src.Entities
{
    public class Whitewizard : Hero
    {
        public Whitewizard(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints) : base (Name, Level, HeroType, HealthPoints, MagicPoints){
        }

        public override string Attack(){
        return this.Name + " Holy missile";
        }
        public override string AttackSpecial(){
        return this.Name + " Holy Judgement";
        }
        public override string Support(){
            return this.Name + " Heal All";
        }

    }
}