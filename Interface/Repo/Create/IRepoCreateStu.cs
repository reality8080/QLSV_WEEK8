using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Interface.Repo.Create
{
    public interface IRepoCreateStu
    {
        public Task<bool> CreateStuAsync(Student stu);
    }
}
