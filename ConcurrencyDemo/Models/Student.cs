
using System.ComponentModel.DataAnnotations;
namespace ConcurrencyDemo.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int SchoolNumber { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}