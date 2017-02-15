namespace dragonBallClick {
    
    public class Player{
        public string Name;
        public string Password;
        public int TotalPower;
        public int Power;
        public int Level;
        public int PPS;
        public List<Trainer> Trainers;

        public Player(string Alias, string shibboleth){
            this.Name = Alias;
            this.Password = shibboleth;
            Power = 0;
            Level = 1;
            PPS = 0;
        }
        public AddTrainer(string Name){
            Trainer theTrainer = new Trainer(Name);
            PPS += theTrainer.ClickSpeed;
            Trainers.Add(theTrainer);
        }
        public PowerUp(){
            Power += Level;
            TotalPower += Level;
        }
    }

}