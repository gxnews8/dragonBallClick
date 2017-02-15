namespace dragonBallClick
{
    public class Trainer{
        public string Character;
        public string ClickSpeed;
        public Trainer(string WhoDat){
            Character = WhoDat;
            private readonly Dictionary<string,string,string> characterList = new Dictionary<string,string,string>
            {
                {"Krillin", 0.5},
                {"Vegeta", 2},
                {"Master Roshi", 1},
                {"Mr. Popo", 2.5},
                {"The Flipping Dragon", 9001}
            }
            ClickSpeed = characterList(WhoDat);
        }
    }
}