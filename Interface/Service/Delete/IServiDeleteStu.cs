using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Interface.Service.Delete
{
    public interface IServiDeleteStu
    {
        public Task<bool> DeleteStuAsync();
        public Task<bool> DeleteById(int Id);

    }
}
