using System.ComponentModel.DataAnnotations;
namespace EnerGovSolutionsAPI.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public List<Roles>? Roles { get; set; }  
    }
}
