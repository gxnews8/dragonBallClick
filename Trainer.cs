namespace dragonBallClick
{
    public class Trainer{
        public string Character;
        public string ClickSpeed;
        public Trainer(string WhoDat){
            Character = WhoDat;
            private readonly Dictionary<string,int> characterList = new Dictionary<string,int>
            {
                {"Krillin", 0.5},
                {"Vegeta", 2},
                {"Master Roshi", 1},
                {"Cell", 2.5},
                {"Shenlong", 9001}
            }
            ClickSpeed = characterList(WhoDat);
        }
    }
}