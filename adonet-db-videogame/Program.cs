using Microsoft.VisualBasic;

namespace adonet_db_videogame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("inserisci il nome del gioco : ");
                string name = Console.ReadLine();
                Console.Write("inserisci la citta del gioco : ");
                string overview = Console.ReadLine();
                //Console.Write("inserisci l'anno del gioco : ");
                //DateTime year = DateTime.Parse(Console.ReadLine());
                DateTime release_date = DateTime.Now;
                DateTime create_at = DateTime.Now;
                DateTime update_at = DateTime.Now;
                int software_house_id = 1;
                VideogameManager.InserisciVideogame(name, overview, release_date, create_at, update_at , software_house_id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
