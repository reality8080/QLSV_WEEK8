using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Interface.Service.Read
{
    public interface IServiReadStu
    {
        public Task<Student?> ReadStuAsync(int? Id);
        public Task<IEnumerable<Student>> ReadAll();
    }
}
