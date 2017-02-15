using System.Collections.Generic;

namespace dragonBallClick
{
    public class Trainer{
        public string Character;
        public double ClickSpeed;
        public Trainer(string WhoDat)
        {
            Character = WhoDat;
            Dictionary<string,double> characterList = new Dictionary<string,double>()
            {
                {"Krillin", 0.5},
                {"Vegeta", 2},
                {"Master Roshi", 1},
                {"Cell", 2.5},
                {"Shenlong", 9001}
            };
            ClickSpeed = characterList[Character];
        }
    }
}