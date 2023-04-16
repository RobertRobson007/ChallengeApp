namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void TestGetPointsSum() //sprawdza, czy metoda GetPointsSum() klasy Employee
                                       //zwraca poprawn¹ sumê punktów dla danego pracownika.
        {
            // Arrange
            Employee employee = new Employee("Jan", "Kowalski", 30, new List<int> { 7, 9, 10, 6, 8 });

            // Act
            int pointsSum = employee.GetPointsSum();

            // Assert
            Assert.AreEqual(40, pointsSum);
        }

        [Test]
        public void TestFindBestEmployee() //sprawdza, czy program znajduje pracownika z
                                           //najlepszym wynikiem punktowym na liœcie pracowników. 
        {
            // Arrange
            List<Employee> employees = new List<Employee>()
        {
            new Employee("Jan", "Kowalski", 30, new List<int> { 7, 9, 10, 6, 8 }),
            new Employee("Anna", "Nowak", 25, new List<int> { 10, 9, 8, 9, 7 }),
            new Employee("Piotr", "Zieliñski", 35, new List<int> { 5, 8, 6, 7, 9 })
        };

            // Act
            Employee bestEmployee = employees[0];
            foreach (Employee employee in employees)
            {
                if (employee.GetPointsSum() > bestEmployee.GetPointsSum())
                {
                    bestEmployee = employee;
                }
            }

            // Assert
            Assert.AreEqual("Anna", bestEmployee.FirstName);
            Assert.AreEqual("Nowak", bestEmployee.LastName);
            Assert.AreEqual(25, bestEmployee.Age);
            Assert.AreEqual(43, bestEmployee.GetPointsSum());
        }
    }
}