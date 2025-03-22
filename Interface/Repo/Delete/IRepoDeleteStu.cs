using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Interface.Repo.Delete
{
    public interface IRepoDeleteStu
    {
        public Task<bool> DeleteStuAll();
        public Task<bool> DeleteById(int Id);

    }
}
