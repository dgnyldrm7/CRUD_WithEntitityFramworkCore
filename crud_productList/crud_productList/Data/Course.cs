using System.ComponentModel.DataAnnotations;

namespace crud_productList.Data
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
       
    }
}
