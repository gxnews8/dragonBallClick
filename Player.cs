using System.Collections.Generic;

namespace dragonBallClick {
    
    public class Player{

        public int TotalPower;
        public int Power;
        public int Level;
        public int PPS;
        public List<Trainer> Trainers;

        public Player(){
            Power = 0;
            Level = 1;
            PPS = 0;
            TotalPower = 0;
        }
        public void AddTrainer(string Name){
            Trainer theTrainer = new Trainer(Name);
            PPS += theTrainer.ClickSpeed;
            Trainers.Add(theTrainer);
        }
        public void PowerUp(){
            Power += Level;
            TotalPower += Level;
        }
    }

}