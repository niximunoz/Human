
class Program
{
    public static void Main(string[] args)
    {
        string name = "Jorge";

        Human persona1 = new Human(name);

        name = "Carlos";
        int strength = 2;
        int intelligence = 2;
        int dexterity = 1;
        int healt = 200;

        Human persona2 = new Human(name, strength, intelligence, dexterity, healt);

        

        persona1.PrintHuman();
        persona2.PrintHuman();
        

        Human salud = persona1.Attack(persona2);
        Console.WriteLine(salud);

        
    }
}

