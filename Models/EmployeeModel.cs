namespace FormTagHeilpers.Models
{
    public class EmployeeModel
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }

        public string Designation { get; set; }

        public int Age { get; set; } 

        public Gender Gender { get; set; } 

        public string Married { get; set; }
    } 
    public enum Gender
    {
        Male,Female
    }
}
