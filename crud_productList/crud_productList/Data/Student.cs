using System.ComponentModel.DataAnnotations;

namespace crud_productList.Data
{
    public class Student
    {
        [Key] //primary key olduğunu anlıyorum....
        public int StudentId { get; set; }
        public string? StudentName { get; set; } 
        public string? StudentLastName { get; set; } 

    }
}
