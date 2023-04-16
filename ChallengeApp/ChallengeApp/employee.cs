namespace ChallengeApp
{
    //klasa "Employee" w przestrzeni nazw "ChallengeApp", która zawiera informacje o pracowniku, w tym jego imię,
    //nazwisko, wiek i listę punktów.
    public class Employee
    {

        //Klasa zawiera publiczne właściwości "FirstName", "LastName", "Age" i "Points", które mają prywatne
        //settery, co oznacza, że ​​można odczytywać wartości tych właściwości z zewnątrz, ale nie można ich
        //bezpośrednio ustawiać.
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public List<int> Points { get; private set; }

        //Konstruktor klasy "Employee" przyjmuje cztery argumenty, które są wykorzystywane do ustawienia
        //wartości właściwości dla nowo utworzonego obiektu "Employee".
        public Employee(string firstName, string lastName, int age, List<int> points)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Points = points;
        }



        //Metoda "GetPointsSum()" oblicza sumę wszystkich wartości na liście "Points" i zwraca wynik.
        public int GetPointsSum()
        {
            return Points.Sum();
        }
    }
}
