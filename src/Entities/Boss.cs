namespace JogoRPG.src.Entities
{
    public class Boss
    {
        public Boss (string Name, int Level, string Race, int HealthPoints, int MagicPoints){
            this.Name = Name;
            this.Level = Level;
            this.Race = Race;
            this.HealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
        }
        public string Name;
        public int Level;
        public string Race;
        public int HealthPoints;
        public int MagicPoints;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.Race;
        }

        public virtual string Attack(){
            return this.Name + " Grand Attack";
        }
        public virtual string AttackSpecial(){
            return this.Name + " Sword Rain";
        }
        public virtual string Support(){
            return this.Name + " Stop All";
        }
    }
}