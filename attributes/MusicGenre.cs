namespace SantasListGenerator.Attributes
{
    public class MusicGenre
    {
        public void EvaluateGenre(string genre)
        {
            Bools bools;
            switch (genre)
            {
                case "Hip Hop":
                    bools.naughtyOrNice += 10;
                    break;
                case "Folk":
                    bools.naughtyOrNice += 5;
                    break;
                case "Dancehall":
                    bools.naughtyOrNice += 5;
                    break;
                case "Swing":
                    bools.naughtyOrNice += 5;
                    break;
                case "Blues":
                    bools.naughtyOrNice -= 5;
                    break;
                case "Grunge":
                    bools.naughtyOrNice -= 5;
                    break;
                case "Country":
                    bools.naughtyOrNice += 5;
                    break;
                case "Flamenco":
                    bools.naughtyOrNice += 10;
                    break;
                case "Funk":
                    bools.naughtyOrNice += 5;
                    break;
                case "Pop":
                    bools.naughtyOrNice += 10;
                    break;
                case "J-Pop":
                    bools.naughtyOrNice += 10;
                    break;
                case "Shoegaze":
                    bools.naughtyOrNice -= 10;
                    break;
                case "Opera":
                    bools.naughtyOrNice -= 5;
                    break;
                case "Synthpop":
                    bools.naughtyOrNice -= 5;
                    break;
                case "Emo":
                    bools.naughtyOrNice -= 5;
                    break;
                case "Classical":
                    bools.naughtyOrNice += 10;
                    break;
                case "Dubstep":
                    bools.naughtyOrNice += 5;
                    break;
                case "Salsa":
                    bools.naughtyOrNice += 10;
                    break;
                case "Reggae":
                    bools.naughtyOrNice += 5;
                    break;
                case "Reggaeton":
                    bools.naughtyOrNice += 5;
                    break;
                case "Soul":
                    bools.naughtyOrNice += 5;
                    break;
                case "Ska":
                    bools.naughtyOrNice -= 10;
                    break;
                case "Trance":
                    bools.naughtyOrNice -= 10;
                    break;
                case "Punk":
                    bools.naughtyOrNice += 5;
                    break;
                case "R&B":
                    bools.naughtyOrNice += 5;
                    break;
                case "Jazz":
                    bools.naughtyOrNice += 10;
                    break;
                case "Techno":
                    bools.naughtyOrNice += 5;
                    break;
                case "Bluegrass":
                    bools.naughtyOrNice -= 10;
                    break;
                case "Calypso":
                    bools.naughtyOrNice -= 5;
                    break;
                case "World Music":
                    bools.naughtyOrNice -= 10;
                    break;
                case "Gospel":
                    bools.naughtyOrNice += 10;
                    break;
                case "Zouk":
                    bools.naughtyOrNice -= 5;
                    break;
                case "K-Pop":
                    bools.naughtyOrNice += 15;
                    break;
                case "Industrial":
                    bools.naughtyOrNice -= 10;
                    break;
                case "Merengue":
                    bools.naughtyOrNice += 5;
                    break;
                case "Hardcore":
                    bools.naughtyOrNice -= 5;
                    break;
                case "New Wave":
                    bools.naughtyOrNice -= 5;
                    break;
                case "Electro":
                    bools.naughtyOrNice += 5;
                    break;
                case "Indie":
                    bools.naughtyOrNice += 15;
                    break;
                case "Electronic":
                    bools.naughtyOrNice += 5;
                    break;
                case "Latin":
                    bools.naughtyOrNice += 10;
                    break;
                case "House":
                    bools.naughtyOrNice += 5;
                    break;
                case "Metal":
                    bools.naughtyOrNice += 5;
                    break;
                case "Bossa Nova":
                    bools.naughtyOrNice += 10;
                    break;
                case "Disco":
                    bools.naughtyOrNice += 10;
                    break;
                case "Afrobeat":
                    bools.naughtyOrNice += 5;
                    break;
                case "Post-Punk":
                    bools.naughtyOrNice -= 5;
                    break;
                case "Ambient":
                    bools.naughtyOrNice += 5;
                    break;
                case "Trip-Hop":
                    bools.naughtyOrNice -= 5;
                    break;
                case "Rock":
                    bools.naughtyOrNice += 10;
                    break;
                default:
                    Console.WriteLine("Music genre not recognized");
                    break;
            }
        }
    }
}