using QLSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Interface.Service.Update
{
    public interface IServiUpdateStu
    {
        public Task<bool> UpdateStudent(int id, string name, string faculty, decimal dtb);

    }
}
