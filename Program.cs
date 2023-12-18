namespace Indexers;


class Program
{
    static void Main(string[] args)
    {
        var cookie = new HttpCookie();
        cookie["name"] = "Cena";
        Console.WriteLine(cookie["name"]);
    }
}

