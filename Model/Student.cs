using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Model
{
    public class Student
    {
        public Student()
        {
        }

        public Student(string name, string faculty, decimal dtb)
        {
            //this.Id= mssv;
            this.Name = name;
            this.Faculty = faculty;
            this.dtb = dtb;
        }

        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public String Name { get; set; } = String.Empty;
        [Required, Column(TypeName = "decimal(18,2)")]
        public Decimal dtb { get; set; }
        [Required, MaxLength(100)]
        public String Faculty { get; set; } = String.Empty;
    }
}
