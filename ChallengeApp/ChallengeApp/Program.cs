//Zadanie dzień 6

// Importuje przestrzeń nazw ChallengeApp, aby móc używać klasy Employee.
using ChallengeApp;

// Tworzy nową pustą listę pracowników.
List<Employee> employees = new List<Employee>();

// Dodaje trzech pracowników do listy, ustawiając ich imiona, nazwiska, wiek oraz wyniki punktowe.
employees.Add(new Employee("Jan", "Kowalski", 30, new List<int> { 7, 9, 10, 6, 8 }));
employees.Add(new Employee("Anna", "Nowak", 25, new List<int> { 10, 9, 8, 9, 7 }));
employees.Add(new Employee("Piotr", "Zieliński", 35, new List<int> { 5, 8, 6, 7, 9 }));

// Ustawia pierwszego pracownika jako początkowo najlepszego.
// Przechodzi przez wszystkich pracowników na liście i porównuje ich wyniki punktowe
// z najlepszym wynikiem punktowym do tej pory.
// Jeśli wynik punktowy nowego pracownika jest lepszy, ustawia go jako nowego najlepszego pracownika.
Employee bestEmployee = employees[0];
foreach (Employee employee in employees)
{
    if (employee.GetPointsSum() > bestEmployee.GetPointsSum())
    {
        bestEmployee = employee;
    }
}

// Wyświetla informacje o najlepszym pracowniku.
Console.WriteLine("Najlepszy pracownik:");
Console.WriteLine("Imię: " + bestEmployee.FirstName);
Console.WriteLine("Nazwisko: " + bestEmployee.LastName);
Console.WriteLine("Wiek: " + bestEmployee.Age);
Console.WriteLine("Suma punktów: " + bestEmployee.GetPointsSum());