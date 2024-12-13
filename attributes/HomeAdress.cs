namespace SantasListGenerator.Attributes
{
    public class HomeAdress
    {

        Bools bools = new();
        public void godBadAdress(string homeAdress)
        {
            //Console.WriteLine($"Evaluating home address: {homeAdress}");  // Debugging line
            //if (string.IsNullOrEmpty(homeAdress))
            //{
            //Console.WriteLine("Home address is null or empty!");  // Debugging line
            //return;  // Exit if home address is empty
            //}
            switch (homeAdress)
            {
                //Good neighbourhoods \/
                case "Kalfarveien":
                case "Abels gate":
                case "Absalon Beyers gate":
                case "Allégaten":
                case "Allehelgens gate":
                case "Amalie Skrams vei":
                case "Arbeidergaten":
                case "Armauer Hansens vei":
                case "Arne Garborgs gate":
                case "Arnoldus Reimers' gate":
                case "Asbjørnsens gate":
                case "Astrups vei":
                case "Bispengsgaten":
                case "Bjerregårds gate":
                case "Blaauws vei":
                case "Bredsgården":
                case "Breistølen":
                case "Breiviksveien":
                case "Bryggen":
                case "C. Sundts gate":
                case "Christian Michelsens gate":
                case "Christies gate":
                case "Cort Piil-Smauet":
                case "Damsgårdsveien":
                case "Dreggsallmenningen":
                case "Finnegårdsgaten":
                case "Fortunen":
                case "Hans Hauges gate":
                case "Haugeveien":
                case "Jonas Lies vei":
                case "Kaigaten":
                case "Kirkegaten":
                case "Klosteret":
                case "Kong Oscars gate":
                    bools.naughtyOrNice += 10;
                    break;
                //bad neighbourhoods \/
                case "Aad Gjelles gate":
                case "Adolph Bergs vei":
                case "Agnes Mowinckels gate":
                case "Asylplassen":
                case "Baglergaten":
                case "Baneveien":
                case "Bankgaten":
                case "Bjørnsons gate":
                case "Bontelabo":
                case "Bradbenken":
                case "Bredalsmarken":
                case "Bøhmergaten":
                case "Engen":
                case "Fabrikkgaten":
                case "Fjøsangerveien":
                case "Hollendergaten":
                    bools.naughtyOrNice -= 10;
                    break;
            }
            // Debug line to check score
            //Console.WriteLine($"Updated naughtyOrNice score after address: {bools.naughtyOrNice}");
        }
    }
}