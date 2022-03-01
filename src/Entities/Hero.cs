namespace JogoRPG.src.Entities
{
    public class Hero
    {
        public Hero (string Name, int Level, string HeroType, int HealthPoints, int MagicPoints){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
        }
        public string Name;
        public int Level;
        public string HeroType;
        public int HealthPoints;
        public int MagicPoints;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + " Sword Attack";
        }
        public virtual string AttackSpecial(){
            return this.Name + " Supernova Sword";
        }
        public virtual string Support(){
            return this.Name + " Break Status";
        }

    }
}