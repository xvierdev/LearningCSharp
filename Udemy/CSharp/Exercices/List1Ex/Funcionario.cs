namespace List1Ex
{
    class Funcionario(int id, string name, double salary)
    {
        public int Id { get; private set; } = id;
        public string Name { get; private set; } = name;
        public double Salary { get; private set; } = salary;

        public void IncreaseSalary(double percent)
        {
            Salary *= (1 + percent / 100);
        }
    }
}