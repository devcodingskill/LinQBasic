namespace MyData
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
        public bool IsManager { get; set; }
        public decimal Salary { get; set; }
        public string ContactNumber { get; set; }
    }
}
