namespace Task15_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
                new Department() {Id = 1, Name = "Программирование"},
                new Department() {Id = 2, Name = "Продажи"}
            };

            var employees = new List<Employee>()
            {
                new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
                new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
                new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 1},
                new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 2},
            };

            var emplGroups = departments.GroupJoin(employees, d =>d.Id,e=>e.Id,(d,e) =>
            new
            {
                Departament = d.Name,
                Employee = e.Select(e => e.Name)
            }
            );

            foreach(var group in emplGroups)
            {
                Console.WriteLine(group.Departament);
                foreach(var eml in group.Employee)
                    Console.WriteLine(eml);
            }
        }
    }
}