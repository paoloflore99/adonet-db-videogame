using adonet_db_videogame;
using Microsoft.VisualBasic;

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
        VideogameManager.InserisciVideogame(name, overview, release_date, create_at, update_at, software_house_id);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

{
    try
    {
        Console.Write("inserisci id VIdeogames : ");
        int id = int.Parse(Console.ReadLine());
        Videogame ricercaVideo = VideogameManager.CercaVideogame(id);

        if (ricercaVideo != null)
        {
            Console.WriteLine($"il videogggames trovato e {ricercaVideo.Name}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
{
    try
    {
        Console.Write("inserisci id VIdeogames da eliminare : ");
        int id = int.Parse(Console.ReadLine());
        VideogameManager.EliminaVideogames(id);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}