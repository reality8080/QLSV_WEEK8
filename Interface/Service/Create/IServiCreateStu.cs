using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Interface.Service.Create
{
    public interface IServiCreateStu
    {
        public Task<bool> CreateStuAsync(Student stu);
    }
}
