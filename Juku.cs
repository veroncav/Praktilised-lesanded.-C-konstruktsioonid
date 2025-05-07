public static void Main(string[] args)
{
    Console.WriteLine("Tere tulemast!");
    string eesnimi = Console.ReadLine();
    Console.WriteLine("Tere, " + eesnimi);

    if (eesnimi.ToLower() == "juku")
    {
        Console.WriteLine("Tule minu juurde külla!");

        Console.WriteLine("Kui vana sa oled, Juku?");
        int vanus = int.Parse(Console.ReadLine());

        if (vanus < 6)
        {
            Console.WriteLine("Sul on tasuta pilet!");
        }
        else if (vanus >= 6 && vanus <= 14)
        {
            Console.WriteLine("Sul on lastepilet!");
        }
        else if (vanus >= 15 && vanus <= 65)
        {
            Console.WriteLine("Sul on täispilet!");
        }
        else if (vanus > 65)
        {
            Console.WriteLine("Sul on sooduspilet!");
        }
        else
        {
            Console.WriteLine("Viga andmetes!");
        }
    }
    else
    {
        Console.WriteLine("Täna mind kodus pole!");
    }

    Console.ReadLine();
}

