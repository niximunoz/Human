
class Human
{
    // Properties for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
     //Constructor
    public Human(string name){
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
    // Add a constructor to assign custom values to all fields
    public Human(string name, int strength, int intelligence, int dexterity, int healt){
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = healt;
    }

    public void PrintHuman(){
        Console.WriteLine($"Name :{Name}");
        Console.WriteLine($"Strength :{Strength}");
        Console.WriteLine($"Intelligence :{Intelligence}");
        Console.WriteLine($"Dexterity :{Dexterity}");
        Console.WriteLine($"Health :{Health}");
    }

    // Build Attack method
    public int Attack(Human target)
    {
        int danno = 3 * target.Strength;
        int newHealt = Health - danno;
        return newHealt;
    }
}

