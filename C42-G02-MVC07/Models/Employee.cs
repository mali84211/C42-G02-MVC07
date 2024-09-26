using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace C42_G02_MVC07.Models
{
    public class Employee : Controller
    {
        public class Employee : BaseEntity
        {
            [Required(ErrorMessage = "Name is requride !!")]
            public string Name { get; set; }
            [Required(ErrorMessage = "Address is requride !!")]
            public string Address { get; set; }
            [Required(ErrorMessage = "Address is requride !!")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }
            [Required(ErrorMessage = "Address is requride !!")]
            [DataType(DataType.PhoneNumber)]
            public string PhoneNumber { get; set; }
            public int age { get; set; }
            [DataType(DataType.Currency)]
            public decimal Salary { get; set; }
            public bool IsActive { get; set; }
            public bool IsDelete { get; set; }
            public DateTime HiringDate { get; set; }
            public DateTime DateOfCreation { get; set; }
            public int? WorkForId { get; set; }
            public Department? WorkFor { get; set; }
        }
    }
}
