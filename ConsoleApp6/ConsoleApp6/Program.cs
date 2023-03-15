namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee= new Employee();
            Employee employee1 = new Employee("Tom");
            PrintSalary employee2 = new PrintSalary(150000);
            employee2.Print("December");
        }
    }
}