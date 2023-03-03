//Zadanie dzień 4

var name = "Ewa";
bool isFemale = true;
var age = 38;

if ((!true) && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if ((!false) && age < 30)
{
    Console.WriteLine("Kobieta po niżej 30 lat");
}
else if (true)
{
    if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa lat 33");
    }
    else if (age > 33 && age <= 40)
    {
        Console.WriteLine("Kobieta między 34 a 40 lat");
    }
}
